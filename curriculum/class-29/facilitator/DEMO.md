# Demos: Azure Blob Storage

Use this document to describe the demo(s). Generally, this is going to take the format of either how to build the demo step by step, or less specifically, talking points surrounding the outcomes of the demo segment and code snippets to highlight.

## Demo

Build up as follows:

1. Simple form with POST to an action
   - Note: You get the file name, but no file
1. Refactor: add multipart to the form
   - Note: You can now see a file
1. Save this to a local file
1. Save to Azure Blob

Complete all of this work within the controller.

As a separate exercise, refactor from the controller into an **upload service**. Why? Controllers should delegate, not perform actions.

This presents another opportunity to build this out with the students leading the way. Perform the refactor socratically with the class.

> The provided demo is in the completed state, as it would be following the refactor. Use that code as your reference for building this out in the controller as it's the same, save for it's location
