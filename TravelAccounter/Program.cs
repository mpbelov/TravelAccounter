using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAccounting;
using TravelAccounting.Model;

namespace TravelAccounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Travel travel = new Travel();
            PaymentsEngine payments = new PaymentsEngine(travel);

            Account A = travel.CreateAccount("A");
            Account B = travel.CreateAccount("B");
            Account C = travel.CreateAccount("C");

            var t1 = travel.CreateTransaction("A pays 50 for himself and B");
            payments.PayEquallyFor(t1, A, true, 50M, B);
            foreach (var t in travel.TransactionLines)
                Console.WriteLine("{0} - {1}", t.Transaction.Details, t);
            printAccounts(A, B, C);

            var t2 = travel.CreateTransaction("C pays 50 for himself and A");
            payments.PayEquallyFor(t2, C, true, 50M, A);
            foreach (var t in travel.TransactionLines)
                Console.WriteLine("{0} - {1}", t.Transaction.Details, t);
            printAccounts(A, B, C);

            var t3 = travel.CreateTransaction("B returns back his debt to A");
            payments.PayBack(t3, A, B, 25M);
            foreach (var t in travel.TransactionLines)
                Console.WriteLine("{0} - {1}", t.Transaction.Details, t);
            printAccounts(A, B, C);

            var t4 = travel.CreateTransaction("B pays for all");
            payments.PayEquallyForAll(t4, B, 300M);
            foreach (var t in travel.TransactionLines)
                Console.WriteLine("{0} - {1}", t.Transaction.Details, t);
            printAccounts(A, B, C);

            ClaimEngine claimEngine = new ClaimEngine(travel);
            var claims = claimEngine.CalcClaims();

            foreach (var c in claims)
                Console.WriteLine("{0} should take {1} from {2}", c.Creditor.Name, c.Amount, c.Debtor.Name);

            Console.ReadLine();
        }

        private static void printAccounts(Account A, Account B, Account C)
        {
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine();
        }
    }
}