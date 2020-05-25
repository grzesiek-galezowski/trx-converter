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
            .WithParsed(RunProgram)
            .WithNotParsed(HandleParseError);

        }

        private static void HandleParseError(IEnumerable<Error> obj)
        {
          foreach (var error in obj)
          {
            Console.Error.WriteLine(error.ToString());
          }
        }

        private static void RunProgram(Options options)
        {
          if (options.DestinationDirectory == null)
          {
            Console.WriteLine("Using " + options.WorkingDirectory + " as destination directory");
            options.DestinationDirectory = options.WorkingDirectory;
          }

          Console.WriteLine($"Checking for {options.SearchPattern} in {options.WorkingDirectory}");
          foreach (var trxPath in Directory.EnumerateFiles(options.WorkingDirectory, options.SearchPattern, SearchOption.AllDirectories))
          {
            ConversionRoutine.Execute(options, trxPath, new TextConsoleOutput());
            ConversionRoutine.Execute(options, trxPath, new HtmlFileTestOutput(FileNameFrom(options, trxPath)));
          }
        }

        private static string FileNameFrom(Options options, string trxPath)
        {
            var relativePath = Path.GetRelativePath(options.WorkingDirectory, trxPath);
            var pathWithNewExtension = Path.ChangeExtension(relativePath, "html");
            var absolutePath = Path.Combine(options.DestinationDirectory, pathWithNewExtension);
            return absolutePath;
        }
    }
}