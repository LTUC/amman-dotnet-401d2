# Lecture NOTES: React I

## Whiteboarding

 > We are getting really close to students whiteboard interview.  Is a good time to have a student whiteboard in front of everyone.  Use the codefellows generator.
 [Random Question Generator](https://codefellows.github.io/dsa-practice/)

## Do a review of ES6

> Most of these changes you have already seen in your transition from 201 to 301.

Things to point out as a refresher today:
> Can use the site from reading [ES6 Updates](https://www.taniarascia.com/es6-syntax-and-feature-overview/)

- User variables 'let' and 'const' and not 'var'
  
  ```javascript
  var varVariable = 123;
  let letVariable = 123;
  const constArray = [];
  ```

  - Almost no reason to 'var'
- Introduction of arrow functions  
  
  ```javascript
  let randomFunction = (parm1, parm2, parm3)=> {parm1 + parm2 + parm3} ; // () optional with 1 parm

  randomFunction(1, 2, 3);  // This returns nothing
  ```

  - return is implied with the {} is not included

  ```javascript
  let randomFunction = (parm1, parm2, parm3)=> parm1 + parm2 + parm3;  // () optional with 1 parm

  randomFunction(1, 2, 3);  // This returns 6
  ```  
  
- Template Literals (Similar layout to python)
  
  ```javascript
  let userName = prompt('Please enter your name');
  let message = `Hello there ${userName}`;
  ```

- Multi-line strings

  ```javascript
  let message = `Here is some text
  here is more
  and some more`;
  ```

- Array iteration is more similar to python

    ```javascript
    const months = ['Jan', 'Feb', 'Mar', 'Apr'];

    for (let i in months){
        console.log(i);
    }
    ```

- These are just some of the key differences.  Because we are getting back into JS, it is a good time to review this and get a little practice back in using javascript.  Lets open up an online editor.  Codepen, codesandbox, jsfiddle, repl.it, whatever it is you want to use.  

> Do a general fizzbuzz app in JS. Have them console.log in the function. Do this as a class. Once that is done, do q quick breakout room and have the them change so the function returns an array of the result, then outside the function loop through the array and console.log the results.  If time allows have then refactor again to list how many times each occurs.

```jacascript
fizz: 4
buzz: 2
fizzbuzz: 4
none: 3
```

## Time for some react

Walk over to the docs and skim the tutorial. Explain the site has a step by step guide to starting.

### What is react

- > React is a JS library for building user interfaces. It runs on the browser so your HTML page will respond very fast.  It uses jsx under the hood. It can be used as a single page application or as a multiple page application.
- > What is react not? Facebook created react and very specifically states it is not a framework but a library.

### React Demo in codesandbox

- Go to [CodeSandbox](codesandbox.io).  Start a Straight react app. Create a new react app.
- What do we get with our react
  - You can see we get some files and folders pre-built for us.  Very remicent of Django
  - We see a public folder, source folder, App.js, index.js, a package.json with our dependencies there.
  - All of these things use to have to be done by hand.  Thankfully this is no longer the case. We now have a tool called create-react-app (very similar to django-admin startproject)
  - There are somethings that are similar to Django. There were a couple of files that Django created for us that we did not mess with. React is going to be similar. There will be files that we are not going to mess with all to often. Index.js is going to be one of those files. This is the front door to your app. This will get set and you will do your work elsewhere.
  - Inside of index.js you will see thie ```<App />``` This is a react componet.
  - When you see the start editing, this is why we are going to start our editing in the App.js file
    - > NOTE:  While this looks like html "stuff", see that we are in a JS file, not an html file.
  - So this looks like html, but it is not.  QUESTION: What is it?  ANSWER: JSX
  - JSX = JavaScript Extenxtion, allows us to write javascrt that looks like markup
  - Show this is not markup bu changing className to class. Codesandbox will still render the last good page, but note the console-error.
  - Becase we are in JS, we have the ability to inject JS expressions directly into our markup.
  - add in an expression in the app.js.  
  
  ```javascript
  userName = 'Roger'
  return(
    <h1>Hello CodeSandbox from {userName}</h1>
  )
  // Could also do this
  function getSomewhere(){return 'Somewhere over the rainbow!'}

  return(
    <h1>Hello CodeSandbox from {userName} in {getSomewhere()}</h1>
  )
  ```

  - Lets try and add another div to return here. ```<div><h2>Hola</h2></div>```
  - See the error code. What this is saying is that you can only return 1 thing. You have have multiple things inside the "thing" but only one thing. To fix this we could just wrap a single div around the whole thing.
- The problem with this is we want to make sure things are scemantic, and a bunch of divs is not helping.
- To get around this JSX came up with a fragment. You use do have to do thing like import the fragment and give it names.  Now you can just use an empty tag, and React knows this is a fragment and it meets the requirements of what it needs. This is much more freindly to screen readers and visual / hearing impared users of your website.

- Lets add a functional based componet.

```javascript
// Add this is below getSomewhere()
function Footer(props) {
  return (
    <footer>
      <p>Hi in the footer</p>
    </footer>
  )
}
```

- Then we add ```<Footer />``` in the return. Because of the capitalization, it knows it is a componet and renders it as such. Notice this props that I passed into the function.
- Show that props is not being used right now by adding to the footer ```<p>Props says ... {props.message}</p>```
- See the rendered page, where Props says ... and nothing after that. Even though it is undefined, it is somewhat correcting.
- We can fix this by adding in ```<Footer message="Hello there General Kenobi" />``` The message.
- In fact I can call ```<Footer message>``` again if I want
- I can add another componet if I want.  Add a header componet.

## Time to head back to the computer

- cd into class37.  mkdir demo.
- run ```npx create-react-app cra``` cra = create react app
- All sorts of things installing and running. Depending on the speed of your internet connection and the power of your computer, this could take a few min.

> NOTE: If you notice I did not create a poetry project for this. Why?

- Expand your terminal to look at the commands that are there. Notice that this does run a git init.  You will need to be careful if you add this inside somewhere that is already being tracked.  In fact just like I have here in class repo. How do we fix this? rm-rf .git

- Lets take some time to look over the lab for today.
- Now we run npm start.  Looks, something like the Django Rocket.
- As we look at the code layout, we have some things that were similar to what we had in codesandbox, but it looks like we have a few more things.
- For today go ahead and leave the extra things there. I want to just focus on getting into the app.js
- Lets take a look at our App.js. I want this to use what we did in code sandbox. I wonder if I can copy and paste the information over from codesanxbox.  This is a good time to put the 2 pieces of code next to eachother and point out the css file.

### Time to convert a functional componet to a class componet

- Lets add another functional componet.

```javascript
function SectionOne(props) {
  return <h3>Today is a Happy Day</h3>
}
```

- We know from the codesandbox example we can adjust the mood in section one to be dynamic. Add in a let mood = 'Happy' and add {mood} to the h3 return where Happy is now.  But what if we wanted this to be really dynamic. This is not a whole lot different than hard coding the mood. We could update {mood} to be {props.mood} and then pass in mood when we render.
- In many cases this may be the right answer, if it were someone elses responsibility to change mood. but what if it was the componets? How do we work with this?
- Make the function look like ```class SectionOne extends React.Component {```

- One thing that is different, in the function, it is the render, in a class you have to create the render. We do with by adding:

```javascript
render() {
  return (
    <h3>....
  )
}
```

- Notice the page render.  Failed to compile, missing return.  Lets move our h3 inside. This gets our page rendering again but notice Today is a ... Day is not showing up.

- What we want now is to have the componet responsible for the state change. Instead of using props we are going to use something called stats. I'm going to start adding in the code. We have not defined state so this is going to break.

- Lets create state now. This is going to be similar to our __init__ but it will be in JS style. We will add:

```javascript
constructor(){
  super(); // This runs the superclass constructor first.
  this.state = {
    mood : 'sad',
  }
}
```

- If somewhere along the lines we change this.state.mood, react will be able to 'react' and adjust the state of mood.
- Right now this is hard coded but we want the user to change the mood. Lets add a button
make the render:

```javascript
  render() {
    return (
      <> // JSX Fragment HERE
        <button>Improve</button>
        <button>Reduce</button>
        <h3>Today is a {this.state.mood} Day</h3>
      </>
    )
  }
}
```

- My thought here is that I will imporove my mood or reduce my mood. How can we do that?
- Buttons are clickible but not wired up.
- In Vanilla JS how would we handle this?  QUESTION:  ANSWER: Eventhandler.  Lets do that.
- Add in a onClick and lets add a function called change mood.

```javascript
<button onClick={this.changeMood('imporove')}>Improve</button>
<button onClick={this.changeMood('reduce')}>Reduce</button>
```

- Look at the dev tools and see if this is doing what we want.  We see it is rendering this out 2 times(this is because we are running in debug) but would normally render one time.  We fis this by doing this:

- Lets now create the function that will change our mood but this is going to look a little weird at first.

```javascript
<button onClick={() => this.changeMood('imporove')}>Improve</button>
<button onClick={() => this.changeMood('reduce')}>Reduce</button>
```

Lets make a change to the mood state. Here is the wrong way.
```this.state.mood = 'Happy'```
Look at the error in the dev tools. Do not mutate state directly.
it should be done like this

```  changeMood(change) {
    console.log("change", change);
    // DO NOT DO THIS
    // this.state.mood = 'Happy'
    this.setState({
        mood: 'Happy',
      }
    )
  }
```

import React from "react";
import "./App.css";

function getSomewhere() {
  return "Texas";
}

function Header(props) {
  return (
    <header>
      <p>Hi in the header</p>
      <p>Props says ... {props.message2}</p>
    </header>
  );
}

function Footer(props) {
  return (
    <footer>
      <p>Hi in the footer</p>
      <p>Props says ... {props.message}</p>
    </footer>
  );
}


export default function App() {
  let userName = "Roger";
  return (
    <>
      <Header message2="I'm in the header" />
      <div className="App">
        <h1>
          Hello CodeSandbox from {userName} in {getSomewhere()}
        </h1>
        <h2>Start editing to see some magic happen!</h2>
      </div>
      <div>
        <h2>hola</h2>
      </div>
      <SectionOne mood={'Happy'}/>
      <Footer message="Hello there General Kenobi" />
      <Footer message="General Kenobi, you scum..." />
    </>
  );
}

class SectionOne extends React.Component {

  constructor() {
    super();
    this.state = {
      mood: 'sad',
    }
  }

  changeMood(change) {
    console.log("change", change);
    // DO NOT DO THIS
    // this.state.mood = 'Happy'
    this.setState({
        mood: 'Happy',
      }
    )
  }


  render() {
    return (
      <>
        <button onClick={() => this.changeMood('imporove')}>Improve</button>
        <button onClick={() => this.changeMood('reduce')}>Reduce</button>
        <h3>Today is a {this.state.mood} Day</h3>
      </>
    )
  }
  // let mood = 'Happy'
  //
}
[]()