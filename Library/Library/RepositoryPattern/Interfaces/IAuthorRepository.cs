using Library.Dto;
using Library.Models;
using System.Collections.Generic;

namespace Library.RepositoryPattern.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        public List<AuthorDto> GetAuthorDtos();
    }
}
