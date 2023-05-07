using CommandLine;

namespace KanbanflowDatagrabber;

public class CommandLineOptions
{
    [Option("api-key", Required = true, HelpText = "Kanbanflow API key.")]
    public string ApiKey { get; }
}