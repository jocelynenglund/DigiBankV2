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
}