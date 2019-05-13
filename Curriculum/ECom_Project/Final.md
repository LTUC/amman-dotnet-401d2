# Final Ecommerce
This is your final submission for your Ecommerce site.
your Final Ecommerce site must be transferred to GH with your
history of commits. See below on how to do this.

In addition to your final, please provide **explicitly what you would like re-graded from sprint 3** within the canvas text submission. 

There will be no resubmits available for this Project. Keep an
eye on the due and close date. **These are final.** 

Focus on your product presentation for this phase. Make sure
everything works as expected and there are no exceptions
or broken pages. 

## Additional Content

In addition to the previous sprints, Please create a 
Vulnerability report: [Directions Here](https://codefellows.github.io/code-401-dotnet-guide/Curriculum/ECom_Project/VulnerabilityReport){:target="_blank"}


## Azure Dev Ops to Github:

Following the directions located [HERE](https://help.github.com/articles/changing-a-remote-s-url/){:target="_blank"} Redirect your URL from VSTS To Github.
You will likely have to create a repository first before redirecting. 

**NOTE**: Refer to the Switching Remote URLs from SSH to HTTPS

## Final Submission
Upon completion of this Project, Your E-commerce site should contain the following:
1. Home Page
   - Introduction to your site
   - Anonymous accessibility
2. Login Page
   - Login to an existing account
   - Anonymous accessibility
3. Registration Page
   - Create an account
   - Anonymous Accessibility
4. Admin Dashboard - (Razor Page)
   - Only accessible by users who hold the role of admin
   - Manage Products (Full CRUD) (Razor Pages)
   - View Last 10 submitted by users
     - Each order detail page should contain:
       - Name of Customer
       - Items ordered
       - Total
       - Date
5. Shopping Page
   - Shows all products in inventory for users to browse
   - Anonymous Access
6. Product Landing Page
   - Displays individual information about each product
   - Anonymous Access
7. Basket Page
   - View all items in the basket. Allow ability to edit/remove the item.
   - Authorize Access Only
8. Checkout page
   - Must be logged in/Authorized
   - Transfer products from their "basket" to an "Order"
9. Receipt/Order Confirmation Page
   - Must be logged in/Authorized
   - Summary of the order that the user just completed. 
10. Personal Profile Page - (Razor Page)
    - Shows user's last 5 orders
    - Displays user information
11. Vulnerability report present in Repo 

### Shared
- CSS/HTML
  - This should be polished. Make it look nice. ALL pages should have client/ready CSS.  
- Exception and error handling. Make sure errors appear when incorrect data is submitted
- The overall flow of each page should be finalized. Make this site as professional looking as possible. 
- Deployed to Azure
- Your readme should contain the following:
- Readme should contain the following:
  - Introduction to your ecommerce site
  - What is the product you are selling?
  - What claims are you capturing? Why?
  - What policies are you enforcing? Why?
  - Structure/Database Schema for your store DB (not identity)
  - Explanation of your DB Schema (mostly interested in your basket/order tables)
  - Link to your deployed website
  - Link and reference to your vulnerability report (should be a separate file in your repo)
  - Name of Contributors

- Tests
	- Test all getter/setters
	- Test all methods that live in your services that implement your interface
	- You do not have to test identity API or the identity DB.
  

### Submit
Submit into Canvas a link to your GH repo. 

## Rubric
- 100 pts. 
- View Rubric in Canvas Assignment