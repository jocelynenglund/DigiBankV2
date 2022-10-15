namespace DigiBank.Domain
{
    public class Account
    {
        public Account(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
    public class Transaction
    {

        private Transaction(decimal amount)
        {
            this.Amount = amount;
        }

        public Transaction(decimal amount, TransactionType type) : this(amount)
        {
            this.Type = type;
        }

        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
    }
    public class CreditTransaction : Transaction
    {
        public CreditTransaction(decimal amount) : base(amount, TransactionType.Credit)
        {
        }
    }
    public enum TransactionType
    {
        Credit = 1,
        Debit = 2
    }
}