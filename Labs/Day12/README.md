![cf](http://i.imgur.com/7v5ASc8.png) Lab 12 : MVC
=====================================

## To Submit this Assignment
- fork this repository
- write all of your code in a branch named `lab-#`; + `<your name>` **e.g.** `lab12-amanda`
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas

## Directions

You have been hired by the "Don't Wine About It" company to create a website that assists customers in finding the perfect wine. 
The company has provided for you a dataset of their current inventory. <br /><br />

Create a website using the MVC architectural pattern that asks the customer to input the price, and point rating
they are searching for. The customer should then be redirected to another page that will show the filtered results from the inventory. <br /><br />

## Stretch (up to 5pts)
1. Make your website "client ready" - Add a stylesheet to your site and dress it up. Make it look like a real website.
2. Filter off of more than just the wine points and price. Make some of the filters optional. <br />
Remember - This could go on your porfolio, employers may be viewing it, make it something you are proud of. We will be deploying
this site to Azure by the end of the week. 

## Requirements
Your MVC website should contain the following once completed:
1. Proper Documentation (Comments, Readme etc...)
2. *One* Controller with 3 actions (Index(Get and Post) & Results)
3. *One* Model with a `Wine.cs` that displays all the properties of each wine
4. *One* Home View with a view page for each action (2 all together)
5. style.css file located in the `wwwroot` folder (stretch goal requirement)
6. _ViewImports file to enable TagHelpers 
7. `Startup.cs` properly configured with the correct Routing Template, Allowing Static Files, and MVC Middleware.
8. Tests. Research. Start Here: [Testing a Controller](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing). 
9. The Wine dataset is given to you in a CSV format. To assist you in the conversion, i have provided for you *my* code to convert the 
the CSV file to an actual Wine object. This method is located in the Wine model. Feel free to use what you need to out of this, but make sure
you fully document what is going on if you choose to use any portion of this code snippet.

```csharp
        public static List<Wine> GetWineList()
        {
            List<Wine> myWine = new List<Wine>();
            string path = Environment.CurrentDirectory;
            //For testing, make sure the path is pointing to the root.
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\wine.csv"));
            using (StreamReader reader = new StreamReader(newPath))
            {
                int counter = 0;
                string line;

                //only grab the top 1000 wines. 
                while (((line = reader.ReadLine()) != null) && counter < 1001)
                {
                    Regex parser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

                    //Separating columns to array
                    string[] wineList = parser.Split(line);

                    //Add new wine object to the list. 
                    myWine.Add(new Wine
                    {
                        ID = wineList[0],
                        Country = wineList[1],
                        Description = wineList[2],
                        Designation = wineList[3],
                        Points = wineList[4],
                        Price = wineList[5],
                        Region_1 = wineList[6],
                        Region_2 = wineList[7],
                        Variety = wineList[8],
                        Winery = wineList[9]

                    });

                    counter++;

                }
            }

            return myWine;
        }

```

10. We will publish this website by the end of the week. Good Luck!


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

- **Readme.md required for submission. Missing readme document will result in a best score of 2/10**
