using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace ChoirApplication.Services;


public class FileService //här finns listan/filen
{
  
    private static readonly string filePath = @"c:\Code\members.json";
    public static void SaveToFile(string content)

    {
        using var sw = new StreamWriter(filePath);
        sw.WriteLine(content);
    }

    public static string ReadFromFile(string filePath) //Behöver ha en funktion i testet för att det ska bli grönt

    {
        try
        {

            if (File.Exists(filePath))
            {
                using var sr = new StreamReader(filePath);
                return sr.ReadToEnd();
            }
           
        }
        catch { }

        return null!;

    }


}


