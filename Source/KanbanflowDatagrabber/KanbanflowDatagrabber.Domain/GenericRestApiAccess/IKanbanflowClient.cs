using KanbanflowDatagrabber.Domain.Model;

namespace KanbanflowDatagrabber.Domain.GenericRestApiAccess;

using System.Threading.Tasks;

public interface IKanbanflowClient
{
    Task<Board> GetBoardAsync();
    Task<string> GetTasksAsync(string columnId);
    // Add other Kanbanflow API methods as needed
}
