using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PingPongProject.Models;
using System;

namespace PingPongProject.Controllers
{
  public class PingPongController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("../Home/Index");
    }

    [HttpPost("PingPong/PingPongResults")]
    public ActionResult PingPongResults()
    {
      PingPong newPongPing = new PingPong();
      int userInput = Int32.Parse(Request.Form["input-number"]);
      List<string> pingPongList = newPongPing.NumberCalc(userInput);
      return View("PingPongResults", pingPongList);
    }
  }
}
