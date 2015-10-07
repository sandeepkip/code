using System.Collections.Generic;

namespace code.comparisons
{
  public class ReverseComparer<Item> : IComparer<Item>
  {
    IComparer<Item> to_reverse;

    public ReverseComparer(IComparer<Item> to_reverse)
    {
      this.to_reverse = to_reverse;
    }

    public int Compare(Item x, Item y)
    {
      return -to_reverse.Compare(x, y);
    }
  }
}