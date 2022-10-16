namespace DigiBank.Domain
{
    public class CreditTransaction : Transaction
    {
        public Info Source { get; init; }


        public CreditTransaction(decimal amount, Info source) : base(amount, TransactionType.Credit)
        {
            this.Source = source;
        }

    }
}