using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scifi_Gallery.Controllers
{
  // When first making the project I did a blank ASP.Net but clicked the MVC check
  // box

  // Super important here. You have to add the "controller" suffix. It is 
  // more than a convention this helps MVC find the controller classes. MVC is a 
  // combination of views and controllers. 

  // http://localhost:64488/SciFiBooks/Detail I can just put this in the Url and it
  // it will show the return. 
  public class SciFiBooksController : Controller 
  {
    // This is 
    public string Detail()
    {
      return " Hello from SciFiBooks Controller "; 
    }

  }
}