# TRCsharp

This is where different C# (.NET) programs can be created and modified for practice purposes

To create a new program set the command line to /workspaces/TRCsharp/Programs using cd command in the terminal

With that active use : dotnet new console -n "New Program Name" -f Net7.0 --use-program-main

Next copy the created path from the navigator and again using cd \ make new program the current directory

from there a simple dotnet run ; will verify that the program has been created correctly by displaying "hello world"

to add csv & json add: 

<ItemGroup>
    <PackageReference Include="Newtonsoft.Json" Version="13.0.1" />
    <PackageReference Include="CsvHelper" Version="27.1.1" />
</ItemGroup>

to .csproj and then dotnet restore. include:

using System.IO;
using Newtonsoft.Json;
using CsvHelper;
using CsvHelper.Configuration;

to the top of the program