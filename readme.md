This solution is intended to evaluate the impact of services creation (Singleton vs Transient) on the performance of an ASP.Net application

The services in this app are intentionally very light. If the service constructor contains heavy logic, this will impact the performance.

This app use BenchmarkDotNet to calculate the performance

## To use this benchmark

- Run BenchmarkSingletonServices (It will run on port 5135). It is a normal Aps.net application running on .Net framework 6
- Run BenchmarkSingletonServices (It will run on port 5136)
- Go to the BenchmarkConsole folder, and run the command : dotnet run -c Release