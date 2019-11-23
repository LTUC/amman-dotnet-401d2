# Lab 44: Open-Source Software

## Overview

Today you and your partners will find and develop a meaningful way to contribute back to the development community at large by finding an open source project which you can participate in. You may not actually make it all the way to a PR today, but should challenge yourself to find a repository, determine a root cause analysis on one of the issues, and potentially submit a PR. 

### Resources
Review the following readings 

- Read: [First Timers Only](https://www.firsttimersonly.com/){:target="_blank"}
- Read: [Quora: What are Github projects that are friendly to beginner coders](https://www.quora.com/What-are-GitHub-projects-that-are-friendly-to-beginner-coders){:target="_blank"}
- Read: [Why I contribute](https://www.intopalo.com/blog/2017-11-28-why-i-contribute-to-oss/)

### Setup
- Review the resources above for ideas on how and where to start with finding a project that interests you and your partner
    - *Note: Documentation fixes are not acceptable for this assignment unless approved by your instructor*
    - Focus your search on areas which you can contribute to the code base or writing additional tests!
- Once you've found a project of interest and, more specifically, an issue which you and your partner feel you can meaningfully contribute to... fork and clone the project
- Add your partner to the fork as a collaborator

### Features
- Identify a specific issue (documented or not) within the project of your choosing, and document your findings in a [Root Cause Analysis](https://en.wikipedia.org/wiki/5_Whys){:target="_blank"}
    - *Note: your 5-whys RCA should be created and stored outside of your project fork (it's for your own purposes, but you will turn that in with this assignment)*
    - For example:
        1. Update a small library (2.0 to 2.1?)
        2. Write three meaningful tests (testing areas which have poor coverage) within an existing library to provide further test coverage withing the library
        3. Identify an area of code which could be optimized by refactoring the codebase; i.e. list comprehension vs map (circumstantial...)
- Determine a solution to the issue with your partner, and document your solution in your RCA
- Determine what areas of the project you need to improve outside of just code contributions; i.e. documentation, testing, etc...

- (Stretch) Implement your changes, and submit a PR to the upstream repository

### Testing
- No standalone testing requirements for this lab. You should test as necessary as part of your contributions.

## Submission
1. Create a pull request from your feature branch to your `master` branch.
2. In your open pull request, leave as a comment [a checklist](https://github.com/blog/1825-task-lists-in-all-markdown-documents){:target="_blank"} of the specifications, with the actual specifications you completed checked off.
3. Copy the link to your open pull request and paste it into the Canvas assignment for this day.
4. Upload your RCA document, and leave any comments you may have about the assignment in the comments box. This includes any difficulties you may have had with the assignment.
5. Merge your feature branch into `master`