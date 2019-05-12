Feature: Footer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	@Footer
Scenario Outline: Usercan openlinks under Information section
	When user clicks on '<information link>' option
	Then correct '<page>' is displayed

	Examples:
	| information link            | page                       |
	| Specials                    | Price drop                 |
	| New Products                | New products               |
	| Best sellers                | Best sellers               |
	| Our Stores                  | Our store                  |
	| Contact Us                  | Contact                    |
	| Terms and conditions of use | Terms and conditions of use|
	| About us                    | About us                   |
	| Sitemap                     | Sitemap                    |
	
	@Footer
Scenario Outline: User can open links under My Account
    Given user opens sign in page	
	And enters correct credentials
	And  user submits the login form
	When user clicks on '<link>' option under Myaccount section
	Then correct '<page>' under Myaccount is displayed

	Examples:
	| link            | page                      |
	| My orders                   | Order history             |
	| My Credit Slips             | Credit Slips              |
	| My addreses                 | My addreses               |
	| My personal info            | Your personal information |
	
	