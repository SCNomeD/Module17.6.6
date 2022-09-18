using Module17._6._6.Accounts;

namespace Module17._6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accountOrdinary = new AccountOrdinary(50000.0);
            var accountSalary = new AccountSalary(30000.0);

            Calculator.CalculateInterestAccount(accountOrdinary);
            Calculator.CalculateInterestAccount(accountSalary);
        }
    }
}