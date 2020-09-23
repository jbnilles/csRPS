using System;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  public class Program
  {
    public static void Main()
    {
      Throw something = new Throw();

      for (int i = 0; i < 2; i++)
      {
        Console.WriteLine("Select a throw (Rock, Paper, Scissors, or exit)");
        string user = Console.ReadLine();

        if (user != "exit")
        {
          Console.WriteLine("The " + something.Contest(user) + " Wins.");
          i--;
        }
        else
        {
          break;
        }
      }
    }
  }
}