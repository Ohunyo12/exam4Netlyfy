using smartwallet1.web.Data.Entities;

namespace smartwallet1.web.Data.Repository.Interface
{
    public interface ILanguageRepository
    {
        Task<IEnumerable<Language>> Get(string filter);

        Task<Language> Get(int id);

        Task<int> Add(Language language); 
        
        Task Update(Language language);

        Task Delete(int id);


    }
}
