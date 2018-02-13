using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongProject;
using System;
using System.Collections.Generic;
using PingPongProject.Models;

namespace PingPongProject.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void TestNumberCalc()
    {
      PingPong testPingPong = new PingPong();
      List<string> pingPongTestCaseList = new List<string>
      {"1", "2", "Pong", "4", "Ping", "Pong", "7", "8", "Pong", "10", "11", "Pong", "13", "14", "Ping-Pong"};
      CollectionAssert.AreEqual(pingPongTestCaseList, testPingPong.NumberCalc(15));
    }
  }
}






//ln02 - this file must use PingPongProject
//ln11 - always start TestMethod w/ Public Void
