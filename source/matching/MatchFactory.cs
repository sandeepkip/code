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

    public IMatchAn<Item> equal_to_any(params AttributeType[] values)
    {
        AttributeType previous = default(AttributeType);
        foreach (var value in values)
        {
            if (previous == null)
            {
                previous = value;
                continue;
            }
            return equal_to(value).matches(previous());
        }
    }
  }
}