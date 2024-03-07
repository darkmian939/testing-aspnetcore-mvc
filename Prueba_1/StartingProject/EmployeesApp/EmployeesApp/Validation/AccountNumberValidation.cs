namespace EmployeesApp.Validation
{
    public class AccountNumberValidation
    {
        private const int startingPartLenght = 3;
        private const int middlePartLength = 10;
        private const int lastpartLenght = 2;

        public bool IsValid(string accountNumber)
        {
            var firstDelimiter = accountNumber.IndexOf('-');
            var secondDelimiter = accountNumber.LastIndexOf('-');

            if (firstDelimiter == -1 || firstDelimiter == secondDelimiter)
                throw new ArgumentException();

            var firstPart = accountNumber.Substring(0, firstDelimiter);
            if (firstPart.Length!= startingPartLenght)
                return false;

            var tempPart = accountNumber.Remove(0, startingPartLenght + 1);
            var middlePart = tempPart.Substring(0, tempPart.IndexOf('-'));

            if (middlePart.Length!= middlePartLength)
                return false;

            var lastPart = accountNumber.Substring(secondDelimiter + 1);
            if (lastPart.Length!= lastpartLenght)
                return false;

            return true;
        }
    }
}