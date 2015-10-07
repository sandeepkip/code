using System.Collections.Generic;

namespace code.comparisons
{
  public interface IApplyASortDirection
  {
    IComparer<Item> apply_to<Item>(IComparer<Item> item);
  }
}