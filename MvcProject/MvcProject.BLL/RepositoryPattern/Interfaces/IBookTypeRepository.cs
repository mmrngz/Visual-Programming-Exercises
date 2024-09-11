using MvcProject.DAL.Dto;
using MvcProject.MODEL.Models;
using System.Collections.Generic;

namespace MvcProject.BLL.RepositoryPattern.Interfaces
{
    public interface IBookTypeRepository :IRepository<BookType>
    {
        public List<BookTypeDto> GetsBookTypeDtos();
    }
}
