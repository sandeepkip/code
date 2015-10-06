using System;

namespace code.matching
{
  public class GreaterThan<Value> : IMatchAn<Value> where Value : IComparable<Value>
  {
    Value start;

    public GreaterThan(Value start)
    {
      this.start = start;
    }

    public bool matches(Value item)
    {
      return item.CompareTo(start) > 0;
    }
  }
}