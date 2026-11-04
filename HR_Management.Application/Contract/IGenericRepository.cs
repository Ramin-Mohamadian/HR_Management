namespace HR_Management.Application.Contract;

public interface IGenericRepository<T> where T : class
{
    Task<T> Get(int Id);
    Task<IEnumerable<T>> GetAll();
    Task<T> Add(T entity);
    Task Update(T entity);
    Task Delete(T entity);
}