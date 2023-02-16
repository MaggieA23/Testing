using NUnit.Framework;
using System;

namespace BankingSystem.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DepositSouldIncreaseBalance()
        {
            {
                BankAccount bankAccount = new BankAccount(123);
                decimal depositAmount = 100;

                bankAccount.Deposit(depositAmount);

                Assert.AreEqual(depositAmount, bankAccount.Balance);
            }
           
        }
        [Test]
        public void AccountInicializeWithPositiveValue()
        {
            {
                BankAccount bankAccount = new BankAccount(123,2000m);

                Assert.AreEqual(2000m, bankAccount.Balance);
            }

        }
        [Test]
        public void NegativeAmountShouldThrowInvalidOperationExceptions()
        {
            {
                BankAccount bankAccount = new BankAccount(123);
                decimal depositAmount = -100;

                Assert.Throws<InvalidOperationException>(() => bankAccount.Deposit(depositAmount));
            }
        }
        [Test]
        public void NegativeAmountShouldThrowInvalidOperationExceptionsWithMessage()
        {
            {
                BankAccount bankAccount = new BankAccount(123);
                decimal depositAmount = -100;

               var ex= Assert.Throws<InvalidOperationException>(() => bankAccount.Deposit(depositAmount));
                Assert.AreEqual(ex.Message, "Negative amount");
            }
        }
        [TestCase(100)]
        [TestCase(3500)]
        [TestCase(2400)]
        public void DepositShouldIncreaseBalanceAll(decimal depositAmount)
        {
            {
                BankAccount bankAccount = new BankAccount(123);
                

                bankAccount.Deposit(depositAmount);

                Assert.AreEqual(depositAmount, bankAccount.Balance);
            }

        }
        [Test]
        public void DepositShouldIncreaseBalance()
        {
            {
                int id = 123;
                decimal amountDeposit = 2000m;
                BankAccount account = new BankAccount(id);

                account.Deposit(amountDeposit);

                Assert.AreEqual(amountDeposit, account.Balance);
            }
        }
        [Test]
        public void ConstructorShouldSetZeroBalance()
        {
            {
                int id = 123;
              
                BankAccount account = new BankAccount(id);

                Assert.AreEqual(0, account.Balance);
            }
        }
        [Test]
        public void IdShouldBeSet()
        {
            {
                int id = 123;

                BankAccount account = new BankAccount(id);

                Assert.AreEqual(id, account.Id);
            }
        }



    }
}