namespace BenchmarkTransientServices.Services
{
    public class UtilityService
    {
        private readonly InjectedService11 _s11;
        private readonly InjectedService12 _s12;
        private readonly InjectedService13 _s13;
        private readonly InjectedService14 _s14;
        private readonly InjectedService15 _s15;

        public UtilityService(InjectedService11 s11, InjectedService12 s12, InjectedService13 s13, InjectedService14 s14, InjectedService15 s15)
        {
            _s11 = s11;
            _s12 = s12;
            _s13 = s13;
            _s14 = s14;
            _s15 = s15;

            new Random().Next();
        }

        public int UtilityMethod()
        {
            return 1;
        }
    }
}