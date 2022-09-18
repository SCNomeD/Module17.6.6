namespace Module17._6._6.Accounts
{
    public abstract class Account : ICalculate
    {
        // тип учетной записи
        public abstract string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public Account(double balance)
        {
            Balance = balance;
        }

        public abstract void CalculateInterest();
    }
}
