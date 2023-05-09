using KanbanflowDatagrabber.Domain.GenericRestApiAccess;

public class KanbanflowClient : IKanbanflowClient
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private const string BaseUrl = "https://kanbanflow.com/api/v1/";

    public KanbanflowClient(string apiKey)
    {
        _apiKey = apiKey;
        _httpClient = new HttpClient();
    }

    public async Task<string> GetBoardAsync()
    {
        return await GetAsync($"{BaseUrl}board?apiToken={_apiKey}");
    }

    public async Task<string> GetTasksAsync(string columnId)
    {
        return await GetAsync($"{BaseUrl}tasks?columnId={columnId}&apiToken={_apiKey}");
    }

    // Add other Kanbanflow API methods as needed

    private async Task<string> GetAsync(string url)
    {
        using HttpResponseMessage response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}