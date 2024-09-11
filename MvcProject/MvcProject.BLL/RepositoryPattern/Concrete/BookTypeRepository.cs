using MvcProject.BLL.RepositoryPattern.Base;
using MvcProject.BLL.RepositoryPattern.Interfaces;
using MvcProject.DAL.Context;
using MvcProject.DAL.Dto;
using MvcProject.MODEL.Models;
using System.Collections.Generic;
using System.Linq;

namespace MvcProject.BLL.RepositoryPattern.Concrete
{
    public class BookTypeRepository : Repository<BookType>, IBookTypeRepository
    {
        public BookTypeRepository(MyDbContext dbContext) : base(dbContext)
        {
        }

        public List<BookTypeDto> GetsBookTypeDtos()
        {
           return table.Where(b => b.Status != MvcProject.MODEL.Enums.DataStatus.Deleted).Select(x => new BookTypeDto()
           {
               ID = x.ID,
               Name = x.Name,
           }).ToList();
            
        }
    }
}
