using System;

namespace TddXt.TrxConverter
{
    public class TextConsoleOutput : IOutput
    {
        public void PrintStackTrace(string stackTrace)
        {
            Console.WriteLine(stackTrace);
        }

        public void PrintErrorMessage(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }

        public void PrintStdOut(string stdOut)
        {
            Console.WriteLine(stdOut);
        }

        public void BeginTest(string testOutcome, string testName)
        {
            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine(testOutcome + ": " + testName);
            Console.WriteLine("============================");
        }

        public void EndTest()
        {
            
        }

        public void BeginDocument()
        {

        }

        public void EndDocument()
        {

        }
    }
}