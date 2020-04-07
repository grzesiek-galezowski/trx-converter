using System;
using System.IO;
using GlobExpressions;

namespace TddXt.TrxConverter
{
    static class Program
    {
        static void Main(string[] args)
        {
            foreach (var trxPath in Glob.Files(args[0], args[1]))
            {
                PrintTrx(Path.Combine(args[0], trxPath));
            }
        }

        private static void PrintTrx(string path)
        {
            var text = File.ReadAllText(path);
            var testRun = text.ParseXml<TestRun>();

            foreach (var result in testRun.Results)
            {
                Console.WriteLine("=============");
                Console.WriteLine(result.outcome + ": " + result.testName);
                Console.WriteLine("=============");

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