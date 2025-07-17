using CatFacts.DTOs;

namespace CatFacts;

public interface ICatFactService
{ 
    Task<Fact> GetCatFactAsync();
}