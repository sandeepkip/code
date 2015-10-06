using System;

namespace code.ranges
{
  public class InclusiveRange<Value> : IContainValues<Value> where Value : IComparable<Value>
  {
    Value start;
    Value end;

    public InclusiveRange(Value start, Value end)
    {
      this.start = start;
      this.end = end;
    }

    public bool contains(Value value)
    {
      return value.CompareTo(start) >= 0 && value.CompareTo(end) <=0;
    }
  }
}