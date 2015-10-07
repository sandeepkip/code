using System.Collections.Generic;

namespace code.comparisons
{
  public class FixedComparer<AttributeType> : IComparer<AttributeType>
  {
    IList<AttributeType> values;

    public FixedComparer(IEnumerable<AttributeType> order)
    {
      values = new List<AttributeType>(order);
    }

    public int Compare(AttributeType x, AttributeType y)
    {
      return values.IndexOf(x).CompareTo(values.IndexOf(y));
    }
  }
}