namespace DigiBank.UnitTests.Domain
{
    public class AccountShould
    {
        public const string AccountName = "Account Name";
        [Fact]
        public void HaveAnAccountName()
        {
            var account = new Account(AccountName);

            account.Info.Name.Should().Be(AccountName);
        }

        [Fact]
        public void HaveTransactions()
        {
            var account = new Account(AccountName);
         
            account.Transactions.Should().BeAssignableTo<IEnumerable<Transaction>>();
        }
    }

   
}