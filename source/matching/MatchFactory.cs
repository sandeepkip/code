using code.prep.movies;

namespace code.matching
{
  public class MatchFactory<Item, AttributeType>
  {
    IGetAnAttributeValue<Item, AttributeType> accessor;

    public MatchFactory(IGetAnAttributeValue<Item, AttributeType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<Item> equal_to(AttributeType value)
    {
      return new AnonymousMatch<Item>(x => accessor(x).Equals(value));
    }

    public IMatchAn<Item> equal_to_any(params Item[] values)
    {
      throw new System.NotImplementedException();
    }
  }
}