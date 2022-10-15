using DigiBank.Domain;

namespace DigiBank.UnitTests.Domain
{
    public class TransactionShould
    {
        [Fact]
        public void HaveAnAmount()
        {
            var transaction = new Transaction(2.50m, TransactionType.Credit);
            transaction.Amount.GetType().Should().Be(typeof(decimal));
            transaction.Amount.Should().Be(2.5m);
        }

        [Fact]
        public void HaveAType()
        {
            var transaction = new Transaction(2.5m, TransactionType.Debit);
            transaction.Type.GetType().Should().Be(typeof(TransactionType));
            transaction.Type.Should().Be(TransactionType.Debit);
        }

        [Fact]
        public void HaveACreditTransactionSubclass()
        {
            var transaction = new CreditTransaction(2.5m);
            transaction.Should().BeAssignableTo<Transaction>();
            transaction.Type.Should().Be(TransactionType.Credit);
        }

        [Fact]
        public void HaveADebitTransactionSubClass()
        {
            var transaction = new DebitTransaction(2.5m);
            transaction.Should().BeAssignableTo<Transaction>();
            transaction.Type.Should().Be(TransactionType.Debit);
        }
    }

  
}
