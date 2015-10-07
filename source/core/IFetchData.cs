using System.Data;

namespace code.core
{
  public delegate Data IFetchData<out Data>();

  public interface IQueryForData<out Data>
  {
    Data run();
    void prepare(IDbCommand command);
  }


}