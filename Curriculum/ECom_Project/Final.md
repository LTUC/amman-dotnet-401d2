# Final Ecommerce

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
10. Vulnerability report present in Repo ([Directions Here](https://codefellows.github.io/code-401-dotnet-guide/Curriculum/ECom_Project/VulnerabilityReport){:target="_blank"})

### Shared
- CSS/HTML
- Deployed to Azure
- Your readme should contain the following:
- Readme should contain the following:
  - What is the product you are selling?
  - What claims are you capturing? Why?
  - What policies are you enforcing? Why?
  - What OAUTH providers did you choose
  - Structure/Database Schema for your store DB (not identity)
  - Explanation of your DB Schema (mostly interested in your basket/order tables)
  - Link to your vulnerability report
  - Link to your deployed website
  
