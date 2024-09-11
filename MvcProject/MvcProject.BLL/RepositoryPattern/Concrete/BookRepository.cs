
using EnumsNET;
using Microsoft.EntityFrameworkCore;
using MvcProject.BLL.RepositoryPattern.Base;
using MvcProject.BLL.RepositoryPattern.Interfaces;
using MvcProject.DAL.Context;
using MvcProject.MODEL.Models;
using System.Collections.Generic;
using System.Linq;

namespace MvcProject.BLL.RepositoryPattern.Concrete
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(MyDbContext dbContext) : base(dbContext)
        {
        }

        public List<Book> GetBooks()
        {
            return table.Where(x => x.Status != MODEL.Enums.DataStatus.Deleted).Include(a => a.BookType).Include(a => a.Author).ToList();
        }
    }
}
