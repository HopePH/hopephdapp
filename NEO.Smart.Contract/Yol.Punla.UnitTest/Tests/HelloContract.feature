Feature: HelloContract

Scenario: Run a basic NEO Contract
	When I execute the Hello World Smart Contract
	Then I should see that the smart contract execute without errors