
using MvcProject.MODEL.Models;
using System.Collections.Generic;

namespace MvcProject.BLL.RepositoryPattern.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        public List<Book> GetBooks();
    }
}
