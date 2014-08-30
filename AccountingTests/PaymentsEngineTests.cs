//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Linq;
//using TravelAccounting.Model;
//using TravelAccounting;

//namespace AccountingTests
//{
//    [TestClass]
//    public class PaymentsEngineTests
//    {
//        [TestMethod]
//        public void PaySameForAndReturnBack()
//        {
//            Travel travel = new Travel()
//            {
//                Name = "Holydays"
//            };
//            PaymentsEngine payments = new PaymentsEngine(travel);

//            Account A = travel.CreateAccount("A");
//            Account B = travel.CreateAccount("B");

//            var t1 = travel.CreateTransaction("A pays 50 for himself and B");
//            payments.PayEquallyFor(t1, A, true, 50M, B);

//            Assert.AreEqual(25M, A.Expense);
//            Assert.AreEqual(25M, A.Credit);
//            Assert.AreEqual(0M, A.Debt);

//            Assert.AreEqual(25M, B.Expense);
//            Assert.AreEqual(0M, B.Credit);
//            Assert.AreEqual(25M, B.Debt);

//            var expenseTran = travel.TransactionLines.Where(t => t.Creditor == A && t.Debtor == null).FirstOrDefault();
//            Assert.IsNotNull(expenseTran);
//            Assert.AreEqual(25M, expenseTran.BaseAmount);
//            Assert.AreEqual(t1, expenseTran.Transaction);

//            expenseTran = travel.TransactionLines.Where(t => t.Creditor == B && t.Debtor == null).FirstOrDefault();
//            Assert.IsNotNull(expenseTran);
//            Assert.AreEqual(25M, expenseTran.BaseAmount);
//            Assert.AreEqual(t1, expenseTran.Transaction);

//            var debtTran = travel.TransactionLines.Where(t => t.Creditor == A && t.Debtor == B).FirstOrDefault();
//            Assert.IsNotNull(debtTran);
//            Assert.AreEqual(25M, debtTran.BaseAmount);
//            Assert.AreEqual(t1, debtTran.Transaction);

//            var t2 = travel.CreateTransaction("B returns back his debt to A");
//            payments.PayBack(t2, A, B, 25M);

//            Assert.AreEqual(25M, A.Expense);
//            Assert.AreEqual(0M, A.Credit);
//            Assert.AreEqual(0M, A.Debt);

//            Assert.AreEqual(25M, B.Expense);
//            Assert.AreEqual(0M, A.Credit);
//            Assert.AreEqual(0M, A.Debt);

//            debtTran = travel.TransactionLines.Where(t => t.Creditor == B && t.Debtor == A).FirstOrDefault();
//            Assert.IsNotNull(debtTran);
//            Assert.AreEqual(25M, debtTran.BaseAmount);
//            Assert.AreEqual(t2, debtTran.Transaction);
//        }

//        //[TestMethod]
//        //public void PaySameForAndReturnBack()
//        //{
//        //    Travel travel = new Travel()
//        //    {
//        //        Name = "Holydays"
//        //    };
//        //    PaymentsEngine payments = new PaymentsEngine(travel);

//        //    Account A = travel.CreateAccount("A");
//        //    Account B = travel.CreateAccount("B");

//        //    var t1 = travel.CreateTransaction("A pays 50 for himself and B");
//        //    payments.PayEquallyFor(t1, A, true, 50M, B);

//        //    Assert.AreEqual(25M, A.Expense);
//        //    Assert.AreEqual(25M, A.Credit);
//        //    Assert.AreEqual(0M, A.Debt);

//        //    Assert.AreEqual(25M, B.Expense);
//        //    Assert.AreEqual(0M, B.Credit);
//        //    Assert.AreEqual(25M, B.Debt);

//        //    var expenseTran = travel.TransactionLines.Where(t => t.Creditor == A && t.Debtor == null).FirstOrDefault();
//        //    Assert.IsNotNull(expenseTran);
//        //    Assert.AreEqual(25M, expenseTran.Amount);
//        //    Assert.AreEqual(t1, expenseTran.Transaction);

//        //    expenseTran = travel.TransactionLines.Where(t => t.Creditor == B && t.Debtor == null).FirstOrDefault();
//        //    Assert.IsNotNull(expenseTran);
//        //    Assert.AreEqual(25M, expenseTran.Amount);
//        //    Assert.AreEqual(t1, expenseTran.Transaction);

//        //    var debtTran = travel.TransactionLines.Where(t => t.Creditor == A && t.Debtor == B).FirstOrDefault();
//        //    Assert.IsNotNull(debtTran);
//        //    Assert.AreEqual(25M, debtTran.Amount);
//        //    Assert.AreEqual(t1, debtTran.Transaction);

//        //    var t2 = travel.CreateTransaction("B returns back his debt to A");
//        //    payments.PayBack(t2, A, B, 25M);

//        //    Assert.AreEqual(25M, A.Expense);
//        //    Assert.AreEqual(0M, A.Credit);
//        //    Assert.AreEqual(0M, A.Debt);

//        //    Assert.AreEqual(25M, B.Expense);
//        //    Assert.AreEqual(0M, A.Credit);
//        //    Assert.AreEqual(0M, A.Debt);

//        //    debtTran = travel.TransactionLines.Where(t => t.Creditor == B && t.Debtor == A).FirstOrDefault();
//        //    Assert.IsNotNull(debtTran);
//        //    Assert.AreEqual(25M, debtTran.Amount);
//        //    Assert.AreEqual(t2, debtTran.Transaction);
//        //}

//    }
//}