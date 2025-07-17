using CatFacts.DTOs;

namespace CatFacts;

public interface ICatFileService
{
    Task SaveToTxtFile(Fact fact);
}