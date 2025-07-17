using CatFacts.DTOs;

namespace CatFacts.Services;

public class CatFileService : ICatFileService
{
    private const string FileName = "catfacts.txt";
    
    public async Task SaveToTxtFile(Fact fact)
    {
        var content = $"fact: {fact.Description} (length: {fact.Length}){Environment.NewLine}";
        await File.AppendAllTextAsync(GetFilePath(), content);
    }
    
    private string GetFilePath()
    {
        var dir = AppContext.BaseDirectory;
        for (var i = 0; i < 4; i++)
        {
            dir = Path.GetDirectoryName(dir)!;
        }
        return Path.Combine(dir, FileName);
    }
}