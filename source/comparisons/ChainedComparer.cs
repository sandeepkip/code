using System.Collections.Generic;

namespace code.comparisons
{
  public class ChainedComparer<Item> : IComparer<Item>
  {
    IComparer<Item> first;
    IComparer<Item> second;

    public ChainedComparer(IComparer<Item> first, IComparer<Item> second)
    {
      this.first = first;
      this.second = second;
    }

    public int Compare(Item x, Item y)
    {
      var result = first.Compare(x, y);

      return result == 0 ? second.Compare(x, y) : result;
    }
  }
}