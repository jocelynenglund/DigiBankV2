namespace DigiBank.Domain
{
    public class CreditTransaction : Transaction
    {
        public CreditTransaction(decimal amount) : base(amount, TransactionType.Credit)
        {
        }
    }
}