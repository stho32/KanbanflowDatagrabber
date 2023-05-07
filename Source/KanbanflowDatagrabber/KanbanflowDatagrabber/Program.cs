using CommandLine;
using KanbanflowDatagrabber.Domain.GenericRestApiAccess;

namespace KanbanflowDatagrabber;

public class Program
{
    public static async Task Main(string[] args)
    {
        await Parser.Default.ParseArguments<CommandLineOptions>(args)
            .WithParsedAsync(async options => await RunWithOptionsAsync(options));
    }

    private static async Task RunWithOptionsAsync(CommandLineOptions commandLineOptions)
    {
        string apiKey = commandLineOptions.ApiKey;

        // Create an instance of the KanbanflowClient with the provided API key
        IKanbanflowClient kanbanflowClient = new KanbanflowClient(apiKey);

        // Use the kanbanflowClient to interact with the API
    }
}