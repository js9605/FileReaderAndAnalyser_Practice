using System;
using System.Collections.Generic;
using System.Linq;

public class ContentAnalyzer
{
    public int CountWords(string content)
    {
        string[] words = content.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    public int CountCharacters(string content)
    {
        return content.Length;
    }

    public List<string> MostCommonWords(string content, int numberOfWords)
    {
        string[] words = content.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        var wordGroups = words.GroupBy(word => word.ToLower())
                             .OrderByDescending(group => group.Count())
                             .Take(numberOfWords);

        List<string> mostCommonWords = wordGroups.Select(group => group.Key).ToList();

        return mostCommonWords;
    }
}
