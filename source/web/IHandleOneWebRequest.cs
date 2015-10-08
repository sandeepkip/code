namespace code.web
{
  public interface IHandleOneWebRequest : IRunAUserFeature
  {
    bool can_process(IProvideDetailsToHandlers request);
  }
}