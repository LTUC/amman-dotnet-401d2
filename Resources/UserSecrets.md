# How to add User Secretes to .Net Core through VIsual Studio

## Enabling User Secrets

Your first step is to enable User Secrets in your project. This is almost as easy as right clicking on your solution and clicking on "Manage User Secrets".

![manage_user_secrets-474x1024.png](manage_user_secrets-474x1024.png)

 This will open up a secrets.Json file in your Visual studio. 
```
{
  "myBingAPIKey": "123456789",
  "textAPIKey": "123456789",
  "ConnectionStrings": {
    "AzureConnection": "Server=tcp:kevinf.database.windows.net,1433;Initial Catalog=AmandaImages;Persist Security Info=False;User ID=NOT;Password=REAL;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
}
```
This file is NOT stored in your local repo. In fact (depending on your local environment) it is located at  ``` %APPDATA%\microsoft\UserSecrets\<userSecretsId>\secrets.json.
``` 
The format for this file is the same as any json object and should mimic your appSetting.Json. Your secrets are stored in Key : Value pairs here.

Remeber I said almsot that easy.

Now open your csproj file. Since you opened your secret.json you should have a user secret ID line added in the propertyGroup section.
```
<UserSecretsId>ID goes here</UserSecretsId>
```
This is how indivudual secret files are found and accociated with projects
You are going to have to add one more line to the csproj file in the same ItemGroup as your AspNetCore
```
<DotNetCliToolReference Include="Microsoft.Extensions.SecretManager.Tools" Version="2.0.0" />
```
Now we have the user secrets enabled and your secret.json ready to use

## Accessing the user secrets from within your controllers

We are going to access our secrets using the configuration API that we setup in our startup.cs file. TO do that we need to replace our default 
configuration with one we are building from the project files and the secret.json file. Add the following to your startup constructor.
```
public IConfiguration Configuration { get; }

public Startup(IConfiguration configuration)
{
    var builder = new ConfigurationBuilder().AddEnvironmentVariables();
    builder.AddUserSecrets<Startup>();
    Configuration = builder.Build();
}
```
And that is our configuration built. 
Don't forget the ```.AddEnvironmentVariables()``` extention. Your local secrets will work without it but any deployed project will not.
Now we need access to the configuration from our controller of choice.
Bring in the configuration using statment at the top of your controller.
```
using Microsoft.Extensions.Configuration;
```
Then pass the configuration into the controller constructor like we have done with our DBContext.
```
private readonly ImagesContext _context;
private readonly IConfiguration Configuration;

public ImageController(ImagesContext context, IConfiguration configuration)
{
    _context = context;
    Configuration = configuration;
}
```
You can now access your secrets using the Configuration

```
client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", 
                Configuration["myBingAPIKey"]);
```

Your local project is now ready to go. No more worries about uploading api keys and passwrods to git. However since our secret.json file is not deployed with your project that production version on Azure is now missing some importnat stuff.

Fortunetly Azure has a simple way for us to add in user secret data like this. In your app services under application settings you can add in user secret data. Azure sees this environment variable data.

![SettingSettingsInWebApp-1024x754.png](SettingSettingsInWebApp-1024x754.png)

## Resources
https://blogs.msdn.microsoft.com/mihansen/2017/09/10/managing-secrets-in-net-core-2-0-apps/
https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-2.1&tabs=visual-studio
