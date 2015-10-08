namespace code.web
{
  public interface IGetWebRequestHandlers
  {
    IHandleOneWebRequest get_handler_for_request(IProvideDetailsToHandlers request);
  }
}