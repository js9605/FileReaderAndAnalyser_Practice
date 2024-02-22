using System;
using System.IO;

public class FileReader
{
    public string readFileContent(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                return content;
            }
            else
            {
                return "File not found";
            }
        }
        catch(Exception ex)
        {
            return $"Error while reading file: {ex.Message}";
        }
    }
}