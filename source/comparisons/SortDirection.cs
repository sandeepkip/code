using System.Collections.Generic;

namespace code.comparisons
{
  public class SortDirection
  {
    public static readonly IApplyASortDirection ascending = new RegularDirection();
    public static readonly IApplyASortDirection descending = new DescendingDirection();
  }

  public class DescendingDirection : IApplyASortDirection
  {
    public IComparer<Item> apply_to<Item>(IComparer<Item> item)
    {
      return item.reverse();
    }
  }

  public class RegularDirection : IApplyASortDirection
  {
    public IComparer<Item> apply_to<Item>(IComparer<Item> item)
    {
      return item;
    }
  }
}