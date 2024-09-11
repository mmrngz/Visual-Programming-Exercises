using Library.Context;
using Library.Dto;
using Library.Models;
using Library.RepositoryPattern.Base;
using Library.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Library.RepositoryPattern.Concrete
{
    public class BookTypeRepository : Repository<BookType>, IBookTypeRepository
    {
        public BookTypeRepository(MyDbContext dbContext) : base(dbContext)
        {
        }

        public List<BookTypeDto> GetsBookTypeDtos()
        {
           return table.Where(b => b.Status != Enums.DataStatus.Deleted).Select(x => new BookTypeDto()
           {
               ID = x.ID,
               Name = x.Name,
           }).ToList();
            
        }
    }
}
