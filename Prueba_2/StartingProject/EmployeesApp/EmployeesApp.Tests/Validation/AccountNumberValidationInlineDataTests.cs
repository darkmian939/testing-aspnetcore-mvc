using EmployeesApp.Validation;

namespace EmployeesApp.Tests
{
    public class AccountNumberValidationinlineDataTests
    {
        private readonly AccountNumberValidation _validation;

        public AccountNumberValidationinlineDataTests()
        {
            _validation = new AccountNumberValidation();
        }

        [Theory]
        [InlineData("1234-345456576-23")]
        [InlineData("12-3454565676-23")]
        public void IsValid_ValidAccountNumber_ReturnsFalse(string accountNumber)
        {
            Assert.False(_validation.IsValid(accountNumber));
        }
    }
}