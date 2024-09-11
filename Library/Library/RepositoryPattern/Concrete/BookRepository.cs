using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Base;
using Library.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Library.RepositoryPattern.Concrete
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(MyDbContext dbContext) : base(dbContext)
        {
        }

        public List<Book> GetBooks()
        {
            return table.Where(x => x.Status != Enums.DataStatus.Deleted).Include(a => a.BookType).Include(a => a.Author).ToList();
        }
    }
}
