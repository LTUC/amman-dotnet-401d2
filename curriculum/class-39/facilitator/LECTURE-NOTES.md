# Lecture NOTES: React III

- Project teams will be released during the next class.
  - Prep assignments to start the following week.
- Whiteboard interviews will start next week.  I will have full schedule during the next clas.
  - If you have not giving me your avaliability please do so via slack message in class channel.

## Review the Lab

- Give example of what we will code out
- Walk through Home / About
- Show previous 10
- Click on the Refer to XKCD API link show the JSON for each
- For todays implementation we will:
  - Use Nextjs
  - Have a way to fetch data
  - have a way to display data

## Lets Build an app

- We are going to start by installing react with next.  What is NEXT?
  - Next.js: The React Framework
  - Next.js has the best-in-class "Developer Experience" and many built-in features; a sample of them are:
    - An intuitive page-based routing system (with support for dynamic routes)
    - Pre-rendering, both static generation (SSG) and server-side rendering (SSR) are supported on a per-page basis
    - Automatic code splitting for faster page loads
    - Client-side routing with optimized prefetching
    - Built-in CSS and Sass support, and support for any CSS-in-JS library
    - Development environment with Fast Refresh support
    - API routes to build API endpoints with Serverless Functions

- Run the following command:

```npx create-next-app xkcd```
> NOTE: Installing react, react-dom, and next using npm
> This create-next-app does all of the above. The above will still work, but this is easer.

- Once the installation is complete, click on the started server at link:

- Open the index.js.  Delete everything in the render add in a Hello world
- Also delete the non global style
- delete other things that are not needed

```javascript
export default function Home() {
  return (
    <div>
      <h1>Hello World</h1>
    </div>
  )
}
```

- Refresh the page and see the Hello World
- Next add in some style inline

```javascript
  return (
    <div>
      <p>Hello World</p>

      // ********* START HERE
      <style jsx>{`
      .hello {
        font: 15px Helvetica, Ariel, sans-serif;
        background: #eee;
        padding: 100px;
        text-align: center;
        transition: 100mx ease-in background;
      }
      `}
      </style>
    // ********** END HERE

    </div>
  )
```

- We have a Hello world, but we want the xkcd site.
- Where do we go from here?
- QUESTION: Does anyone remember from our previous reading there was a Thinking in React.
- ANSWER [React](https://reactjs.org/docs/getting-started.html)
- Click on Main Concepts and #12 is Thinking in React
- The suggest to start from a Mock, well we don't have a Mock, we have "reference". Click on the xkcd site.

- Lets break down our site into some componets.
  - We have this overall page as a compontet
  - Then we have this header / nav bar area as a componet.
  - We have H1 or Title
  - We have a title of the image
  - We have the image
  - We have Previosus.
- Depending on the Complexity (or simplicity) of your page you may not need break down additional componets.
- In our example here at a minimum we should do this nav area.
- And then we should do this area with the comic as well.
- Lets start with the header componet.

- We can start with Adding a `<Header />` componet.

```javascript
    <div className="hello">
      <Header />          <----Add This
      <h1>Hello World</h1>
```

- Do a quick

```javascript
function Header(props){
  return(
    <h1>This is a Header</h1>
  )
}
```

- We see this works, but I want this to be avaliable to any page I create.  Instead lets put this in its own file.  We can create a `componets` folder and create a Header.js file in there.
- In the Header.js file add the following:

```javascript
export default function Header(props){
    return(
        <header>
            <h1>
                This is my Header
            </h1>
        </header>
    )
}
```

- Save it and reload the page.  Hmm, not working.  Whats going on here?
- Need to import the file in our index.js
```import Header from '../componets/Header'```

- Because we have the export default in the Header, we get this easy import.
- Refresh the page and everything should be working now.

- We also have this notion of a footer with the previous comics listed. but if we look at the about page, there is no footer there. Because this is only on the main page I could easliy add this to the index file and it would work just fine, but I want to think about scaleability. Lets create a footer.js file.

- In our `componets` folder create a Footer.js
- Add the following code to Footer.js

```javascript
export default function Footer(props){
    return(
        <footer>
            <p>
                This is my Footer
            </p>
        </footer>
    )
}
```

- Looking at our Example, lets get rid of the hello world and change to `Current Comic Stuff`

- We have not identified our componets for the home page.  We have them mostly isolated.
- Our next area to spend some time on is this current comic. If we look at our example we have this title of XKCD.  We can easily add that.

```javascript
<h1>XKCD</h1>
```

- This is looking good so far.  Now we need an image. We need to fetch the image from the api.
- We can look at the next.js docs for this.  Google next js.  Click on `Docs` and then on `Data Fetching`.
- Let's take a look at `getServerSideProps`.
- Grab this code and add at the end of your index.js

```javascript
export async function getServerSideProps(context) {
  return {
    props: {}, // will be passed to the page component as props
  }
}
```

- Now in here we need to fetch some data.
- We can just a builtin function called fetch that next gives us without having to inport anything.
- Fetch wants a url. What is that URL, lets go back to the xkcd api and look at the current comic. We can add that into the fetch
```fetch('http://xkcd.com/info.0.json')```

This fetch is an asyncrounous operation.  We will use the await async for this. Lets assign the responce to this.

``` const responce = await fetch('http://xkcd.com/info.0.json');```

This allows us to do async calls with out all of the promises. They are still involoved, but handled in a cleaner way under the hood.

Now we need to convert that responce into a data representation. This is also an async operation.

```const data = await response.json();```

- Inside of our props we add a key and it is given the data that comes back
```comic: data```

- With that we can grab the comic via props.
- We need to absorb props in the Home(props)
- Then we add a `<p>{props.comic.title}</p>`
- > NOTE: Can look at the properties of the JSON.

- If we can get the title, we can get everything listed.
- Lets change the title to an H2 and get rid of current comic stuff
- QUESTION: How do we get the image here?
- ANSWER: `<img src={} alt={} />`
```<img src={props.comic.img} alt={props.comic.alt} />```

- Now we can move to the footer. In the footer we want to get the previouse 10 comics avaliable. This will change from day to day so not something we want to hard code.
- If we look at the data we can see there is a number.  This is associated with the id.  Because we have this number, we can use this to get the previous 10.  
- QUESTION: How do we get this current number to our footer componet.
- ANSWER: Pass the prop in through the `<Footer>` by:
- `comicNum={props.comic.num}`

- In the Footer, change the `<p>{props.comicNum}</p>`
- We should see the number in the footer now.

- Now that we have a number, we can create a simple loop to add the numbers we need to a list.
- Add the following to Footer above the return():

```javascript
    const currentNum = props.comicNum;
    const nums = []

    for(let n = currentNum; n >= currentNum - 10; n--){
        nums.push(n)
    }
```

- Then update the return with the following:

```javascript
<p>
  {nums}
</p>
```

- We can see the length of the array at the bottom. We can adjust the number to 10 by removing the = or changing to - 9.
- Now we want to make these links and not just a list(array) length.

- We can add an h2 for previous 10.  Use the nums.length for the Previos #
`<h2>Previous {nums.length}</h2>`

- We can now change the numbers to a `<ul>`
- We are going to have some number of LI's in there. What do we do?
- How do we turn an list full of numbers into a bunch of li's with links to refer those numbers.
- MAP is how we can do this.
- We will map over nums.

```javascript
<ul>
  {nums.map(num => (
    <li key={num}>
      <Link>
        <a>#{num}</a>
      </Link>
    </li>
  ))}
</ul>
```

From your reading you may remeber the Link.  We now get a Link is not defined.  How do we define Link? We can inport it into the file by
`import Link from 'next/Link`

- We see this error

```Error: Failed prop type: The prop `href` expects a `string` or `object` in `<Link>`, but got `undefined` instead.```

This is a little confusing but it is expecting an 'href' in Link.  We can just add a blank one.
`<Link href=''>`
As soon as we add that, we see a list of numbers that are in our nums array.

Here we are now going to want to link to another page.  This will be a dynamic page based on what is clicked.  We will want to add in another page in our pages directory.
We will add [id].js to the folder. Trying to do this through touch command my render some issues because of the symbols. I'll use my editor for this to creat it.

- Make sure the file is created in a num folder.
- In our [id].js file we add the following:

```javascript
export default function ComicDetail(props){
    return(
        <h3>Soon</h3>
    )
}
```

- Now we want to update our href to point to the new page

```javascript
    return(
        <footer>
            <h2>Previous {nums.length}</h2>
            <ul>
                {nums.map(num => (
                    <li key={num}>
                        <Link href="/num/[id].js" as={`/num/${num}`}>
                            <a>#{num}</a>
                        </Link>
                    </li>
                ))}
            </ul>
        </footer>
    )
```
Comment out the li's and move the key into the Link.  This is looking more like our example.

Now we head over the [id].js.  We need to add some actual content here.  In order to do this we will need to do another async call.

```javascript
export async function getServerSideProps(context) {
    const num = context.query.id;
    const response = await fetch(`https://xkcd.com/${num}/info.0.json`);
    const comic = await response.json();

    return {
        props: {
            comic
        }
    }
}
```

Now we cal look in our h3 for {props.comic.title}

Now that we see this on our web page we can bring in other things.

- Update the function to be this:

```javascript
import Header from '../../componets/Header'
export default function ComicDetail(props){
    return(
        <>
            <Header />
            <h1>{props.comic.title}</h1>
            <img src={props.comic.img} alt={props.comic.alt}></img>
        </>
    )
}
```

I still see I need to update my header
```javascript
import Link from 'next/link';
    <nav>
        <Link href="/">
            <a>Home</a>
        </Link>
        <Link href="/about">
            <a>About</a>
        </Link>
        <style jsx>{`
            a {
                margin-right: 15px;
                color: green;
            }
        `}
        </style>
    </nav>
```

We see that is working.  Last thing we need is an about page.  Lets throw that in really quick.
