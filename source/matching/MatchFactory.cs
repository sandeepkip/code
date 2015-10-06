using code.enumerables;

namespace code.matching
{
  public class MatchFactory<Item, AttributeType> : ICreateMatchers<Item, AttributeType>
  {
    IGetAnAttributeValue<Item, AttributeType> accessor;

    public MatchFactory(IGetAnAttributeValue<Item, AttributeType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<Item> equal_to(AttributeType value)
    {
      return equal_to_any(value);
    }

    public IMatchAn<Item> equal_to_any(params AttributeType[] values)
    {
      return create_from_match(new EqualToAny<AttributeType>(values));
    }

    public IMatchAn<Item> not_equal_to(AttributeType value)
    {
      return equal_to(value).negate();
    }

    public IMatchAn<Item> create_from_criteria(Criteria<Item> criteria)
    {
      return new AnonymousMatch<Item>(criteria);
    }

    public IMatchAn<Item> create_from_match(IMatchAn<AttributeType> value_matcher)
    {
      return new AttributeMatch<Item, AttributeType>(accessor,
        value_matcher);
    }
  }
}