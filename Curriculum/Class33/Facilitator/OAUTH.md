# OAUTH 2.0
1. Read through [this article](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-2.2) register an application with the service provider. 
1. You specify the name of of the application and a Redirect URI
1. Service provider will give us a ClientId and a client secret

### Request Flow (Diagram)
1. Consumer makes a request to the Service Provider to auth the user. 
1. the service provider (SP) authenticates the user and prompts weather they have access to the information. The user then grants access to the server
1. if the user authorizes the consumer, the SP requests a temporary access token for the user.
1. The server redirects the client back to the redirect uri on the consumers website and  with a temporary access token
1. the consumer calls the *token endpoint* on the service provider website to exchange the code for a more permanent access token.
1. the SP grants an access token which can be used to authenticate subsequent requests to protected resources

### Configuration
These are the things that you need to configure when setting up for OAUTH: 
1. The Client ID
1. the Client Secret
1. the Redirect URI
1. that Authorization Endpoint
1. the Token endpoint

These all live on the Developer Dashboard for of the 3rd party service provider (such as Google, GitHub, Microsoft...).

#### Breakdown:
1. The client secret and id are provided after registering the service provider. 
2. Redirect URI is something you can specify when configuring OAUTH authentication on the consumer.
3. This needs to match whatever you specify when creating the application the service provider. this can
can be also called "redirect URL" or "Callback URL" or some sort of variation of that. 


## Resources:

- [OAUTH](https://www.jerriepelser.com/blog/authenticate-oauth-aspnet-core-2)