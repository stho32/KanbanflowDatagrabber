namespace KanbanflowDatagrabber.Domain.GenericRestApiAccess;

using System.Threading.Tasks;

public interface IRestClient
{
    Task<string> GetAsync(string url);
    Task<string> PostAsync(string url, string jsonData);
}
