# LINQ examples in C#

A small .NET 9 console application that demonstrates common Language Integrated Query (LINQ) operations over a list of students. The sample is written in Swedish to match the model properties and console headings.

![Console output preview](https://raw.githubusercontent.com/1x4x/7-linq/6560a0588d8f563628fce7336df599b7a988b32f/linq/docs/screenshots/linq-examples.svg)


## What is included?

The program in `Program.cs` demonstrates:

- filtering with `Where`
- projecting values with `Select`
- sorting with `OrderBy` and `OrderByDescending`
- counting with `Count`
- limiting results with `Take`
- removing duplicates with `Distinct`
- testing sequences with `Any` and `All`
- selecting individual elements with `FirstOrDefault`, `LastOrDefault`, and `SingleOrDefault`
- grouping with `GroupBy`
- calculating totals with `Sum`, `Average`, `Min`, and `Max`

The sample data is created by `Student.GetStudents()` and contains eight students with an ID, name, age, class, and score.

## Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

## Run the project

```bash
git clone https://github.com/1x4x/7-linq.git
cd 7-linq/linq
dotnet run
```

Build without running:

```bash
dotnet build
```

## Example queries


```csharp
// Students older than 20
var olderStudents = list.Where(student => student.Alder > 20);

// Two students with the highest scores
var topStudents = list
    .OrderByDescending(student => student.Poang)
    .Take(2);

// Names grouped by class
var studentsByClass = list.GroupBy(student => student.Klass);
```

Each query is evaluated against the same in-memory list, making the project useful as a quick reference for LINQ syntax and method chaining.

## Project structure

| File | Description |
| --- | --- |
| `Program.cs` | Runs the LINQ examples and writes results to the console. |
| `Student.cs` | Defines the student model and sample data. |
| `Util.cs` | Provides formatting helpers for headings. |
| `linq.csproj` | Targets .NET 9 and configures the console project. |

## License

This project is provided for learning and demonstration purposes. Fjonke 
