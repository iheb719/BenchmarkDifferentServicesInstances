This solution is intended to evaluate the impact of services creation (AddSingleton vs AddTransient) on the performance of an ASP.Net application

The services in this app are intentionally very light. If the service constructor contains heavy logic, this will impact the performance.

This app use BenchmarkDotNet to calculate the performance

## Solution description

- This solution is composed of 3 projects :
	- BenchmarkSingletonServices
		- An Asp app that targets .Net 6
		- It Exposes a rest controller (DummyController) that uses a sample service (UtilityService)
		- UtilistyService uses a bunch of empty services
		- All services are declared Singleton in Program.cs
		- The app will run on port 5135
	- BenchmarkTransientServices
		- The same exact copy of BenchmarkSingletonServices except :
			- All services are declared Transient in Program.cs
			- The app runs on port 5136
	- BenchmarkConsole
		- A console app
		- It uses the libraryBenchmarkDotNet to make the benchmarking
		- It makes rest calls to BenchmarkSingletonServices and BenchmarkTransientServices and compare the performance

## To use this benchmark

- Run BenchmarkSingletonServices (It will run on port 5135)
- Run BenchmarkSingletonServices (It will run on port 5136)
- Go to the BenchmarkConsole folder, and run the command : dotnet run -c Release

## My results

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1415 (20H2/October2020Update)
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


|           Method |     Mean |   Error |  StdDev |
|----------------- |---------:|--------:|--------:|
| CallSingletonApp | 101.0 us | 0.64 us | 0.53 us |
| CallTransientApp | 108.3 us | 1.16 us | 1.03 us |


## Conclusion

The difference in performance is very minor.
Of course, this is a sample app and all the constructors are nearly empty. Beware if you have some treatements in your constructors.