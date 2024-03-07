using EmployeesApp.Validation;

namespace EmployeesApp.Tests
{
    public class AccountNumberValidationTestingExceptionsTest
    {
        private readonly AccountNumberValidation _validation;

        public AccountNumberValidationTestingExceptionsTest()
        {
            _validation = new AccountNumberValidation();
        }

        [Theory]
        [InlineData("123-34545657633=23")]
        [InlineData("123+345456567633=23")]
        [InlineData("123+345456567633=23")]
        public void IsValid_InvalidDelimiters_ThrowsArgumentExeption(string accNumber)
        {
            Assert.Throws<ArgumentException>(() => _validation.IsValid(accNumber));
        }
    }
}


