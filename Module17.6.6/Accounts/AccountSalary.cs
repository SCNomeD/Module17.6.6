namespace Module17._6._6.Accounts
{
    public class AccountSalary : Account
    {
        public override string Type { get; set; } = "Зарплатный";

        public AccountSalary(double balance) : base(balance)
        {
        }

        public override void CalculateInterest()
        {
            Interest = Balance * 0.5;

            Console.WriteLine($"Процентная ставка по вашему вкладу \"{Type}\" составляет {Interest} р/мес.");
        }
    }
}
