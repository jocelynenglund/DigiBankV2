using DigiBank.Domain;

namespace DigiBank.Specification.StepDefinitions
{
    [Binding]
    public sealed class AccountStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private Account _firstAccount;
        private Account _secondAccount;

        [Given(@"a new account named '(.*)'")]
        public void GivenANewAccountNamed(string accountName)
        {
     
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            _firstAccount = new Account(accountName);
        }

        [Given("And another account with (.*)")]
        public void GivenTheSecondNumberIs(decimal number)
        {
            //TODO: implement arrange (precondition) logic
            _secondAccount = new Account("second");
        }

        [When(@"a deposit of (.*) is made")]
        public void WhenTheTwoNumbersAreAdded(decimal depositAmount)
        {
            //TODO: implement act (action) logic
            _firstAccount.Deposit(depositAmount);
        }

        [Then("the account balance should be (.*)")]
        public void ThenTheResultShouldBe(decimal result)
        {
            _firstAccount.Balance.Should().Be(result); 
        }
    }
}