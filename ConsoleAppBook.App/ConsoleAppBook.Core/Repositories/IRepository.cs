using ConsoleApp.Core.Models.Base;

namespace ConsoleApp.Core.Repositories
{
    public interface IRepository<T> where T :  BaseModel
    {
        public Task<T> AddAsync(T model);

        public Task<T> GetAsync(Func<T,bool>expression);

        public Task<List<T>> GetAllAsync();

        public Task Remove(T model);    
    }
}
