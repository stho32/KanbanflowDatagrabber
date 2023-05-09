using CommandLine;
using KanbanflowDatagrabber.Domain.GenericRestApiAccess;
using KanbanflowDatagrabber.Domain.Model;

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

        // Get the board data
        Console.WriteLine("Getting board data...");
        Board board = await kanbanflowClient.GetBoardAsync();
        Console.WriteLine($"Board ID: {board.Id}");
        Console.WriteLine($"Board Name: {board.Name}");
        Console.WriteLine("Board Columns:");
        foreach (Column column in board.Columns)
        {
            Console.WriteLine($"  Column ID: {column.UniqueId}");
            Console.WriteLine($"  Column Name: {column.Name}");
        }
        Console.WriteLine("Board Colors:");
        foreach (Color color in board.Colors)
        {
            Console.WriteLine($"  Color Name: {color.Name}");
            Console.WriteLine($"  Color Value: {color.Value}");
            Console.WriteLine($"  Color Description: {color.Description}");
        }

        // Get the task data for a specific column
        Console.WriteLine("Getting task data for column 1...");
        string taskData = await kanbanflowClient.GetTasksAsync("y0younnb1vxA");
        Console.WriteLine(taskData);

        // Add other Kanbanflow API requests and output the results as needed
    }

}