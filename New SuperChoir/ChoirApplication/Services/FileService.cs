namespace ChoirApplication.Services;

internal class FileService
{
    public void SaveToFile(string filePath, string content)
    {
        using var sw = new StreamWriter(filePath);
        sw.Write(content);
    }
    
}
