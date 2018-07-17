# OAUTH 2.0
1. Register an application with the service provider. 
2. You speicy the name of of the application and a Redirect URI
3. Service provider will give us a ClientId and a client secret

### Request Flow
1. Consumer makes a request to the Service Provider to auth the user. 
2. the s.p authenticates the user and prompts weather they have access to the information
3. if the user authorizes the consumer, the sp redirects back to the redirect uri on the consuerms webstie wtih a temporary access code
4. the consumer calls the *token endpoint* on the service provider website to exchagne the code for a more permanetn access token.
5. the s.p grants an access token whcich can be used to authenticate subsequent requests to protected resources

### Configurationat
These are the thigns that you need to configure: 
1. The Client ID
2. the Clietn Secret
3. the Redirect URI
4. that Authorization Endpoint
5. the Token endpoint

#### Breakdown:
1. the client secret and id are provided after registering the service provider. 
2. Redirect UIR is something you can specify whe nconfiguring OAUTH authentication on the consumer.
3. This needs to match whatever you specify when craeting the application the service porivder. this can
can be also called "redirect URL" or "Callback URL" or some sort of variation of that. 


## Resources:

- [OAUTH](https://www.jerriepelser.com/blog/authenticate-oauth-aspnet-core-2)