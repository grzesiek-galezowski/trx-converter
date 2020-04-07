using System.Security.Cryptography;

namespace TddXt.TrxConverter
{
    public interface IOutput
    {
        void PrintStackTrace(string stackTrace);
        void PrintErrorMessage(string errorMessage);
        void PrintStdOut(string stdOut);
        void BeginTest(string testOutcome, string testName);
        void EndTest();
        void BeginDocument();
        void EndDocument();
    }
}