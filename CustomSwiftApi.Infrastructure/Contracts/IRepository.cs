namespace CustomSwiftApi.Infrastructure.Contracts
{
    public interface IRepository<T> where T : class
    {
        Task<bool> InsertAsync(T entity);
    }
}
