using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PingPongProject.Models
{
  public class PingPong
  {
    public int userInput;

    public List<string> pingPongList = new List<string>();

    public List<string> NumberCalc(int number)
    {
      for(int i=1; i <= number; i++)
      {
        if(i % 3 == 0 && i % 5 == 0)
        {
          pingPongList.Add("Ping-Pong");
        }
        else if(i % 5 == 0)
        {
          pingPongList.Add("Ping");
        }
        else if(i % 3 == 0)
        {
          pingPongList.Add("Pong");
        }
        else{
          pingPongList.Add(i.ToString());
        }
      }
      return pingPongList;
    }
  }
}
