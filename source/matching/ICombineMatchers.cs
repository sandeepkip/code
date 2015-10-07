namespace code.matching
{
  public delegate IMatchAn<Item> ICombineMatchers<Item>(IMatchAn<Item> first,
    IMatchAn<Item> second);
}