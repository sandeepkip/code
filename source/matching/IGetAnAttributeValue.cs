namespace code.matching
{
  public delegate AttributeType IGetAnAttributeValue<in Item, out AttributeType>(Item item);
}