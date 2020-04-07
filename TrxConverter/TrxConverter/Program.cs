using System;
using System.IO;

namespace TddXt.TrxConverter
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Checking for {args[1]} in {args[0]}");
            foreach (var trxPath in Directory.EnumerateFiles(args[0], args[1], SearchOption.AllDirectories))
            {
                PrintTrx(Path.Combine(args[0], trxPath), new TextConsoleOutput());
                PrintTrx(Path.Combine(args[0], trxPath), new HtmlFileTestOutput(FileNameFrom(trxPath)));
            }
        }

        private static string FileNameFrom(string trxPath)
        {
            return Path.ChangeExtension(trxPath, "html");
        }

        private static void PrintTrx(string path, IOutput textOutput)
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