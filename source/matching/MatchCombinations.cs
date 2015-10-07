using developwithpassion.specification.specs;

namespace code.matching
{
  public delegate IMatchAn<Item> combine<Item>(IMatchAn<Item> left, IMatchAn<Item> right);

  public class MatchCombinations
  {
    public static combine<Item> or<Item>()
    {
      return (left, right) => left.or(right);
    }
  }
}