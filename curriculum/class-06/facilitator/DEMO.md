# Demos: Classes and Objects

Note: Demos as they exist in the `/demo` folder are provided in their **completed** state.

This demo feels like a lecture and is a lot of the "Resource" material repeated. It's important to use this sequence to solidify the core OOP concepts in an organized fashion, by building it out during lecture.

## Inheritance

Demo out what inheritance looks like. Good way to do this is to
is to maybe "plan a party". I like opening up a drawing pad and start listing
all the things that a party has. Use these guidelines if you get stuck:

1. What behaviors or properties do all parties have?
1. What different TYPES of parties are there?
1. Are there any similarities between these parties?

Once you have identified a list of the different types of parties, and the
shared list of behaviors, start breaking it up.

1. Create a `Party` class.
1. Add all the shared behaviors to this class
1. Create the types of parties (i.e. `Birthday`, `Graduation`, etc...)
1. Add properties and behaviors that are unique to the specialty parties
1. Make the specialty/unique parties inherit from the Party class.


## Abstraction
This demo will be a quick one...you will be building off of your party demo from inheritance.

1. Take your code base and start identifying if more information is required.
1. you should identify that "Party" requires more information...so make `Party` abstract
1. Determine if the unique parties can be clarified further (i.e. Birthday party - is it for an adult or a child?).
1. Try and identify and implement 2 or 3 abstract classes into your code base. Can you attach labels on which classes
   are abstract versus concrete?
