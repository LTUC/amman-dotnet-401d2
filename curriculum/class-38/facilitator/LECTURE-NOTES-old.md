# Lecture NOTES: React II

## Mock Interviews

> Gathered 10 CF alum / people in the industry to give each student a one on one interview.  Used the question below.  Got inspiration from link below.

- [Geeks for Geeks Question](https://www.geeksforgeeks.org/add-two-numbers-represented-by-linked-lists/)

```text
Given 3 linked-lists with values of integers, create a function to taverse the list and convert the list to a number, add the 3 lists together and return the total value of all 3 lists.

The lists will be passed as parameters.

ll1: [5]->[9]->[9] = 599
ll2: [2]->[1]->[1] = 211
ll3: [1]->[4]->[1] = 141

Should return 951

```

## How did the react app go on Tuesday

> Review Lab 37 as necessary
[Lab 37 Solution](../../class-37/solution/odometer/)

## Get back into React

> Lets review the lab for today.

- Start in the location class-38/demo
- run npx create=react-app react-snacks

>NOTE: The installation can take 2-3 min depending on the speed of your computer.

- Test proof on concept.
  - cd react-snacks && npm start
- Look at our Nucleus page.
- Open up the code and go to the App.js.

>NOTE: Since our app is going to have some state, we need a way to handle the state.  The suggested way to use state (at least according to the React Documentation) is to use class based compoenets. We can see that in our starter code, the one we get for free, this is a functional componet.  While you can have state in a functional componet, with our time constraints, we will not conver this in detail.  

- Comment out the function App()
- Comment out import logo from ./logo.svg
- Create a class

```javascript
class App extends React.Component {
  
}

// could also add { Componet } to import statment
// Then in class would only need to extend Componet.
```

- We have a App. It is a class based componet.  This will need the ability to render.

- >NOTE: In a functional componet, the function is the render, for class we need to add it in.

- add inside the class

```javascript
render() {
  return (
      <h1>Coming Soon!</h1>
  )
}
```

- Talk about export default App; This is important because it gives other JS files access.

>NOTE: We can see from our webpage that our render is actually working.

- Why did I do this quick coming soon? You know me, I like to see things working along the way. If this did not work, it would mean I have something wired up incorrectly and would need to troupleshoot a little.

- Talk briefly about style and bring in the style from the function we commented out above.

```javascript
render() {
  return (
    <div className="App">
      <h1>Coming Soon!</h1>
    </div>
  )
}
```

>QUESTION: Why did I not use a fragment here?
>ANSWER: Right now I wanted my styling to be applied.  You cannot appy style to a fragment.
>NOTE: Notice that I am still only returning one thing or "container"

- At this point I could probably get rid of the function that came for free but I am going to leave it for the demo so you can see it.
- We have a very simple app right now. We want to add some additional functionality.
- First we need to set some state which I will set in the constructor.

```javascript
// Add this above the render()
constructor(props){
  super(props)
  this.state = {
    snacks : []
  }
}
```

>NOTE: Notice here I used this.state and not this.setstate. This is the only place that you want to directly assign state, here in the constructor.

- I'm going to add in a componet or 2. The first componet is not going to need state. Since we don't need state, we can skip doing a class componet and do a function componet. Lets add a ```Header``` componet.

>NOTE: Add this in after the render() but before the export default.

```javascript
function Header(props){
  // Lets have this render our the first snack in the list
  return <h2>First snack is: props.firstSnack</h2>
  // Note the missing {} in the rendered page
  // return <h2>First snack is: {props.firstSanck}</h2>
}
```

>QUESTION: Now how do we get this to render on our page?
>ANSWER: Add a ```<Header firstSnack='twix>```

- Awesome. I want to add something. Instead of passing in 'twix' I want to a popular snack. Lets first add this to the constructor.

```javascript
//add in after snacks : [] and don't forget the ,
popularSnack : 'Nothing Yet'
```

>QUESTION: How do we update our Render to now display our popular snack?
>ANSWER: We change the ```<Header>``` render from 'twix' to this.state.popularSnacks

- With this change we have something in our code that works, but looks a little off now. We are asking for a first snack, but giving it a popular snack. Variables are now incorrectly named.
- Make changes in code to adjust for popular snack: variable, h2 wording

>NOTE: At this point you could show how to get the snack[0] from the state.

- From our lab we needed a header and we also needed a footer, so lets add that really quick.

```javascript
// Could try and leave {} off props to see if they catch it.
function Footer(props) {
  return <footer><small>{props.footerText}</small></footer>
}

// Add to render
<Footer footerText='This is a Footer'/>
```

- Couple of the easy things knocked out, lets to some of the meat of our or lecture. I want to render a list of snacks on the page. Do we need to maintain any state in our "listing" of snacks? I would say no because we want to maintain state of snacks in the App Class. The componets will be rendering out props, but they do not need state. We can make this another function componet.

```javascript
// Add between Header and Footer
function SnackList(props){
  return <h2>Snack List</h2>
}

// Will not see it rendered until you add to render()
// <main>
// <SnackList />
// </main>
```

- We have our proof that SnackList is working. What's a good thing to put into our snacks?
- How about out "list of snacks"

```javascript
// Add Update in render()
<SnackList snacks={this.state.snacks}>
// Add to the Header Function.  Try just snacks and see if the students see there is nothing in the snacks list. Add the .length to get something in there.
return <h2>{props.snacks.length}</h2>
```

- Now that we have our proof of concept that things are working, lets update it.
- Let's add something to the snack list. The lab calls for a plain old javascript object, we can go ahead and mimic that for you.

- Update the snacks list to:

```javascript
snacks: [
  {
    name: 'twix',
    type: 'candy',
  }
]
```

- Right away we can see that our list length increased by one so something is going good.
- Lets change our length to actually showing our snacks in list forms.
- Update the return on SnackList to:

```javascript
  return (
    <>
      <h2>Snacks</h2>
        <ul>
          <li>???</li>
        </ul>
    </>
  )
```

- How many snacks will he have in our list? We dunno. We need some way to add an individual snack in. Off we go to another function componet.

```javascript
function Snack(props) {
  return <li>I am a snack</li>
}

// Update the SnackList return to <Snack />
```

- Now we need to update our code to adjust for the list of snacks.

>QUESTION: Ideas on how we may do this?

- This goes back to something we covered on tuesday, but it may have been a little more diffucult to wrap your head around. We want to add an expression into our JSX. Now a loop is not an expression (a loop would make perfect sense here). Instead lets dig back into our 301 days and revisit MAP.

>QUESTION: What does MAP do?
>ANSWER: Creates a new list populated with the result of calling a function on every element in the called list.

```javascript
// In the SnacksList return, update to:
{props.snacks.map(snack => <Snack items={snack}>)}
// NOTE: This is returning on object.

// Now we need to update our Snack
<li>I am a snack: {props.items}</li>

// Run this as is and look at the error.
// Objects are not valid as a react child.
// Change it to:
<li>I am a snack: {props.items.name}</li>
```

- That should have worked for a single snack, lets add in an additional snack and see if it works.

```javascript
// Add into the snack list
{
  name: 'snickers',
  type: 'candy'
}
```

>NOTE: While this will work, lets take a look at the dev tools console
> We see this Each child in a list should have a unique "key"

- Lets fix this. We can add into the area where we iterate over the list

```javascript
// If this was a datanase the key would be something unique like the ID.
// Lets add an id into our objects and use this convention.
{props.snacks.map(snack => <Snack items={snack} {key=snack.id} />)}
```

- Once we add that we see our console issue is now gone.

>NOTE: Press the I believe button that this helps React be more efficient.

- We have this thing that puts some stuff on a page for us.  How do we populate the list, but I don't think hard-coding is the right thing to do.  Thoughts?
- To start lets get an idea of what this may look like.

```javascript
// add this in the SnackList return()

<button>Create a New Snack</button>
// We will probably want to add so sort of form here.
```

- There is an additional layer here.  How communicate out that a snack has been created?
- We need to create something that the parent will need to know about, but we will not be calling the parent directly. We are going to pass in a function with props.
- Remove the button

```javascript
// In the App render() update the following in <main>
<SnackList snacks={this.state.snacks} onSnackCreate={() => alert('works')} />
// When we do this, this is now an attribute that we have access to through props.

// in the SnackList return under the </ul>
{props.onSnackCreate()}
// Lets get a proof of life
```

- That is cool.  We see it is working.  Let's do something with a form now.
- replace the ```{props.onSnackCreate()}``` with a form
- for now lets call is ```<snackForm />```
- It does not exist yet.

>NOTE: While this may seem like another function, it is not going to be because of how forms operate in react. This is a react 'weirdness' thing. There are a lot of 3rd party solutions that handle the 'weirdness' of forms. If you want, take a look and see what you come up with. We are going to need a class componet.

```javascript
class SnackForm extends React.Component {
  constructor(props) {
    super(props)
    this.state = {
      name : '',
      snackType: '',
    }
  }
}
```

>NOTE: We see the errir.  instance.render is not a function.
>QUESTION: Any thoughts on why we got this error?
>ANSWER: Every class or function needs a render.

- Lets add the render()

```javascript
// Add the redner method after the constructor.

render() {
  return <h2>this</h2>
}

// that fixes the error.  Lets change this to a form
render() {
  return(
  <form>
    <label>
      Name:
      <input type="text" value={this.state.name} />
    </label>
  </form>
  )
}
```

- Let me try and update the form.  I'm typing. Nothing is updating in the form. Why?
- The value of the form is tied to the state.
- This brings up an issue because we need to figure how to handle changes to the state.
- If I want the form to render what I am typing, I need to have the ability to chage the value.

```javascript
// Add an onChange
<input type="text" value={this.state.name} onChange={this.handleChange}/>
// We dont have a handleChange method, so we need to make one. Add above the render

handleChange(event){
  let newName = event.target.value;
  this.setState({
    name: newName
  })
}
```

- As soon as I tried to type in there I get this error.  Cannot read property 'setState'
- This is a Javascript thing, not a React thing. The contextual this in the handle.change is referring to the wrong this.  We have to add this "jenky" line of code to fix this.

```javascript
  constructor(props) {
    super(props)
    this.state = {
      name: '',
      snackType: '',
    }
    this.handleChange = this.handleChange.bind(this); // <----Add This here
  }
```

- Now that we can type, now we need a way to add the data.

```javascript
<form onSubmit={this.handleSubmit}>
</form>

// This function dosn't exist yet so lets make it.

handleSubmit(event) {
  event.preventDefault()
  this.props.onSnackCreate(this.state)
}

// Now back in the onSnackCreate change from alert Works to:
<SnackList snacks={this.state.snacks} onSnackCreate={(snack) => alert(snack.name)} />
```

- We did it again.  The event clobers the contextual 'this' and gets reassigned to the dom element that created the event.

```javascript
  constructor(props) {
    super(props)
    this.state = {
      name: '',
      snackType: '',
    }
    this.handleChange = this.handleChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this); // <----Add This here
  }
```

- Still getting an error.  Need to update ```<SnackFrom>```

```javascript
<SnackForm onSnackCreate={props.onSnackCreate} />
```

- We should see our item being alterted.
- We are at a point where we are able to handle the snack name. There would be some next steps with this.  Add in a type, update the id.  We also need to find a way to add the new snack into the list.
