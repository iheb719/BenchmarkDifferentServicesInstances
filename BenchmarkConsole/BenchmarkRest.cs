using BenchmarkDotNet.Attributes;

namespace BenchmarkConsole;

public class BenchmarkRest
{
    private readonly RestClient _restClient = new();

    [Benchmark]
    public async Task CallSingletonApp()
    {
        await _restClient.CallSingletonApp();
    }

    [Benchmark]
    public async Task CallTransientApp()
    {
        await _restClient.CallTransientApp();
    }
}
