This is a simple project that shows how to create unit tests for a class library.

# Creating the solution
The project was created via the following DotNet CLI commands:

1. To create the solution:<br>
`dotnet new sln -o MyApp`

2. To create the MathsService library:<br>
`dotnet new classlib -o MathsService`

3. To rename the auto-generated file to something more applicable:<br>`ren .\MathsService\Class1.cs MathsService.cs`

4. To the MathsService library to the solution:<br>`dotnet sln add ./MathsService/MathsService.csproj`

5. To create a MathsService unit test project:<br>`dotnet new xunit -o MathsService.UnitTests`

6. So that the MathsService unit test project can reference the MathsService library:<br>`dotnet add ./MathsService.UnitTests/MathsService.UnitTests.csproj reference ./MathsService/MathsService.csproj`

7. To the MathsService unit tests to the solution:<br>`dotnet sln add ./MathsService.UnitTests/MathsService.UnitTests.csproj`

Note: the `-o` option for the `dotnet new` commands allows us to specify the name of the output directory.

# Running the unit tests
The unit tests can be simply run by typing:<br>
`dotnet test`