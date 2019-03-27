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
        [InlineData("15 is greater than your balance of -100", 15.00, -100)]

        public void CannotOverdraft(string exp, double amount, double balance)
        {
            //Arrange
            Program.Balance = balance;

            //Act
            string response = Program.Withdraw(amount);

            //Assert
            Assert.Equal(exp, response);

        }

        [Fact]
        public void CanDepositMoney()
        {
            // Arrange < -- setup of the test. 
            Program.Balance = 100;

            // Act < -- actually doing the "thing" for the test
            bool result = Program.Deposit(50);

            // Assert <-- running the test (getting an expected value)
            Assert.True(result);
        }

        [Fact]
        public void DepositAmountMatchesExpected()
        {
            // Arrange < -- setup of the test. 
            Program.Balance = 100;

            // Act < -- actually doing the "thing" for the test
            Program.Deposit(50);

            Assert.Equal(150, Program.Balance);
        }

        [Fact]
        public void CannotDepositNegativeAmount()
        {
            // Arrange < -- setup of the test. 
            Program.Balance = 100;

            // Act < -- actually doing the "thing" for the test
            bool result = Program.Deposit(-50);

            Assert.False(result);
        }

        [Fact]
        public void BalanceDoesNotUpdateForNegativeAmount()
        {
            // Arrange < -- setup of the test. 
            Program.Balance = 100;

            // Act < -- actually doing the "thing" for the test
            Program.Deposit(-50);

            Assert.Equal(100, Program.Balance);
        }

        [Fact]
        public void CannotDepositNegativeAndrew()
        {
            Program.Balance = 200.00;

            decimal result = Program.DepositAndrew(-50);

            Assert.Equal(200, result);

        }

    }
}
