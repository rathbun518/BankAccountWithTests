using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        Account acc;

        [TestInitialize()]
        public void InitTests()
        {
            acc = new Account();
        }

        [TestMethod()]
        public void CreateAccountWithPositiveInitialBalance()
        {
            double initialBalance = 100;
            var acc = new Account(initialBalance);

            Assert.AreEqual(initialBalance, acc.Balance);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateAccountWithNegativeBalanceShouldThrowException()
        {
            double initialBalance = -1;
            var acc = new Account(initialBalance);
        }


        [TestMethod()]
        [TestCategory("DepositTests")]
        public void DepositPositiveAmount()
        {
            // Arrange
            Account acc = new Account();
            double initialBalance = 0;
            double depositAmount = 10;
            double expectedBalance = initialBalance + depositAmount;

            // Act
            acc.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedBalance, acc.Balance);
        }

        [TestMethod()]
        [Priority(1)]
        [TestCategory("DepositTests")]
        [ExpectedException(typeof(ArgumentException))]
        public void DepositNegativeAmountShouldThrowException()
        {
            // Arrange
            Account a = new Account();
            double depositAmount = -1;

            // Act
            a.Deposit(depositAmount);

            // Assert
            // Assert is handled by ExpectedException attribute
        }

        [TestMethod()]
        [Priority(2)]
        [TestCategory("WithdrawalTests")]
        public void WithdrawalPositiveAmount()
        {
            Account acc = new Account();

            // Arrange
            double initialBalance = 0;
            double withdrawalAmount = 10;
            double expectedBalance = initialBalance - withdrawalAmount;

            // Act
            acc.Withdraw(withdrawalAmount);

            // Assert
            Assert.AreEqual(expectedBalance, acc.Balance);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void WithdrawalNegativeAmountShouldThrowException()
        {
            Account acc = new Account();

            double withdrawalAmount = -10;

            acc.Withdraw(withdrawalAmount);
        }

    }
}