using System;
using System.Collections.Generic;

namespace code.comparisons
{
  public class ComparableComparer<Item> : IComparer<Item>
    where Item : IComparable<Item>
  {
    public int Compare(Item x, Item y)
    {
      return x.CompareTo(y);
    }
  }
}