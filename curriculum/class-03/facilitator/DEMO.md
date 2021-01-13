# Demos: Intro to C# / Exception Handling

Note: Demos as they exist in the `/demo` folder are provided in their **completed** state.

## Demo

- Start with an empty repository at Github
- Scaffold out a basic working environment
  - `npm init`
  - Create your basic app structure
    - .eslintrc.json (from configs)
    - .gitignore (from configs)
    - `index.js`
    - `lib/http.js`
    - `lib/input.js`
- Begin coding with index.js requiring input.js
  - First, create a simple object.
  - Create an `object.function = () => {}` and an `object.value="something"` and export `object`
  - Witness how the index can use the function or the value (you can export anything)
  - Now, create a constructor function you export instead and instantiate that from index
  - Note how you can export a constructor, too
- Describe the mechanics of `module.exports` and how that relates to `require()`
- Extend the functionality of the module, using TDD to set command line options
  - Use the `minimist` library to read the `-u`, etc args
    - A chance to talk through 3rd party dependencies ...
  - Each of the prototype functions takes input, returns a value, making them easy to test later
  - Implement a final `valid()` method to make an overall assertion on the object's validity

## Takeaways

- `module.exports` can return anything
- `require()` gets whatever `module.exports` gave you
