# Facilitators Guide: Payment Processing

## Overview

Processing credit cards using Authorize.net ... in this class we explore the concepts of online payment processing while at the same time challenging the students to do a complicated integration of a 3rd party system using the Repository pattern

### How does this topic fit?

**Where we've been**:
In the previous class students completed the wiring of the shopping cart, including the "Receipt" page that would show after an order has been processed (but we've not yet processed an order)

**What are we focusing on today**:
Today, we'll be injecting payment processing ahead of the final processing of an order, ensuring that we don't change inventory or send off emails until the payment for the order has been processed successfully

**Where we're headed**:
This concludes the development portion of the E-Commerce project. Students will be turning their attention towards Styling and UX of both the CMS and the consumer sites.

## Learning Objectives

Review the detailed objectives in today's [student-facing readme](../README.md).

> Our primary outcomes and goals for the day are to gain an understanding of payment gateways as well as to reinforce the repository pattern by creating the Authorize.net facade on their own.

## Preparation

- Practice the demo
- Create an account at Authorize.net

## Lecture Outline

Below is the expected lecture outline and flow. One possible way to present this material is documented in the [example lecture](../LECTURE-NOTES.md) notes.

### Code Review

### TOPIC 1: Payment Gateways

Technical documentation is everywhere, it's how and where we learn more about a specific technical concept or product. Sometimes, reading the documentation can be time consuming, or even hard to follow. It's important that we are able to read all different types of technical documentation  in the most efficient way possible! To learn more about this technique, refer to this article: [How to read technical documentation](https://www.linkedin.com/pulse/20140730081025-316694350-how-to-read-technical-docs-in-the-minimum-time-possible/)

- **Why** (5 min)
  - It is very likely that a web based application may utilize third party software to solve some sort of problem or need that they have.
  - For an e-commerce store, this could be something as important as a payment gateway.
  - It is really important within payment gateways we ensure secure and quick processing.
    - Instead of custom creating a payment processor, sometimes it is much easier to find the existing product and integrate it into our already existing site.
- **What** (10 min)
  - Authorize.NET is a payment gateway that can be used by merchants to:
    - Pre-Authorize Cards
    - Complete Transactions
    - Generate Invoices
    - Manage Subscriptions and Recurring Billing
    - Sell products securely
  - Authorize.NET has a "sandbox" account, which is what you will be using for your application.
    This is a free version of the product that allows you to use the features without creating a merchant account.
- **How** (30 min)
  - As with Emailing, Identity, and other services, we will integrate Authorize.net as a Service, suitable for DI, using the repository pattern.
  - Lead the students through a whiteboard session where they will diagram out the architecture for this, as well as the steps they'll need to follow
    - Their lab will be to implement this feature using only UML and the Authorize.net documentation
- **Experimentation**
  - Small Group Exercise: Take a look at the authorize.net developer docs and see if you can figure out together where to start on implementation into your web app.
- **DEMO**
  - As noted in the demo documentation, you will not be coding an implementation.
  - Rather, lead the students through a UML and architecture discussion and leave the actual coding implementation to them.

## Lab Notes

This will be the students' first time attempting to create a new facade within the repository pattern completely on their own.

## What might students struggle with today?

We will not be providing them demo code for this lecture. Rather, guidance and pathways on implementation and some guidance in lab.

## Past bugs, issues or surprises...

## General Comments and Notes
