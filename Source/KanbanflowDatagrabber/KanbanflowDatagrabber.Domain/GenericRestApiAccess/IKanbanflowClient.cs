namespace KanbanflowDatagrabber.Domain.GenericRestApiAccess;

using System.Threading.Tasks;

public interface IKanbanflowClient
{
    Task<string> GetBoardAsync(string boardId);
    Task<string> GetTasksAsync(string boardId, string columnId);
    // Add other Kanbanflow API methods as needed
}
