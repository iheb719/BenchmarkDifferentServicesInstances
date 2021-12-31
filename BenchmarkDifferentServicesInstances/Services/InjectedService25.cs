namespace BenchmarkSingletonServices.Services;

public class InjectedService25
{
    private readonly InjectedService31 _s31;
    private readonly InjectedService32 _s32;
    private readonly InjectedService33 _s33;
    private readonly InjectedService34 _s34;
    private readonly InjectedService35 _s35;

    public InjectedService25(InjectedService31 s31, InjectedService32 s32, InjectedService33 s33, InjectedService34 s34, InjectedService35 s35)
    {
        _s31 = s31;
        _s32 = s32;
        _s33 = s33;
        _s34 = s34;
        _s35 = s35;
    }
}
