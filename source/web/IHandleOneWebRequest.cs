namespace code.web
{
  public interface IHandleOneWebRequest
  {
    void process(IProvideDetailsToHandlers web_request);
    bool can_process(IProvideDetailsToHandlers request);
  }
}