using EmployeesApp.Validation;

namespace EmployeesApp.Tests
{
    public class AccountNumberValidationAdditionalexamsTest
    {
        private readonly AccountNumberValidation _validation;

        public AccountNumberValidationAdditionalexamsTest()
        {
            _validation = new AccountNumberValidation();
        }

        [Theory]
        [InlineData("123-345456567-23")]
        [InlineData("123-345456567633-23")]

        public void IsValid_ValidAccountNumber_ReturnsFalse(string accountNumber)
        {
            Assert.False(_validation.IsValid(accountNumber));
        }
        [Theory]
        [InlineData("123-3454565676-2")]
        [InlineData("123-3454565676-233")]
        public void IsValid_AccountNumberLastPartWrong_ReturnsFalse(string accNumber)
        {
            Assert.False(_validation.IsValid(accNumber));
        }
    }
}