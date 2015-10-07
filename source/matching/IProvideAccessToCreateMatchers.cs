namespace code.matching
{
  public interface IProvideAccessToCreateMatchers<in ItemToMatch, out AttributeType>
  {
    IMatchAn<ItemToMatch> create_matcher(IMatchAn<AttributeType> value_matcher);
  }
}