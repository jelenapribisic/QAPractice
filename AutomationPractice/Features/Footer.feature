Feature: Footer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Usercan openlinks under Information section
	When user clicks on '<information link>' option
	Then correct '<page>' is displayed

	Examples:
	| information link            | page       |
	| Specials                    | Price drop |
	| New Products                |            |
	| Best sellers                |            |
	| Our Stores                  |            |
	| Contact Us                  |            |
	| Terms and conditions of use |            |
	| About us                    |            |
	| Sitemap                     |            |
	
