using DigiBank.Domain;

namespace DigiBank.UnitTests.Domain
{
    public class CreditTransactionShould
    {
        [Fact]
        public void HaveASource()
        {
            var accountInfo = new Info("Name");
            var transaction = new CreditTransaction(2.5m, accountInfo);
            transaction.Source.Should().NotBeNull();
        }
    }
}
