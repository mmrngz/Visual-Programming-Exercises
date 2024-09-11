
using MvcProject.BLL.RepositoryPattern.Base;
using MvcProject.BLL.RepositoryPattern.Interfaces;
using MvcProject.DAL.Context;
using MvcProject.DAL.Dto;
using MvcProject.MODEL.Models;
using System.Collections.Generic;
using System.Linq;

namespace MvcProject.MODEL.RepositoryPattern.Concrete
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(MyDbContext dbContext) : base(dbContext)
        {
        }

        public List<AuthorDto> GetAuthorDtos()
        {
            return table.Where(a => a.Status != Enums.DataStatus.Deleted).Select(x => new AuthorDto()
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                 
            }).ToList();
        }

       
    }
}
