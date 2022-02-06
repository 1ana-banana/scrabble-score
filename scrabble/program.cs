using System;
using Scrabble;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word to see its scrabble score: ");
      string input = Console.ReadLine();
      Console.WriteLine(Game.CheckCharPoints(input));
    }
  }
}