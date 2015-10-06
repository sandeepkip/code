namespace code.matching
{
  public class Match<Item>
  {
    public static IGetAnAttributeValue<Item, AttributeType> attribute<AttributeType>(
      IGetAnAttributeValue<Item, AttributeType> accessor)
    {
      return accessor;
    }
  }
}