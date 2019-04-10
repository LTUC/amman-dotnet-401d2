# Azure Deployment Instructions

## Deploying the database

1. Navigate to `portal.azure.com`
2. On the Azure Portal sidebar, select `SQL Databases`
3. On the top, underneath the header, select `Add`
- Fill the required form:
  - Create a new resource group (if desired)
  - Subscription, Choose either pay as you go, or your free trial subscription.
  - choose a database name
  - Create or select a DB Server
  - Server (The server will contain the database)
   - Name
   - Username
   - Password
         - Use a unique password. TAs or instructional staff might need access to it in order to help you
   - Keep location at it's default
   - Wait for the process to finish.
   - Click `Select` to generate the new server
  - Select No to SQL elastic pool
  - Under `Compute + storage`, select "Configure Database
   - Choose "Basic" and select `Apply`
  - Select "Review + Create"
  - Review your configurations
  - Select Create
  
4. Wait for your database to complete creation.
5. You can view your SQL Database by either selecting "Go to Resource" or reselcting the "SQL Database" on the sidebar
6. Once you are in your resource click the "Show database connection strings"
    - Select ADO.net
     - ADO.net directly works with SQL Server
    - Copy your connection string to a temporary external location (such as a notepad). It contains everying required to establish a connection to the server. You will be slightly modifying the connection string before transferring it to your application
    - Add the password of the server you just created to your connection string after `Password=` (delete the `{your_password}` and replace it with your password)
    - Update the `{your_username}` with your server username.
    - Paste the connection strings into user secrets as `ProductionConnection`
    - Don't remove the old connection string from the `appsettings.json` file yet
    - Add the old Connection to the application to user secrets as `DefaultConnection`
    - Use the `ConnectionStrings:ProductionConnection` string in your `Startup.cs` file.
      - `options.UseSqlServer(Configuration["ProductionConnection"])`
        - if this doesn't work. Just use `ProductionConnection` as Configuration's argument.
  - when you use `update-database` you might get a firewall error.
    - This needs to be resolved in Azure
    - Go to the database you are trying to access
    - Click `Set server Firewall`
    - Click the plus sign
    - It should populate your IP automatically.
  - Once the firewall error is completed, you should be able to update your database remotelly.
  - Use a database manager to access your created server (You can get your server name in azure. It should end in `database.windows.net`)
  - This should effectively deploy your your database.

## Deploying the Web App

- Right click the project and click publish.
- Make sure that your Microsoft account is the account you used to register with Azure
- You app name needs to be unique
- Select your Subscription
- Select your Resource Group
- Don't worry about Hosting Plan or Appication Insights
- Wait for the processto continue
- Click `application seetings` (Located under settings) on your deployed web app
  - Application Settigs
    - Api Keys go in here
  - Connection Settings
    - Connection Strings go in here
  - Add a connection string (type should be SQLAzure)
    - Remove the quotes from the connection string.
  
## How to update yoru deployed Application
  - Databases
    - Run the update database command
  - Web App
    - Right click and re-click the `Publish` button.
