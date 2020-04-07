using System;
using System.IO;

namespace TddXt.TrxConverter
{
  class Program
  {
    static void Main(string[] args)
    {
      var text = File.ReadAllText(args[0]);
      var testRun = text.ParseXml<TestRun>();

      foreach (var result in testRun.Results)
      {
        Console.WriteLine("-------------");
        Console.WriteLine(result.outcome + ": " + result.testName);
        if (result.Output != null)
        {
          if (result.Output.StdOut != null)
          {
            Console.WriteLine(result.Output.StdOut);
          }

          if (result.Output.ErrorInfo != null)
          {
            Console.WriteLine(result.Output.ErrorInfo.Message);
            Console.WriteLine(result.Output.ErrorInfo.StackTrace);
          }
        }
      }
    }
  }
}
