namespace code.web
{
  public interface IHandleAllTheWebRequests
  {
    void process(IProvideDetailsToHandlers web_request);
  }
}