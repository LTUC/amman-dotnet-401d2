![cf](http://i.imgur.com/7v5ASc8.png) Class 37 : OAUTH 2
=====================================

## Learning Objectives
1. Students will understand the concept and importance behind software design patterns
2. Students will be able to successfully implement and create their own Factory Design pattern

## Lecture Outline
1. The student will be introduced to different design patterns. 
1. The student will be able to successfully implement the Factory Design Pattern

### Design Patterns
- What are design patterns?
	- Who is the Gang of Four?
- Different types of patterns
	- Creational
	- Behavioral
	- Structural

### Factory Design Pattern
	- What is the Factory Design Pattern?
		- Creational pattern that defines an 'interface' to construct an object
		- When using this pattern, you can define certain methods and properties of objects that will be common to all objects created
		- You have to let the factory methods define what specific objects will be instantiated
	- What is the "structure" of a factory design pattern?
		- Product Class
		- Concrete Product
		- Creator Class
		- Concrete Creator

#### Demo 
	- Create a pizza store factory method
	- Structure:
		- Product Class: Pizza
			- Concreate Product: Types of Pizza
		- Creator Class: Pizza Store
			- Concrete Creator: specific Pizza Stores (Domino's, Zeeks, etc...)


# Assignments

## Readings
1. [Enabling Auth](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/)
2. [Authenticate with OAUTH](https://www.jerriepelser.com/blog/authenticate-oauth-aspnet-core-2/)
3. [App Secrets](https://www.red-gate.com/simple-talk/dotnet/asp-net/secrets-asp-net-core-user-secrets/)