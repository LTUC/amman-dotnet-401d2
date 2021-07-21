using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsAndEnums.Classes
{
  class Date
  {
    public int DayOfMonth { get; set; }
    public DayOfTheWeek Day { get; set; }
  }

  enum DayOfTheWeek
  {
    Sunday, // 0
    Monday, // 1
    Tuesday, // ...
    Wednesday,
    Thursday,
    Friday,
    Saturday
  }

  enum Months : byte
  {
    Jan,
    Feb,
    Mar,
    Apr,
    May,
    Jun,
    Jul,
    Aug,
    Sep,
    Oct,
    Nov,
    Dec
  }
}