namespace Module17._6._6.Accounts
{
    public class AccountOrdinary : Account
    {
        public override string Type { get; set; } = "Обычный";

        public AccountOrdinary(double balance) : base(balance)
        {
        }

        public override void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;

            Console.WriteLine($"Процентная ставка по вашему вкладу \"{Type}\" составляет {Interest} р/мес.");
        }
    }
}
