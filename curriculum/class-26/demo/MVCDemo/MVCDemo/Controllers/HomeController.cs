using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Models.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Controllers
{
  public class HomeController : Controller
  {
    // Query String params: ?name=Martha&age=21
    public IActionResult Index(string name, int age)
    {
      // You can also just hard code the names
      Person person = new Person()
      {
        Name =  name,
        Age = age
      };

      return View(person);
    }

    public IActionResult People()
    {
      List<Person> people = new List<Person>();
      people.Add(new Person() { Name = "Susan", Age = 20 });
      people.Add(new Person() { Name = "Micha", Age = 30 });
      people.Add(new Person() { Name = "Fred", Age = 40 });
      return View(people);
    }

    public IActionResult Article()
    {
      Blog blog = new Blog()
      {
        Title = "The World According To JJ",
        Description = "Wisdom from an unexpected source"
      };

      Article article = new Article()
      {
        Title = "Broccoli should be banned",
        Author = "JJ",
        Text = "The stuff is awful, just get rid of it, please",
        Posted = new DateTime(2021, 7, 4)
      };

      BlogPostVm post = new BlogPostVm()
      {
        Blog = blog,
        Article = article
      };


      return View(post);

    }
  }
}
