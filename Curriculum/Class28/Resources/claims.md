# Claims


## Claims-based Authentication

claims are a statement or property about a particular identity. Examples include

1. FirstName
1. LastName
1. DateOfBirth
1. EmailAddress
1. IsVIP

These are all statements are about who the identity *IS* not what they can *DO*


#### Identity

An identity contains many claims. Let's take a driver's license as an example. It contains
1. First Name
1. Last Name
1. Height
1. Weight
1. Address

Your passport will contain different claims than a drivers license. Both passport and Driver's license are forms of 
identity. 

Identities in .NET core are a form of a `ClaimsIdentity`. 

Other components of a ClaimsIdentity may be the Authentication Type, 
which could extend to `Cookies` `Bearer`, `Google` etc...


If you create a `ClaimsIdentity` and provide an `AuthenticationType` in the constructor, `IsAuthenticated` will always be true.

You cannot have an unauthenticated user with an `AuthenticaitonType`


### Multiple Identities

`User` property on `HttpContext` is a `ClaimsPrinciple` not a `Claimsidentity`.

A single `ClaimsPrinciple` can consist of multiple `Identities`. 
Within `ClaimsPrinciple` , implements the `IPrinciple`, which essentailly grabs the 
first identity listed in `Identities`

The following are true:
1. A principle can have multiple identites.
1. These identties can have multiple claims
1. `ClaimsPrinicpal` inherits all the claims of it's identities. 


### Sources:
1. [Claims](https://docs.microsoft.com/en-us/aspnet/core/security/authorization/claims?view=aspnetcore-2.2)