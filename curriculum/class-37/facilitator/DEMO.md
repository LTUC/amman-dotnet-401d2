# Demos: React II

## Demo Magic Eight Ball Version 2

[Demo](../demo/magic-eight-ball/)

Screen shots

- [Waiting](./assets/waiting.png)
- [One Response](./assets/one-response.png)

The differences between version 1 and version 2 of Demo are...

- Multiple pages with file based routing
- Components in own files
- Answers from bank of imported responses vs. only "yes" and "no"
- Header tracks number of questions asked
- History of questions shown in table
  - using array `map` expression to render table rows
- Styling of table
  - Coloring the "odd" rows to achieve stripe effect.

## Components

[Thinking in React](https://reactjs.org/docs/thinking-in-react.html){:target="_blank"} was in readings. Use the demo as a chance to model this approach.

- Start in index and determine components needed.
  - Root component
    - Head (from Next)
    - Header
    - QuestionForm
    - EightBall
    - History
    - Footer
  - Stub them out in same file as you go.
    - Will move them to own component files as you build them out.
- With completed demo code for reference on separate screen start building out the components.
  - The `Header` component is a good place to start.
  - Move them to `components` folder as you go.
  - Determine required attributes.
    - E.g. `Header` needs a count of answered questions.
  - Don't worry about functionality yet, just focus on properly declaring attributes / receiving props.
    - Hard coded attribute values are fine to start with.
    - E.g. `<Header answerCount={0} />`
- Once component is properly declared and wired up then style it.
  - Refer to completed demo for styling.
- Once component is styled and functional then refactor to remove hard coding.
  - E.g. `<Header answerCount={answeredQuestions.length} />`
  - For `Header` this means storing answeredQuestions array via the `useState` hook.
  - Confirm that Header continues to render properly.
- Repeat above steps for remaining components.
- When you get to `Footer` it will be time to talk about navigation/routing.
  - Don't add `Link` just yet, will come back to that.

## Navigation

- The `Footer` component contains a `Link` to `/careers`
- Create `pages/careers.js` file that exports simple stub component.
  - Emphasize that the file MUST go in pages directory.
  - Go to `/careers` in browser.
  - It just works!
  - File based routing for the win.
- Go back to `footer.js` and add a `Link` around the careers anchor.
  - Run in browser and show working.
  - Note that href is on the `Link` but styles on the `<a>`
- Add a link back home to careers page.
