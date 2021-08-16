using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
  public class Article
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public string Text { get; set; }
    public DateTime Posted { get; set; }
  }
}
