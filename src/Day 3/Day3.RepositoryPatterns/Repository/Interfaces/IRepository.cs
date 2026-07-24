using System;

namespace Day3.RepositoryPatterns.Repository.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T? GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(int id);
    }
}
