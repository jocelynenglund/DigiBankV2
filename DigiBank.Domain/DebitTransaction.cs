namespace DigiBank.Domain
{
    public class DebitTransaction: Transaction
    {
        public DebitTransaction(decimal amount):base(amount,TransactionType.Debit)
        {
        }
    }
}