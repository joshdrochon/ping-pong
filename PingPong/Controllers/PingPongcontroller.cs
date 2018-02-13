using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PingPongProject.Models;
using System;

namespace PingPongProject.Controllers
{
  public class PingPongController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() /*Name of Page (filename)*/
    {
      return View("../Home/Index"); /*Route to Page */
    }

    [HttpPost("PingPong/PingPongResults")]
    public ActionResult PingPongResults()
    {
      PingPong newPingPong = new PingPong();
      int userInput = Int32.Parse(Request.Form["input-number"]);
      List<string> pingPongList = newPingPong.NumberCalc(userInput);
      return View("PingPongResults", pingPongList);
    }
  }
}

/*

ln03 - ...this file must use pingPongProject.Models namespace because it requires some of its
data to function properly.

ln19 - instantiates new PingPong object from PingPong class (within said class includes a List
property that all instances of PingPong can inherit)

ln20 - ["input-number"] = name of input, not ID

ln21 - sets List<string> (i.e variable) pingPongList equal to newPingPong w numberCalc
called on it, and userInput passed in

ln22 - returns PingPongResults.cshtml & pingPongList

*/
