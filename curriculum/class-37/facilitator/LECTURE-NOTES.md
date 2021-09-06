# Class 37 React - NextJS - Tailwind

## Library Presentation (2) Students
 - User Random name generator in Roger-Guide Folder

 ### React Demonstration
- Go to CodeSandbox. Start a react app.
- What do we get with our react
- You can see we get some files and folders pre-built for us. Very remicent of Django
- We see a public folder, source folder, App.js, index.js, a package.json with our dependencies there.
- All of these things use to have to be done by hand. Thankfully this is no longer the case. We now have a tool called create-react-app (very similar to django-admin startproject)
- There are somethings that are similar to Django. There were a couple of files that Django created for us that we did not mess with. React is going to be similar. There will be files that we are not going to mess with all to often. Index.js is going to be one of those files. This is the front door to your app. This will get set and you will do your work elsewhere.
- Inside of index.js you will see thie <App /> This is a react componet.
- When you see the start editing, this is why we are going to start our editing in the App.js file
- > NOTE: While this looks like html "stuff", see that we are in a JS file, not an html file.
- So this looks like html, but it is not. QUESTION: What is it? ANSWER: JSX
- JSX = JavaScript Extenxtion, allows us to write javascrt that looks like markup
- Show this is not markup bu changing className to class. Codesandbox will still render the last good page, but note the console-error.
- Becase we are in JS, we have the ability to inject JS expressions directly into our markup.
- Add in an expression in the app.js.

```js
import "./styles.css";

export default function App() {
  let userName = 'Roger' // Add This
  return (
    <div className="App">
      <h1>Hello CodeSandbox from {userName}</h1> // Update This
      <h2>Start editing to see some magic happen!</h2>
    </div>
  );
}
```

- Then add this:

```js
function getSomewhere(){return 'Somewhere over the rainbow!'}

return(
  <h1>Hello CodeSandbox from {userName} in {getSomewhere()}</h1>
)
```

- Lets try and add another div to return here. <div><h2>Hola</h2></div>
- See the error code. What this is saying is that you can only return 1 thing. You have have multiple things inside the "thing" but only one thing. To fix this we could just wrap a single div around the whole thing.
- The problem with this is we want to make sure things are scemantic, and a bunch of divs is not helping.
- To get around this JSX came up with a fragment. You use do have to do thing like import the fragment and give it names. Now you can just use an empty tag, and React knows this is a fragment and it meets the requirements of what it needs. This is much more freindly to screen readers and visual / hearing impared users of your website.
> Add a fragment <> </>


### Next JS and Tailwind
```js
npx create-next-app --example with-tailwindcss magic-eight-ball
// npm run dev to start.  Run code . first.
```

- Show them [Nextjs.Org](https://nextjs.org/docs/api-reference/create-next-app)
- Click on the official Next.js examples
- Break down the command we used.

- > Point out the node_modules folder.  Need to be sure to get a good .gitignore.

- > With Django all we did was add some things, for Nextjs there are a few things we will add as we go through, but there are also a few things we need to remove that we will not need.
1. 'pages/api' folder
1. 'public/vercel.svg' file
1. update 'name' in 'package.json'
1. remove most of the code inside 'pages/index.js'
  - Outermost DIVS and empty main and blank className attributes.
  - update the title in <Head>


- Should end up looking something close to this when done

```js
import Head from 'next/head'

export default function Home() {
  return (
    <div className="">
      <Head>
        <title>Magic 8 Ball</title>
        <link rel="icon" href="/favicon.ico" />
      </Head>

      <header className="">
      </header>

      <main className="">
      </main>

      <footer className="">
      </footer>
    </div>
  )
}
```

- Lets take a look at what our end goal here is.  Or at least something close to this.
- Open 8 Ball Image

- Lets start off in the header.

Header
```js
<header className="flex items-center justify-between p-4 bg-gray-500 text-gray-50">
    <h1 className="text-4xl text-gray-50">Magic 8 Ball</h1>
</header>
```

- Discuss the tailwind syntax.  The syntax may be bew but it directly relates to things you know in css

- Lets add a quick footer

Footer
```js
<footer className="p-4 mt-8 bg-gray-500 text-gray-50 ">
  <p>Code Fellows<p>
</footer>
```
- Note the funny comment syntax
- Click on Careers link, should go to 404 page

Question Form

Just doing the visuals for now, will take another pass and wire it up later.

Inside <main> add the form

```js
{/* Question Form */}
<form className="flex w-1/2 p-2 mx-auto my-4 bg-gray-200">
  <input name="question" className="flex-auto pl-1" />
  <button className="px-2 py-1 bg-gray-500 text-gray-50">Ask</button>
</form>
```
Then let's add the 8 Ball

Eight Ball
Now let's create the graphics for 8 ball, we'll add interactivity soon.

```js
{/* Eight Ball */}
<div className="w-96 h-96 mx-auto my-4 bg-gray-900 rounded-full">
    <div className="relative flex items-center justify-center w-48 h-48 rounded-full bg-gray-50 top-16 left-16">
        <p className="text-xl text-center">Ask me anything</p>
    </div>
</div>
```

## Interactivity


### Question Form Input

Now let's wire up the form.

There are a couple ways to do this, the "react" way and the "controlled" way.

Most of the time we'll go the "react" way, but for small cases it is acceptable to do it the older fashioned way for now.

Create a "handler" function that is triggered when form is submitted.

It should be placed **inside** the Home function body, normally at the top.

```javascript
export default function Home() {

    function questionAskedHandler(event) {
        event.preventDefault();
        alert(event.target.question.value);
    }
    ...
```

Add a reference to the function on the form element

``` javascript
<form onSubmit={questionAskedHandler} ...
```


- We want to do more than just alert.  Lets do some react stuff
- React will handle our event handler a little different.  

- First

```js
const [question, setQuestion] = useState('Your Question Goes Here!')
// It says “from the returned array store first item in local variable named question, and store the second item in variable named setQuestion.
// reply is the current value, setReply is a function to call when updating the value.that way React can efficiently know when a re-render may be needed.
```

- Then we update our eventhandler

```js
    // alert(event.target.question.value);
    setQuestion(event.target.question.value)
```

- Then we go down to Where we want the question to show up:

```js
<h3 className="text-xl text-center border">{question}</h3>
// add the {question}
```

- You can see as we test the question, it populates below the 8 Ball just like we wanted
- Now we need to get an answer for our Question.
- For now we are going to stick with yes/no questions.

- We will add in a state for the reply now.

```js
const [reply, setReply] = useState("Ask me anything");

// and update

<p className="text-xl text-center">{reply}</p>
```

- Now lets change the default to make sure state is updating correctly.

```js
const randomReply = Math.random() > .5 ? "Yes" : "No";
```

- Right now this is not very clear.  In fact things are a big mess right now.  Lets clean some of this up and make some things re-usable.

- Lets move the header into it's own Function

```js
  function Header(props){
    return(
    <header className="p-4 bg-gray-500">  
      <h1 className="text-4xl text-gray-50">{props.title}</h1>
    </header>
    )
```

- Now we can call it like this and pass in a title

```js
<Header title="Magic 8 Ball"/>
```

- Rerender the page and make a chance to the title.  Bingo Bango.