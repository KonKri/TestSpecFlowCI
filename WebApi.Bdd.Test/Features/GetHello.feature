Feature: GetHello

Test hello

@tag1
Scenario: GetHelloScenario
	When making an HTTP GET req
	Then the response should be hello
