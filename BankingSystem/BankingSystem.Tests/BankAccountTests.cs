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
                int id = 123;
                decimal amount = 500;
                BankAccount bankAccount = new BankAccount(id,amount);
                decimal depositAmount = 100;

                bankAccount.Deposit(depositAmount);

                Assert.AreEqual(depositAmount+amount, bankAccount.Balance,"Balance increase with positive  number");
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
        [TestCase(123,500)]
        [TestCase(123, 500.7876)]
        [TestCase(123, 0)]
        public void ConstructorShouldSetBalanceCurrectly(int id,decimal amount)
        {
            {
                BankAccount bankAccount = new BankAccount(id, amount);
                Assert.AreEqual( amount, bankAccount.Balance);
            }

        }
        [Test]
        public void BalanceShouldThrowArgumentExceptionWhenAmountIsNegative()
        {
            {
                int id = 123;
                decimal amount = -100.123m;
                
                Assert.Throws<ArgumentException>(() => new BankAccount(id,amount));
            }
        }
        [Test]
        public void BalanceShouldThrowArgumentExceptionMessage()
        {
            {
                int id = 123;
                decimal amount = -100.123m;
                string message = "Balance must be possitive or zero";

               var ex= Assert.Throws<ArgumentException>(() => new BankAccount(id, amount));
                Assert.AreEqual(message, ex.Message);
            }
        }
        [Test]
        public void ShouldThrowArgumentExceptionWhenIdIsNegative()
        {
            {
                int id = -123;
                decimal amount = 100;

                Assert.Throws<ArgumentException>(() => new BankAccount(id, amount));
            }
        }
        [Test]
        public void ShouldThrowArgumentExceptionMessageForId()
        {
            {
                int id = -123;
                decimal amount = 100;
                string message = "Id must be possitive";

                var e = Assert.Throws<ArgumentException>(() => new BankAccount(id, amount));
                Assert.AreEqual(message, e.Message);
            }
        }



    }
}