# Project Euler - C# Solutions

## Build & Test
```bash
dotnet build Euler.sln
dotnet test EulerLibTests/EulerLibTests.csproj
```

## Structure
- **Euler/** - Console runner app (net8.0)
- **EulerLib/** - Problem solutions library. Each problem implements `IProblem` (`Id`, `Title`, `Solve()`, `Md5OfSolution`)
- **EulerLibTests/** - Test project (NUnit + FluentAssertions + AutoFixture)

## Conventions
- Problems go in `EulerLib/Problems/0001_0100/Problem0001.cs` (namespace `EulerLib.Problems`)
- Tests go in `EulerLibTests/Problems/0001_0100/Problem0001Fixture.cs` (namespace `EulerLibTests.Problems`)
- Problem input data files go in `ContentFiles/` (lib) or `TestFiles/` (tests), copied to output via csproj
- `SoakTestFixture` validates all solutions via MD5 hash - never commit a broken `Md5OfSolution`
- TreatWarningsAsErrors is enabled in Debug builds
