# Azure Deployment Instructions

## Deploying the database

- Access `portal.azure.com`
- Click `SQL Databases`
- Select `Add`
- Fill the required form:
  - Name
  - Subscription
  - Resource Groups: A way to organize different azure services that belong together. Similar to a namespace.
  - Source: You can start with a pre-built datatabases or a Blank database.
  - Server (The server will contain the database)
    - Server Name
    - Server Username
    - Server Password
      - Use a unique password. TAs or instructional staff might need access to it in order to help you.
    - Don't select SQL elastic poll for now.
    - Keep the default collation.
    - Wait for the process to finish.
  - **Don't upload your appsettings to github. Use user secrets instead (LINK)**
  - Once the process in complete, you can access it using the `All Resources` tab. Remember that things that are connected need to be in the same resource group.
  - Select your server and click `connection strings`
    - Select ADO.net
      - ADO.net directly works with SQL Server
    - Copy your connection string. It contains everying required to establish a connection to the server
    - Add the password to your connection string after `Password=`
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