using System;
using System.Collections.Generic;
using System.Linq;

namespace code.web
{
  public class WebHandlers : IGetWebRequestHandlers
  {
    IEnumerable<IHandleOneWebRequest> all_the_handlers;
    ICreateAHandlerWhenNoneExistForARequest special_case;

    public WebHandlers(IEnumerable<IHandleOneWebRequest> all_the_handlers, ICreateAHandlerWhenNoneExistForARequest special_case)
    {
        this.all_the_handlers = all_the_handlers;
        this.special_case = special_case;
    }

      public IHandleOneWebRequest get_handler_for_request(IProvideDetailsToHandlers request)
    {
          foreach (var handler in all_the_handlers)
          {
              if (handler.can_process(request))
                  return handler;
          }

          return special_case(request);
    }
  }
}