using System;
using code.enumerables;
using code.prep.movies;

namespace code.matching
{
  public class ComparableMatchFactory<Item, AttributeType>
    where AttributeType : IComparable<AttributeType>
  {
    IGetAnAttributeValue<Item, AttributeType> accessor;

    public ComparableMatchFactory(IGetAnAttributeValue<Item, AttributeType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<Item> greater_than(AttributeType value)
    {
      return new AnonymousMatch<Item>(x => accessor(x).CompareTo(value) > 0);
    }

    public IMatchAn<Item> between(AttributeType start, AttributeType end)
    {
      return new AnonymousMatch<Item>(x => accessor(x).CompareTo(start) >= 0 &&
      accessor(x).CompareTo(end) <=0);
    }
  }
}