using System.IO;
using TddXt.TrxConverter.Xml;

namespace TddXt.TrxConverter
{
  static internal class ConversionRoutine
  {
    public static void Execute(string path, IOutput textOutput)
    {
      var text = File.ReadAllText(path);
      var testRun = text.ParseXml<TestRun>();

      textOutput.BeginDocument();

      foreach (var result in testRun.Results)
      {
        textOutput.BeginTest(result.outcome, result.testName);

        if (result.Output != null)
        {
          if (result.Output.StdOut != null)
          {
            textOutput.PrintStdOut(result.Output.StdOut);
          }

          if (result.Output.ErrorInfo != null)
          {
            textOutput.PrintErrorMessage(result.Output.ErrorInfo.Message);
            textOutput.PrintStackTrace(result.Output.ErrorInfo.StackTrace);
          }
        }

        textOutput.EndTest();
      }
            
      textOutput.EndDocument();
    }
  }
}