using BenchmarkDifferentServicesInstances;
using BenchmarkDifferentServicesInstances.Services;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xunit;

namespace BenchmarkDifferentServicesInstancesTest
{
    public class UnitTest1
    {
        private static readonly HttpClient client = new HttpClient();

        [Fact]
        public async Task Test1()
        {
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //var id = "5eeffdd1a28671a6e62dbda2";
            //await client.GetAsync($"http://localhost:5135/dummy");

            //EnsureDepsFile();

            //var application = new WebApplicationFactory<Program>()
            //    .WithWebHostBuilder(builder =>
            //    {
            //        builder.ConfigureServices(services =>
            //        {
            //            services.AddControllers();

            //            services.AddSingleton<UtilityService>();
            //        });
            //            // ... Configure test services
            //    });

            WebApplicationFactory<Program> application = new WebApplicationFactory<Program>()
                .WithWebHostBuilder(builder =>
                {
                    builder.ConfigureServices(services =>
                    {

                        //HttpClientServiceStubsInjection.InjecterServicesStubs(services);

                    });
                });

            var client = application.CreateClient();
            await client.GetAsync($"http://localhost:5135/dummy");
        }
    }
}