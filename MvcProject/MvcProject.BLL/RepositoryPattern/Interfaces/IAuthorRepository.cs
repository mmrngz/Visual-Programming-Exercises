using MvcProject.DAL.Dto;
using MvcProject.MODEL.Models;
using System.Collections.Generic;

namespace MvcProject.BLL.RepositoryPattern.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        public List<AuthorDto> GetAuthorDtos();
    }
}
