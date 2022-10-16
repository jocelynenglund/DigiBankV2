using System.Transactions;

namespace DigiBank.Domain
{
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

    public class CashDeposit : CreditTransaction
    {
        public const string CASHDEPOSIT = "Cash Deposit";
        public CashDeposit(decimal amount) : base(amount, new Info(CASHDEPOSIT))
        {
        }
    }
}