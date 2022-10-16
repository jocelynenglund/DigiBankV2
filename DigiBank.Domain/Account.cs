namespace DigiBank.Domain
{
    public class Account
    {
        public Account(string name)
        {
            Info = new Info(name);
        }

        public Info Info { get; set; }
        private List<Transaction> _transactions = new List<Transaction>();
        public IEnumerable<Transaction> Transactions =>
            _transactions.AsEnumerable()
        public decimal Balance => _transactions.Sum(x => x.Amount);
        public void Credit(decimal creditAmount, Info info)
        {
            throw new NotImplementedException();
        }

        public void Deposit(decimal depositAmount)
        {
            _transactions.Add(new CashDeposit(depositAmount));
        }
    }
}