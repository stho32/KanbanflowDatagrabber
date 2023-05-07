namespace KanbanflowDatagrabber.Domain.GenericRestApiAccess;

using System.Net.Http;
using System.Threading.Tasks;

public class KanbanflowClient : IKanbanflowClient
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "https://kanbanflow.com/api/v1/";

    public KanbanflowClient(string apiKey)
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{apiKey}:"))}");
    }

    public async Task<string> GetBoardAsync(string boardId)
    {
        return await GetAsync($"{BaseUrl}boards/{boardId}");
    }

    public async Task<string> GetTasksAsync(string boardId, string columnId)
    {
        return await GetAsync($"{BaseUrl}boards/{boardId}/tasks?columnId={columnId}");
    }

    // Add other Kanbanflow API methods as needed

    private async Task<string> GetAsync(string url)
    {
        using HttpResponseMessage response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}
