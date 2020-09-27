# Lab 26: Sprint 1 - Milestone 1 MVC

This lab should be done independent 

## Instructions:

Buid out an application that has the folowing pages:

1. Home Page
1. Products Page

### Home Page

Clean and simple home page design with CSS. Include on this home page a link to the "Products" page. 

### Products Page

The products page will display for the user a list of the data provided inside the `cereal.csv` file. Include a link to return to the home page. The page's functionality should acheive the following:

1. Display all of the products to the page
1. Allow to search by name
1. Sort the data by ascending or descending


A few things to note:

1. You do not need to display pictures of the products, just line items will suffice. 
1. CSS is required. Use Bootstrap if you can. 
1. No database exists in today's lab. Your data source will be your csv file
1. Use the repository design pattern and dependency injection within the `ProductsController.cs`. Keep note that as we move through this project we will be chnging the data source. The interface should be generic enough to support both the products in the cereal dataset and any future products. Consider the use of abstract classes and inheritence.


Some hints on reading in the CSV file:
1. Look at the header of the csv file to determine the properties required for the class
1. Hardcoding the field number with the property is allowed.
1. Logic to read a file from the `wwwroot` folder is: 
```
string path = Environment.CurrentDirectory;
string newPath = Path.GetFullPath(Path.Combine(path, @"wwwroot\cereal.csv"));
string[] myFile = File.ReadAllLines(newPath);
```


Fields in the Data set:

```

Name: Name of cereal
mfr: Manufacturer of cereal
A = American Home Food Products;
G = General Mills
K = Kelloggs
N = Nabisco
P = Post
Q = Quaker Oats
R = Ralston Purina
type:
cold
hot
calories: calories per serving
protein: grams of protein
fat: grams of fat
sodium: milligrams of sodium
fiber: grams of dietary fiber
carbo: grams of complex carbohydrates
sugars: grams of sugars
potass: milligrams of potassium
vitamins: vitamins and minerals - 0, 25, or 100, indicating the typical percentage of FDA recommended
shelf: display shelf (1, 2, or 3, counting from the floor)
weight: weight in ounces of one serving
cups: number of cups in one serving
rating: a rating of the cereals (Possibly from Consumer Reports?)
```

## Stretch 

1. Allow for pagination
1. Add additional search params
1. Add more style!
1. Write tests

## Tests

No tests are required for today. 

## Rubric

The lab rubric can be found [Here](../../Resources/rubric){:target="_blank"} 

## To Submit this Assignment

- Create a new repository on Azure Dev Ops
- Name your repo `Ecommerce-App`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in Canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)