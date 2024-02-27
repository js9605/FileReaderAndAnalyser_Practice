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


        string filePath = "yourfile.txt";

        FileReader fileReader = new FileReader();
        ContentAnalyzer contentAnalyzer = new ContentAnalyzer();

        string fileContent = fileReader.ReadFileContent(filePath);

        int wordCount = contentAnalyzer.CountWords(fileContent);
        int characterCount = contentAnalyzer.CountCharacters(fileContent);
        List<string> mostCommonWords = contentAnalyzer.MostCommonWords(fileContent, numberOfWords: 5);

        Console.WriteLine("Analysis Results:");
        Console.WriteLine($"Total Words: {wordCount}");
        Console.WriteLine($"Total Characters: {characterCount}");
        Console.WriteLine("Most Common Words:");
        foreach (string word in mostCommonWords)
        {
            Console.WriteLine($"- {word}");
        }
    }

}