using System.IO;
using System.Text;
using System.Web;

namespace TddXt.TrxConverter
{
    public class HtmlFileTestOutput : IOutput
    {
        private readonly string _filePath;
        private readonly StringBuilder _content;

        public HtmlFileTestOutput(string filePath)
        {
            this._filePath = filePath;
            _content = new StringBuilder();
        }

        public void PrintStackTrace(string stackTrace)
        {
            _content.Append("<h3>Stack Trace</h3><pre>" + HttpUtility.HtmlEncode(stackTrace) + "</pre>");
        }

        public void PrintErrorMessage(string errorMessage)
        {
            _content.Append("<h3>Error Message</h3><pre>" + HttpUtility.HtmlEncode(errorMessage) + "</pre>");
        }

        public void PrintStdOut(string stdOut)
        {
            _content.Append("<h3>Output</h3><pre>" + HttpUtility.HtmlEncode(stdOut) + "</pre>");
        }

        public void BeginTest(string testOutcome, string testName)
        {
            _content.Append($"<details>" +
                            $"<summary>" +
                            $"<h2 style=\"display: inline;color: {ColorFor(testOutcome)}\">" +
                            $"{HttpUtility.HtmlEncode(testName)}: {HttpUtility.HtmlEncode(testOutcome)}" +
                            $"</h2>" +
                            $"</summary>");
        }

        private string ColorFor(string testOutcome)
        {
            if (testOutcome == "Passed")
            {
                return "DarkGreen";
            }

            if (testOutcome == "Failed")
            {
                return "DarkRed";
            }

            return "gray";
        }

        public void EndTest()
        {
            _content.Append("</details>");
        }

        public void BeginDocument()
        {
            _content.Append("<html style=\"font-family: Arial, Helvetica, sans-serif\">");
        }

        public void EndDocument()
        {
            _content.Append("</html>");
            File.WriteAllText(_filePath, _content.ToString(), Encoding.UTF8);
        }
    }
}