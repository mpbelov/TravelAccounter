using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using TravelAccounting.Contracts;

namespace TravelAccounting.Model.Xml {
    public class Serializer : ISerializer {
        public XDocument Serialize(Travel travel) {
            var accountSet = createAccountSet(travel);
            var transactionSet = createTransactionSet(travel);

            var accounts = travel.Accounts.Select(a =>
                new XElement("Account",
                    new XElement("Name", a.Name),
                    new XElement("Id", XmlConvert.ToString(accountSet[a]))
                )
            ).ToArray();

            var transactions = travel.Transactions.Select(t =>
                new XElement("Transaction",
                    new XElement("Details", t.Details),
                    new XElement("Id", XmlConvert.ToString(transactionSet[t])),
                    new XElement("Date", XmlConvert.ToString(t.Date, XmlDateTimeSerializationMode.Utc)),
                    new XElement("Currency",
                        new XElement("Name", t.Currency.Name),
                        new XElement("ShortName", t.Currency.ShortName),
                        new XElement("ExchangeRate", XmlConvert.ToString(t.Currency.ExchangeRate))
                    )
                )
            ).ToArray();

            var transactionLines = travel.TransactionLines.Select(t =>
                new XElement("TransactionLine",
                    new XElement("Creditor", XmlConvert.ToString(accountSet[t.Creditor])),
                    new XElement("Debtor", XmlConvert.ToString(t.Debtor == null ? Guid.Empty : accountSet[t.Debtor])),
                    new XElement("Transaction", XmlConvert.ToString(transactionSet[t.Transaction])),
                    new XElement("ActualAmount", XmlConvert.ToString(t.ActualAmount))
                )
            ).ToArray();

            XDocument doc = new XDocument(
                new XElement("Travel",
                    new XElement("Name", travel.Name),
                    new XElement("Details", travel.Details),
                    new XElement("BaseCurrency",
                        new XElement("Name", travel.BaseCurrency.Name),
                        new XElement("ShortName", travel.BaseCurrency.ShortName)
                    ),
                    new XElement("Accounts", accounts),
                    new XElement("Currencies", travel.Currencies.Select(c =>
                        new XElement("Currency",
                            new XElement("Name", c.Name),
                            new XElement("ShortName", c.ShortName),
                            new XElement("ExchangeRate", XmlConvert.ToString(c.ExchangeRate))
                            )
                        ).ToArray()
                    ),
                    new XElement("Transactions", transactions),
                    new XElement("TransactionLines", transactionLines)
                )
            );
            return doc;
        }

        public Travel Deserialize(XDocument xDoc) {
            var travel = new Travel() {
                Name = xDoc.Root.Element("Name").Value,
                Details = xDoc.Root.Element("Details").Value,
            };
            travel.BaseCurrency.Name = xDoc.Root.Element("BaseCurrency").Element("Name").Value;
            travel.BaseCurrency.ShortName = xDoc.Root.Element("BaseCurrency").Element("ShortName").Value;

            foreach (var x in xDoc.Root.Element("Currencies").Elements("Currency")) {
                travel.Currencies.Add(
                    new Currency() {
                        Name = x.Element("Name").Value,
                        ShortName = x.Element("ShortName").Value,
                        ExchangeRate = XmlConvert.ToDecimal(x.Element("ExchangeRate").Value)
                    }
                );
            }

            var accountSet = createAccountSet(xDoc, travel);
            var transactionSet = createTransactionSet(xDoc, travel);

            foreach (var a in accountSet.Values)
                travel.Accounts.Add(a);

            foreach (var t in transactionSet.Values)
                travel.Transactions.Add(t);

            foreach (var x in xDoc.Root.Element("TransactionLines").Elements("TransactionLine")) {
                var creditorId = XmlConvert.ToGuid(x.Element("Creditor").Value);
                var debtorId = XmlConvert.ToGuid(x.Element("Debtor").Value);
                var transId = XmlConvert.ToGuid(x.Element("Transaction").Value);

                var creditor = accountSet[creditorId];
                var trans = transactionSet[transId];
                Account debtor = null;
                if (debtorId != Guid.Empty)
                    debtor = accountSet[debtorId];

                travel.TransactionLines.Add(
                    new TransactionLine(trans) {
                        ActualAmount = XmlConvert.ToDecimal(x.Element("ActualAmount").Value),
                        Creditor = creditor,
                        Debtor = debtor
                    }
                );
            }

            return travel;
        }

        private static Dictionary<Guid, Transaction> createTransactionSet(XDocument xDoc, Travel travel) {
            var transactionSet = new Dictionary<Guid, Transaction>();
            foreach (var x in xDoc.Root.Element("Transactions").Elements("Transaction")) {
                transactionSet.Add(
                    XmlConvert.ToGuid(x.Element("Id").Value),
                    new Transaction(travel) {
                        Details = x.Element("Details").Value,
                        Date = XmlConvert.ToDateTime(x.Element("Date").Value, XmlDateTimeSerializationMode.Utc),
                        Currency = new Currency() {
                            Name = x.Element("Currency").Element("Name").Value,
                            ShortName = x.Element("Currency").Element("ShortName").Value,
                            ExchangeRate = XmlConvert.ToDecimal(x.Element("Currency").Element("ExchangeRate").Value)
                        }
                    }
                );
            }
            return transactionSet;
        }

        private static Dictionary<Guid, Account> createAccountSet(XDocument xDoc, Travel travel) {
            var accountSet = new Dictionary<Guid, Account>();
            foreach (var x in xDoc.Root.Element("Accounts").Elements("Account")) {
                accountSet.Add(
                    XmlConvert.ToGuid(x.Element("Id").Value),
                    new Account(travel) {
                        Name = x.Element("Name").Value
                    }
                );
            }
            return accountSet;
        }

        private static Dictionary<Transaction, Guid> createTransactionSet(Travel travel) {
            var transactionSet = new Dictionary<Transaction, Guid>();
            foreach (var t in travel.Transactions)
                transactionSet.Add(t, Guid.NewGuid());
            return transactionSet;
        }

        private static Dictionary<Account, Guid> createAccountSet(Travel travel) {
            var accountSet = new Dictionary<Account, Guid>();
            foreach (var a in travel.Accounts)
                accountSet.Add(a, Guid.NewGuid());
            return accountSet;
        }

    }
}