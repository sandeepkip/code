using System;

namespace code.ranges
{
  public interface IContainValues<in Value> where Value : IComparable<Value>
  {
    bool contains(Value value);
  }
}