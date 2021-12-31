using System.Net.Http.Headers;

namespace BenchmarkConsole;

public class RestClient
{
    private static readonly HttpClient _client = new();

    public async Task CallSingletonApp()
    {
        await CallRestService(5135);
    }

    public async Task CallTransientApp()
    {
        await CallRestService(5136);
    }

    private async Task CallRestService(int port)
    {
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var callRest = await _client.GetAsync($"http://localhost:{port}/dummy");

        await callRest.Content.ReadAsStringAsync();
    }
}
