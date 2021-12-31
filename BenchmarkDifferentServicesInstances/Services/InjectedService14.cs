namespace BenchmarkSingletonServices.Services;

public class InjectedService14
{
    private readonly InjectedService21 _s21;
    private readonly InjectedService22 _s22;
    private readonly InjectedService23 _s23;
    private readonly InjectedService24 _s24;
    private readonly InjectedService25 _s25;

    public InjectedService14(InjectedService21 s21, InjectedService22 s22, InjectedService23 s23, InjectedService24 s24, InjectedService25 s25)
    {
        _s21 = s21;
        _s22 = s22;
        _s23 = s23;
        _s24 = s24;
        _s25 = s25;
    }
}
