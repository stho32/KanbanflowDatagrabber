using System.Text;

namespace KanbanflowDatagrabber.Domain.GenericRestApiAccess;

public class RestClient : IRestClient
{
    private readonly HttpClient _httpClient;

    public RestClient()
    {
        _httpClient = new HttpClient();
    }

    public async Task<string> GetAsync(string url)
    {
        using HttpResponseMessage response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> PostAsync(string url, string jsonData)
    {
        using StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        using HttpResponseMessage response = await _httpClient.PostAsync(url, content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}