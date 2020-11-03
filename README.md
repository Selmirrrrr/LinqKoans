# LINQ Koans
The LINQ (Language Integrated Query) Koans will walk you along the path to knowledge in order to learn LINQ with C# on .NET Core. The goal is to learn principal LINQ extensions like `.Where()`, `.Select()`, `.GroupBy()` etc.

This project is a fork from [DotNetCoreKoans](https://github.com/NotMyself/DotNetCoreKoans) by [NotMyself(Bobby Johnson)](https://github.com/NotMyself), do not hsitate to have a look into this project, even if you're a expernecied C# developer you might leatn something new. All kudos to @NotMyself.

Paths in there will be based on Microsoft's [101 LINQ Samples](https://github.com/dotnet/try-samples/blob/master/101-linq-samples/index.md).

I firstly started this project to help my students at EPSIC (Lausanne, CH) learn LINQ and then decided to share it widely on GitHub.

### The Structure

//TODO

### Running Locally

1. Install [.NET Core SDK 3.1](https://www.microsoft.com/net/core).
2. Install [Visual Studio Code](https://code.visualstudio.com/)
3. Clone the repository: `git clone https://github.com/Selmirrrrr/LinqKoans.git`.
4. Change directory into the cloned repository `cd LinqKoans`.
5. Restore packages: `dotnet restore`.
6. Open the project in VSCode `code .` depending on what version you chose to install.
7. Run the koans in watch mode: `dotnet watch --quiet run`.
   - **Note:** The `--quiet` flag is used here to suppress mesages from the watch framework.
8. Follow along with the instructions printed to your console. Each time you save a \*.cs file, the project will be built and run again for you automatically.

### About Koans

This project is based on the work of [Cory Foy](https://github.com/CoryFoy) and his original multi-language project [DotNetKoans](https://github.com/CoryFoy/DotNetKoans). If you are interested in learning VB.NET or the Full .NET Framework (windows only), please look at his fine work.

Programming Koans came about because of the most enlightened [Ruby Koans](https://github.com/edgecase/ruby_koans) by [Jim Weirich](https://github.com/jimweirich). Jim was a great teacher & programmer whom I had the pleasure of meeting, learning from and playing games with. Rest in peace, sir. We will continue your effort to bring a love of the craft to anyone willing to learn.