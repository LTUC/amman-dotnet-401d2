
# Peer Review
Peer reviews are done at the end of each week
1. Pick two user stories that you did not implement into the project, but your partner did. 
	- These user stories must be C# specific and relate to one of the main lectures we had in class. 
	- For example, you are **NOT** allowed to review a user story of a front end task. Instead choose something major from that sprint that we learned about specifically in class. 
2. Look at how your partner implemented that feature.
3. Provide the following:
	- What you liked about the implementation
	- What you didn't like? 
	- How would you have done it differently? Suggestions for refactoring/optimizations
	- Something that you learned

**NOTE:** These peer reviews are worth 50 points total (25pts for each) and are in place to prepare you with the standard of what peer reviews are like in the industry. Your review should be thorough and thought out. You are not allowed to just "agree" with the way your partner implemented it.  Always explain why or why not. 

The following is a Bad example of a peer review:
1. What you liked about the implementation
	- `I like everything about the implementation. It looked good.`
2. What you didn't like
	- `There is nothing that i didn't like. It all looked good.` 
3. How would you have done it differently?
	- `The way they did it is the exact way i would have done it.`
4. Suggestions for refactoring/optimizations
	- `No. it looks good.`
5. Something that you learned]
	- `I learned how to implement {INSERT FEATURE HERE}. It looks pretty straightforward.` 

You will receive a zero for the peer review quality above, or for anything within the same response.


The following is a `Good` example of a peer review

- What you liked about the implementation
	- ` I really liked the way Molly implemented the claims capturing of the registration process. She did it exactly where 		instructed in the Register action and is using the correct syntax. Looking at her code in the AccountController, she is 		instantiating a new list of claims. From there, she is creating a claim for the user's first and last name, birthday, and 		email. I really like how she was able to convert the Birthday to a saveable date into the database. Date Times are always 		tricky, but she did a great job at making sure it was easy to extract. After she created all the claims, Molly leveraged the 		_usermanager to add the individual claims to the user. As we learned in class, we don't have to actually "save" the user 		manager because it is done for us already inside the method call.`
- What you didn't like
	- `Overall, she had a great implementation. Unfortunately she didn't comment her code, and she left "zombie" code in where she 		was trying out different techniques. I also probably would have captured more claims because i'm sure more is or will be 		required for later on in the project.`
- How would you have done it differently? How would you refactor/optimize?
	- ` In regards to doing it differently,	I may have created an external method from the registration process to divide out the 		responsibilities a bit better. The current registration method is doing too much, and it needs to be cleaned up and not be so 		heavy. The external method would have lived in the same controller, and had ClaimType, and value. I could have had this whole 		method's responsibility to create and add claims to the user manager. `
- Something that you learned
	- `I learned how to create a claim and add it onto the user manager. It's interesting because the code shows that the claims 		are only being created and added if usermanager is able to successfully create a new user. I did not realize how important the 		if(result.Succeeded) code is. I also learned that when adding claims to a user, it can be done in bulk with a list, or it can 		be done individually.`
