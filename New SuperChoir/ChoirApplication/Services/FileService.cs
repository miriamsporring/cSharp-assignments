using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace ChoirApplication.Services;


//nedan finns listan/filen
public class FileService 
{
    //visar var filen ligger lokalt på datorn
    private static readonly string filePath = @"c:\Code\members.json";

    //SaveToFile - sparar och skriver in till filen
    public static void SaveToFile(string content) 

    {
        using var sw = new StreamWriter(filePath);
        sw.WriteLine(content);
    }

    //ReadFromFile - läser från filen
    //funktionen i ReadFromFile behövs för att enhetstestet ska fungera
    public static string ReadFromFile(string filePath)  
                                                        
    {
        try
        {
            //om filen existerar, läs in från filen
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


