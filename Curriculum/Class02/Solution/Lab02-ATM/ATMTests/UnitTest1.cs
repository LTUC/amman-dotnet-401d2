using System;
using Lab02_ATM;
using Xunit;


namespace ATMTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanDeposit()
        {
            //Assert
            Assert.True(Program.Deposit(10.00));

        }

        [Fact]
        public void CannotDepositeNegative()
        {
            //Assert
            Assert.False(Program.Deposit(-10.00));
        }

        [Fact]
        public void DepositIsCorrect()
        {
            //Arrange
            Program.Balance = 1000;

            //Act
            Program.Deposit(45);

            //Assert
            Assert.Equal(1045, Program.Balance);

        }


        [Fact]
        public void CandWithdraw()
        {
            //Arrange
            Program.Balance = 20;

            //Act
            Program.Withdraw(10.00);

            //Assert
            Assert.Equal(10, Program.Balance);

        }

        [Fact]
        public void CannotWithdrawBalance()
        {
            //Arrange
            Program.Balance = 20;

            //Act
            Program.Withdraw(21.00);

            //Assert
            Assert.Equal(20, Program.Balance);

        }


        [Theory]
        [InlineData("Withdraw Successful", 10.00, 20.00)]
        [InlineData("Your are trying to withdraw an invalid amount", 0, 500)]
        [InlineData("10 is greater than your balance of 5", 10.00, 5.00)]

        public void CannotOverdraft(string exp, double amount, double balance)
        {
            //Arrange
            Program.Balance = balance;

            //Act
            string response = Program.Withdraw(amount);

            //Assert
            Assert.Equal(exp, response);

        }
    }
}
