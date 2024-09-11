using Library.Models;
using System.Collections.Generic;

namespace Library.RepositoryPattern.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        public List<Book> GetBooks();
    }
}
