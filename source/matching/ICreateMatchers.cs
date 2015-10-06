using code.enumerables;

namespace code.matching
{
  public interface ICreateMatchers<Item, AttributeType>
  {
    IMatchAn<Item> equal_to(AttributeType value);
    IMatchAn<Item> equal_to_any(params AttributeType[] values);
    IMatchAn<Item> not_equal_to(AttributeType value);
    IMatchAn<Item> create_from_criteria(Criteria<Item> criteria);
    IMatchAn<Item> create_from_match(IMatchAn<AttributeType> value_matcher);
  }
}