namespace code.matching
{
  public class Match<ItemToMatch>
  {
    public static MatchCreationExtensionPoint<ItemToMatch, AttributeType> attribute<AttributeType>(
      IGetAnAttributeValue<ItemToMatch, AttributeType> accessor)
    {
      return new MatchCreationExtensionPoint<ItemToMatch, AttributeType>(accessor);
    }
  }
}