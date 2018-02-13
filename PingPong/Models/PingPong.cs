using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PingPongProject.Models
{
  public class PingPong
  {
    //List
    public List<string> pingPongList = new List<string>();
    //visibility, ReturnType, MethName, Parameters
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

/*
ln -- note this file doesn't have using statment from Controllers because
it require 0 data from PingPongCOntrollers to function.
ln 12 - NumberCalc takes number as an argument. Var userInput gets passed
in as argument when function is called in Controller */
