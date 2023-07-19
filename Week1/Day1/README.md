
# Day 1 Key Takeaways

Visual Studio Code setup for .NET and C# development


## Lessons Learned

### Setup
.NET and C# development made possible mainly by the official extension from Microsoft. The following items should be installed in your system

- .NET SDK (Version 7 is the latest during the time of writing)
- C# Dev Kit extension by Microsoft (this will automatically installs C# and its Intellicode extensions)
- Solution explorer by Fernando Escolar (Optional)

### Handling C# Projects

A typical C# console project shall contain the following:
- Solution file
- .csproj file
- bin folder
- obj folder
A solution file manages multiple .csproj files that may be used in the solution folder it also tracks the dependencies of each project. Bin and obj folder are generated during the build process of the project. You may exclude them in your version control repository.

It is best to isolate your projects from the main solution file by creating a dedicated folder for each project. 

To initiate a creation of solution file use `dotnet new sln` command in your terminal. Please keep in mind the directory when invoking this command. 

To create new console project, use `dotnet new console`. Ensure that you have provided isolated folder from the .sln file.

To run your program, navigate to your project directory and use `dotnet run` command. It might take a while as your project needs to be built before executed.

#### notes
- Please keep in mind that the project structure mentioned above is limited only to console program. Program that requires a certain framework to operate such as ASP, Unity, WPF, or Winform might have additional files.


## Personal Findings

- Solution explorer is provided by the official extension by default. it is wise to use this rather than the optional one to prevent future conflicts

- Solution and project initiation, alongside with navigating through multiple solution and project files can be achieved easier by using the solution explorer.

- Solution explorer provides you the vast choice of c# projects and helps you isolate them by creating a dedicated folder.

