using System;
using System.Collections.Generic;
using System.IO;
using CommandLine;
using TddXt.TrxConverter.HtmlOutput;
using TddXt.TrxConverter.TextOutput;

namespace TddXt.TrxConverter
{
    static class Program
    {
        static void Main(string[] args)
        {
          CommandLine.Parser.Default.ParseArguments<Options>(args)
            .WithParsed(RunOptions)
            .WithNotParsed(HandleParseError);

        }

        private static void HandleParseError(IEnumerable<Error> obj)
        {
          foreach (var error in obj)
          {
            Console.Error.WriteLine(error.ToString());
          }
        }

        private static void RunOptions(Options obj)
        {
          Console.WriteLine($"Checking for {obj.SearchPattern} in {obj.WorkingDirectory}");
          foreach (var trxPath in Directory.EnumerateFiles(obj.WorkingDirectory, obj.SearchPattern, SearchOption.AllDirectories))
          {
            ConversionRoutine.Execute(Path.Combine(obj.WorkingDirectory, trxPath), new TextConsoleOutput());
            ConversionRoutine.Execute(Path.Combine(obj.WorkingDirectory, trxPath), new HtmlFileTestOutput(FileNameFrom(trxPath)));
          }
        }

        private static string FileNameFrom(string trxPath)
        {
            return Path.ChangeExtension(trxPath, "html");
        }
    }
}