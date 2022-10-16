Feature: Account
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Account for tracking transactions

Link to a feature: [Calculator](DigiBank.Specification/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Initial Deposit
	Given a new account named 'Household'
	When a deposit of 50 is made
	Then the account balance should be 50