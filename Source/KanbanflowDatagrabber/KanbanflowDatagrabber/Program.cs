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

        // Get the board structure data
        Console.WriteLine("Getting board data...");
        string boardData = await kanbanflowClient.GetBoardAsync();
        Console.WriteLine(boardData);

        // Get the task data for a specific column
        Console.WriteLine("Getting task data for column 1...");
        string taskData = await kanbanflowClient.GetTasksAsync("y0younnb1vxA");
        Console.WriteLine(taskData);

        // Add other Kanbanflow API requests and output the results as needed
    }
}