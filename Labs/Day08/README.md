![cf](http://i.imgur.com/7v5ASc8.png) Lab 8 : LINQ in Manhatten
=====================================

## To Submit this Assignment
- fork this repository
- write all of your code in a directory named `lab-#`; + `<your name>` **e.g.** `lab08-amanda`
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas


## Directions
Provided is a JSON file that contains a data set of location information for properties in Manhatten.
- Read in the file and answer the questions below
- Use LINQ queries and Lambda statements (when appropriate) to find the answers. 

## Setup
- Add the data.json file to your solution root folder
- Explore the NuGet packages and install NewtonSoftJson
- Do some self research and find out how to read in JSON file (hint: JsonConvert.DeserializedOject is *part* of it)
- You will need to break up each section of the JSON file up into different classes, use your resources - ask the TA's if your stuck. (Maybe find a converter of some sort??)
- 
#### Questions
Each query builds off of the next. 
1. Output all of the neighborhoods in this data list
2. Filter out all the neighborhoods that do not have any names
3. Remove the Duplicates
4. Rewrite the queries from above, and consolidate all into one single query.
5. Rewrite at least one of these questions only using a LINQ query (without lambda statement)

## ReadMe
A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context)
2. show them what it looks like in action
3. show them how they use it
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> <br /> Refer to the sample-README in the class repo for an example. 
- [Reference](https://github.com/noffle/art-of-readme)

## Rubric
- 7pts: Program meets all requirements described in Lab directions
- 3pts: Code meets industry standards

- **Readme.md required for submission. Missing readme document and tests will result in a best score of 2/10**

