namespace CatFacts.Application;

public class CatApp
{
    private readonly ICatFactService _catFactService;
    private readonly ICatFileService _catFileService;

    public CatApp(ICatFactService catFactService, ICatFileService catFileService)
    {
        _catFactService = catFactService ?? throw new ArgumentNullException(nameof(catFactService));
        _catFileService = catFileService ?? throw new ArgumentNullException(nameof(catFileService));;
    }

    public async Task RunAsync()
    {
        try
        {
            var fact = await _catFactService.GetCatFactAsync();
            Console.WriteLine($"Fact: {fact.Description} (Length: {fact.Length})");
            await _catFileService.SaveToTxtFile(fact);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
    }
}