Feature: BaseScenario
	These scenario can be used for any projects

#if you cant build project install SpecFlow.Tools.MsBuild.Generation , SpecFlow.NUnit in Nuget

Background: 
Given the user navigates to the homepage

@Chrome
Scenario:01. Validate title of a web page
	Then the user sees the title contains "Wikipedia"

@Chrome
Scenario:02. Validate URL of a web page
	Then the user sees the url contains "wikipedia"

@Chrome
Scenario:03. Validate Text in a web page source
	Then the user see the "Welcome to " in the page source

@Chrome
Scenario:04. Validate multiple Text in a web page source
	Then the user see
	| expectedText                |
	| In the news                 |
	| Welcome to                  |
	| Wikipedia's sister projects |
