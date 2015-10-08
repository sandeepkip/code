using System;
using System.Collections.Generic;
using System.Linq;

namespace code.web
{
  public class WebHandlers : IGetWebRequestHandlers
  {
    IEnumerable<IHandleOneWebRequest> all_the_handlers;

    public WebHandlers(IEnumerable<IHandleOneWebRequest> all_the_handlers)
    {
      this.all_the_handlers = all_the_handlers;
    }

    public IHandleOneWebRequest get_handler_for_request(IProvideDetailsToHandlers request)
    {
      return all_the_handlers.First(x => x.can_process(request));
    }
  }
}