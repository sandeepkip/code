using System;
using code.enumerables;
using code.ranges;

namespace code.matching

{
  public class ComparableMatchFactory<Item, AttributeType> : ICreateMatchers<Item, AttributeType>
    where AttributeType : IComparable<AttributeType>
  {
    ICreateMatchers<Item, AttributeType> original;

    public ComparableMatchFactory(ICreateMatchers<Item, AttributeType> original)
    {
      this.original = original;
    }

    public IMatchAn<Item> greater_than(AttributeType value)
    {
      return falls_in_range(new RangeWithNoUpperBound<AttributeType>(value));
    }

    public IMatchAn<Item> between(AttributeType start, AttributeType end)
    {
      return falls_in_range(new InclusiveRange<AttributeType>(start, end));
    }

    public IMatchAn<Item> falls_in_range(IContainValues<AttributeType> range)
    {
      return create_from_match(new FallsInRange<AttributeType>(range));
    }

    public IMatchAn<Item> equal_to(AttributeType value)
    {
      return original.equal_to(value);
    }

    public IMatchAn<Item> equal_to_any(params AttributeType[] values)
    {
      return original.equal_to_any(values);
    }

    public IMatchAn<Item> not_equal_to(AttributeType value)
    {
      return original.not_equal_to(value);
    }

    public IMatchAn<Item> create_from_criteria(Criteria<Item> criteria)
    {
      return original.create_from_criteria(criteria);
    }

    public IMatchAn<Item> create_from_match(IMatchAn<AttributeType> value_matcher)
    {
      return original.create_from_match(value_matcher);
    }
  }
}