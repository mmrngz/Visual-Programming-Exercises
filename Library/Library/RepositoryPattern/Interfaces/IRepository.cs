using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library.RepositoryPattern.Interfaces
{
    public interface IRepository<T> where T :BaseEntity
    {
        List<T> GetAll();
        List<T> GetActives();
        T GetById(int id);
        void Add(T item);
        void Update(T item);    
        void Delete(T item);    
        void SpeacialDelete(T item);
        List<T> GetByFilter(Expression<Func<T,bool>> exp);
        int Count();
        bool Any(Expression<Func<T,bool>> exp);
        List<T> SelectActivesByLimit(int count);
        void SpeacialDelete(int id);
        void Delete(int id);
        T Default(Expression<Func<T,bool>> exp);
        AppUser Default(AppUser user);
    }
}
