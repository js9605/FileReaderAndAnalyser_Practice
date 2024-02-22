using System;

class Program
{
    public Program(string filePath)
    {
        FileReader fileReader = new FileReader();
        string fileContent = fileReader.readFileContent(filePath);
        System.Console.WriteLine($"File content: \n{fileContent}");
    }

    static void Main()
    {
        Program program = new Program("exampleFile.txt");
    }

}