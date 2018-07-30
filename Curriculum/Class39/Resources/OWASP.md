# OWASP

OWASP stands for Open Web Application Security Project. 
Non-profit org whoe purpose is to promote secure web app developement and esign. 

The OWASP top Ten project is updated every few ysers and 
they publis hteh top 10 list of most critical web security risks. 


### 1. SQL Injection
SQL injection is the use of 
modifying an input parameter that can force a slq statemetn
to execute in a different way than intended. 

Code Example: [HERE](https://dotnetcoretutorials.com/2017/10/11/owasp-top-10-asp-net-core-sql-injection/)

Solution: Sanitize your inputs:

1. Casting to a non strng type
   - Maek sure that you are only accepting ints when you require ints. 

.NET Core:
This can be fixed through [Route] tags. 
This will only work for ints and columns. 

2. Whitelist/Blacklsit/Character Replacement

You can run your string text against a whitelist/blacklist that repalces
specific charactes before running thesql query.

3. Parameterized Queries
   - This is the best approach to SQL injection. 
   - Parameterized queires allow us to make sure that each paramter we are using within our
  sql query is the exact data type we are expecting. 

Here is an example:

```
exec sp_executesql N'SELECT * FROM NonSensitiveDataTable WHERE Name = @name'
,N'@name nvarchar(12)'
,@name=N'Bart Simpson'
```

4. Stored Procedures
    - Store procedures allow you to force queries to be run on the database side. 
    - You send it the name of the parameters similar to Paramterized queries.
5. Use of an ORM
   - ORMS like Entity Framework help protect against sql injection
   - Withi LINQ query, any "Where" statement gets packagesd as a paramaterized query. 
   - It is not impossible to not have sql injection, but out of the norm
   - [RAW sql using Core](https://docs.microsoft.com/en-us/ef/core/querying/raw-sql) 




### 2. Broken Authentication and Session Management

1. Password Hashing
   - Under no circumstances should passwords be stored as plain text. 
   - User ASP.NET Core Identity
     - you are going to have secure password hashing right out of the box. it suses PBKDF2 hasing function for passwords
     - Identity also generates random slat per user. 
     - Never ever invent a hashing algorithm to store your passwords
2. Salting
    - Salint is the act of addign a random string to your text of your password before hashing it.
    - Two of te exaclty same passwords can be hashed differently becaes of the salt.
    - [PKFD2 Calculator](https://asecuritysite.com/encryption/PBKDF2z)
    - Best practice to salt unique per user. 
    - In .NET Core, the salt is stored with the password in teh same column. it is 
    ok to not have them separate since each salt is unique. 
3. Session Identifiers
   - Cookieless sessions are not implemented so you wont see urls with session data.
   - You should never send off a url that could potentially impersonate a user.  
4. Sending Data over unencrypted connections
   - Make sure you are on an HTTPS connection using SSL/TLS
5. Lockouts, timeouts, and more
   - Make sure you use HTTP only cookies so they are not accessible by Javascript
   - make sure your cookie have expirations
   - 
### 3. Cross-Site Scripting (XSS)
XSS is the ability to write whateber they want (scripts included) into the page and have it execute. 

Javascript is the most common injection. 

Use to steal private data. 

2 differetn types of XSS:
1. Reflected XSS
   - cross site scripting occurs immediatly as aresult of the input from a user.
2. Stored XSS
    - is when you are able   something to a database or backend store. You could
    - potentailiy save a XSS in a blog comment...everyone who views the commetn is affected. 

Potential with XSS:
1. Javascript
   - inject script tags on a webpage. You can
     - redirect a user to a different page. 
     - build a fake login page
     - steal a user's login cookie
   - deterrint is to not allow the word "script" to be subbiteed on yoeur site. 
2. CSS
   - inject styles into a page. 
   - change the entire layout of ap ge to trick the user into doing something. 
3. IFRAMES
   - thsi can go undetected for some time becaues it is invisible to end users. 
   - inject pay per view addsto get more moneuy
   - iframine a fake login page form into a page
4. HTML encoding user outut
   - Framework protects us from this attack. 
   - .NEt core always encodes output from users, so you cannot put script tags into user input fields. 
   - Every Javascript (even Jquery) wil lencode data for you. you will have to check if it is manual or automatic process. check.
   
5. URL Encoding USer Input
   - URLS do not encode wth the same charactes as HTML. Do not try to override everything with 
   the raw taghelpers. 
   - .NET Core offers the ability to encode user inptu for URLS. 
6. Browser PRotection
   - Chrome actually doesn't allow XSS. More browsers are moving away from allowing this and adding XSS filters. 
 
Overall, XSS is not going anywhere anytime soon. 
It is still around becaues developers not doing the basics correctly. 

.NET core our razor tag helprs are a great out of the box solution for issues like this. 
HTML encoding will solve most of our problesm, but not all frameworks support this yet. 

### 4. Broken Access Control
The ability for end users, whether through tampering of a URL, cookie, token, or contents of ap ge
to essentailly access data that they shouldn't have access to. 

THis may mean that a user can access someone else's data or 
elevate their personal permissiosn within the site. 

This really boils down to situations like this:
1. Misconfgured or too borad CORS configurations
2. WEb servier directly/browsing
3. Backps/source control files present in web roots
4. rate limiting of APIs
5. JWT Tokens not being invalidated on logout. 

Essnetially, if the question is "shoudl a web user be able to access this data this way..." adn the 
answer is no, then this is the category for OWASP.

1. Insecure Direct Object References
   - Direct Object references are ids or reference variables that are able to be changed by an end user or see data
   they are not allowed to see.
   - With the [Authorize] tag in .NET Core, this keeps out anonymous users, but not logged in users to specfic pages
   - You should be abel to check and validate that a user is the correctly logged in user, either through a claim, and through the 
   current contextual logged in user. Compare these two values together to make sure the right person is seeing hte resource. if they do't match...kick them out!
   - Essentially, anthing that lives in the browser(Javascript, hiddne fields, cookies) can be modified. Server side validation is the best option. 

2. CORS misconfigurations
   - CORS stands for Cross-Origin Resource Sharing
   - The issue is that its too easy to open up your website to all requests, 
   - Generally, never jsut allow origins unless your api is exposed to the complete public.
   - Within .NET COre you have to specify with the `USeCors()` configuraiton. 
   - this will alow you to control who can make AJAX requests
3. Directory Traversal or Dangerous Files
   - Dont' allow users to do directoyr traversal in your web applicaiton. 
   - Don't let a user got to "mysite.com/images" and view a directory of imaeges. 
   - Dont allow users to have access to sensitve files such as backups. 
  
### 5. Cross Site Request Forgery
Cross site request forgery (XSRF or CSRF) is an attack against a web hosted app where
a malicious web app can influence the interaction between the client and the web app that trusts the browser. 



