# ![cf](http://i.imgur.com/7v5ASc8.png) Lab 16 : Web APIs Pt. 1

## Introduction to Web APIs

## What is a WEB API

## API
What does API mean? - Application Program Interface

#### HTTP Verbs
1. GET - Get a resource, should be repeatable w/o side effects
2. POST - "Do Some action" / create new resource/ super flexible
3. PUT - "Take a resource and put it somewhere" // If it doesn't exist, create it, if it does update it, should be repeatable w/o side effects 
4. DELETE - Remove a resource

Stateless Request/reply protocol

What is an API?
1. An HTTP Service
2. APIs allow any platform to conuse (anything that speaks http)
3. Accessible across the internet. 

## REST

REST == Reprsentational State Transfer <br />

How is data represented:
	- JSON
	- XML

What makes up an HTTP request?
	1. Headers
	2. Body - Can be any format (Json, XML, IMG, etc...)
	3. Status Codes

Rules of HTTP are important and we can take advantage of everything else that the web contains within HTTP

1. Status Codes 
	- 200 - Ok
	- 400 - Bad Request (Client Issue/Blame the client)
	- 500 - Internal Server Error (Server Issue/ Blame the Server)


## Handling HTTP Requests in .NET Core
1. The server (Kestral) listens for the request
2. Middleware pipeline is invoked for each request
3. Use MVC to route requests to controller & Action
4. Responses flow backdown the middleware pipeline. 

## Key Terms
- Attribute Routing
- Route Templates
- Route Tokens
- Model Binding
- Model State
- Content Negotiations


## Get/POST

### Demo
- Create a new empty project. 
- Add MVC Services in Startup
- Create GET Action
- Talk about attribute routing
- model Binding
- Route constraints
- Create POST action
- Set up a database and DBContext to store data from API

# Assignments

## Readings
- [Web APIs](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api)
- 

## Coding Challenge


-Using your "data-structures" repository
  - add a folder and label it `Linked Lists`
  - add the code on a branch from this challenge into this repo
  - Describe your approach in the strings folder readme document
  - Spend no more than 90 minutes on this challenge
  - Submit a link to your repo PR in canvas