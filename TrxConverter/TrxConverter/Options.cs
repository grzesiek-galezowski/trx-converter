using CommandLine;

namespace TddXt.TrxConverter
{
  internal class Options
  {
    [Value(0, MetaName = "workingDirectory", HelpText = "Working Directory", Required = true)]
    public string WorkingDirectory { get; set; } = default!;

    [Value(1, MetaName = "searchPattern", HelpText = "Search Pattern", Required = true)]
    public string SearchPattern { get; set; } = default!;

    [Value(2, MetaName = "destinationDirectory", HelpText = "Destination directory", Required = false)]
    public string DestinationDirectory { get; set; } = default!;
  }
}