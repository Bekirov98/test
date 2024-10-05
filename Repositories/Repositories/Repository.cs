using Domain.Common;
using Repositories.DataContext;
using Repositories.Repositories.Interfaces;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    public void Create(T entity)
    {
        AppDbContext<T>.Datas.Add(entity);
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}