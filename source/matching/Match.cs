namespace code.matching
{
  public class Match<Item>
  {
    public static MatchFactory<Item, AttributeType> attribute<AttributeType>(
      IGetAnAttributeValue<Item, AttributeType> accessor)
    {
      return new MatchFactory<Item, AttributeType>(accessor);
    }
  }
}