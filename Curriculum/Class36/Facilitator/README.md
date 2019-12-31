# Class 36 : 3rd Party Technical Documentation

## How do I prep for today?
Today is all about reading and utilizing technical documentation
from a 3rd party. 

We will be using Authorize.NET as a 3rd party service. The point
of today is to practice reading and utilizing 3rd party docs
and directly reading them into your code. 

This is a great practice to get curious and add some functionality 
to their existing ecommerce site.

## Lecture Outline

### Technical Documentation

- Why
  - Technical documentation is everywhere, it's how and where we learn more about a specific technical concept or product. Sometimes, reading the documentation can be time consuming, or even hard to follow. It's important that we are able to read all different types of technical documentation  in the most efficient way possible! To learn more about this technique, refer to this article: [How to read technical documentation](https://www.linkedin.com/pulse/20140730081025-316694350-how-to-read-technical-docs-in-the-minimum-time-possible/)
- What
  - There is a technique that we can apply to reading documentation. It simplifies down to learning what to look for when reviewing documentation and how to extract what we need quickly. Refer to the 
- How
  - Refer to the article from above for how to apply this technique.

### Authorize.NET

- Why
  - It is very likely that a web based application may utilize third party software to solve some sort of problem or need that they have. For an e-commerce store, this could be something as important as a payment gateway. It is really important within payment gateways we ensure secure and quick processing. Instead of custom creating a payment processor, sometimes it is much easier to find the existing product and integrate it into our already existing site. Take a look at the developer docs and see if you can figure out together where to start on implementation into your web app. 
- What
  - Auth.NET is a payment gateway that can be used by merchants to accept forms of payment. Auth.NET has a "sandbox" account, which is what you will be using for your application. This is a free version of the product that allows you to use the features without creating a merchant account.
- How
  - Refer to the demo code and documentation on how to setup Auth.NET
  
## Lab Notes

Within the lab, the students will be implementing the Auth.NET code into their e-commerce projects. They will need to modify the current checkout process and add in the ability to process orders. This may be a bit tricky for some students if they are unsure of the architecture of their app. 

## What might students struggle with today?  
Reading documentation is not easy. Students get overwhelmed 
and flustered with the amount of content. We have to teach them
how to take it bit by bit and help guide them how to pull from 
the documentation what is useful and what is needed. 

## What bugs, issues, or surprises have come up in the past for this class?

Because .NET Core is always receiving updates, you can potentially expect there to be a documentation gap between what is required for implementation and what is written out. This is a great way to show students how to problem solve from what they know, and how to use their resources (such as github repos, code samples, trial/error, etc...). 

The demo code provided should show a functional version Auth.NET. In the event that the newest version does not work with Auth.NET, we will consider a new provider. 