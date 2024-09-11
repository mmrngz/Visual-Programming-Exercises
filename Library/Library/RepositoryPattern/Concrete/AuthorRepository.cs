using Library.Context;
using Library.Dto;
using Library.Models;
using Library.RepositoryPattern.Base;
using Library.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Library.RepositoryPattern.Concrete
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
