# Final Ecommerce
This is your final submisison for your Ecommerce site.
your Final Ecommerce site must be transferred to GH with your
history of commits. See below on how to do this.

There will be no resubmits available for this Project. Keep an
eye on the due and close date. These are final. 

Focus on your product presentation for this phase. Make sure
everything works as expected and there are no exeptions
or broken pages. 

## Additional Content

In addition to the previous sprints, Please create a 
Vulnerability report: [Directions Here](https://codefellows.github.io/code-401-dotnet-guide/Curriculum/ECom_Project/VulnerabilityReport){:target="_blank"}


## VSTS to Github:

Following the directions located [HERE](https://help.github.com/articles/changing-a-remote-s-url/){:target="_blank"} Redirect your URL from VSTS To Github.
You will likely have to create a repository first before redirecting. 

**NOTE**: Refer to the Switching Remote URLs from SSH to HTTPS

## Final Submission
Upon completion of this Project, Your Ecommerce site should contain the following:
1. Home Page
   - Introduction to your site
   - Anonymous accessibility
2. Login Page
   - Login to an existing account
   - Anonymous accessibility
   - Option to login with at least two 3rd party service providers (OAUTH)
3. Registration Page
   - Create an account
4. Admin Dashboard - 
   - Only accessible by users who hold the role of admin
   - Manage Inventory (Full CRUD)
   - View Last 20 submitted by users
     - Each order detail should contain:
       - Name of Customer
       - Billing Address
       - Items ordered
       - Total
       - Date
5. Shopping Page
   - Shows all products in inventory for users to browse
6. Product Landing Page
   - Displays individual information about each product
7. Basket Page
   - View all items in the basket. Allow ability to edit/remove the item.
8. Checkout page
   - Must be logged in/Authorized
   - Capture user information about their order (NO Personal Identifiable information please)
   - Transfer products from their "basket" to an "Order"
   - Auth.NET Payment Processing
     - Fake Credit Card is only option for payment checkout
9. Recipt/Order Confirmation Page
   - Must be logged in/Authorized
   - Summary of the order that the user just completed. 
10. Personal Profile Page
    - Shows user's last 5 orders (this can be either a separate razor page or a View component)
    - Displays user information
11. Vulnerability report present in Repo 

### Shared
- CSS/HTML
  - This should be polished. Make it look nice. ALL pages should have client/ready CSS.  
- Exception and error handling. Make sure errors appear when incorrect data is submitted
- Deployed to Azure
- Your readme should contain the following:
- Readme should contain the following:
  - Introduction to your ecommerce site
  - What is the product you are selling?
  - What claims are you capturing? Why?
  - What policies are you enforcing? Why?
  - What OAUTH providers did you choose
  - Structure/Database Schema for your store DB (not identity)
  - Explanation of your DB Schema (mostly interested in your basket/order tables)
  - Link to your deployed website
  - Link and reference to your vulnerability report (should be a separate file in your repo)
  - Name of Contributors
  

### Submit
Submit into Canvas a link to your GH repo. 

## Rubric
- 105pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	105       | Program runs as expected, no exceptions during execution |
	75       | Program meets all of the  functionality requirements described above // Program runs/compiles, Program contains logic/process errors|
	60       | Program meets most of the functionality requirements descibed above  // Program runs/compiles, but throws exceptions during execution |
	45       | Program missing most of the functionality requirements descibed above // Program runs/compiles |
	30       | Missing Readme Document // Readme Document does not meet standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 45pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 75/105 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	45       | Code meets Industry Standards // methods and variables namings are appropriate // Selective and iterative statements are used appropriately, Fundamentals are propertly executed // Clearly and cleanly commented |
	30       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments |
	15       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |
