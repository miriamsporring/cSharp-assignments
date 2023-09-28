

using ChoirApplication.Models;
using Newtonsoft.Json;

namespace ChoirApplication.Services;

internal class FileService //här finns listan/filen
{
    private static readonly string filePath = @"c:\Code\members.json";
    public void SaveToFile(string filePath, string content)

    {
        using var sw = new StreamWriter(filePath);
        sw.Write(content);
    }

    public static string ReadFromFile()
    {
        if (File.Exists(filePath))
        {
            using var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }
        return null!;
    }

}
