using EmployeesApp.Validation;

namespace EmployeesApp.Tests
{
    public class AccountNumberValidationTest
    {
        private readonly AccountNumberValidation _validation;

        public AccountNumberValidationTest()
        {
            _validation = new AccountNumberValidation();
        }

        [Fact]
        public void IsValid_ValidAccountNumber_ReturnsTrue()
        {
            Assert.True(_validation.IsValid("123-4543234576-23"));
        }
    }
}


