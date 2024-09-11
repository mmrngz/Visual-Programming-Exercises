using ShortProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShortProject.RepositoryPattern
{
    public class UserRepository

    {
        private List<User> users;

        public UserRepository()
        {
            users = new List<User>();
        }

        public void Add(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
        }

        public User GetById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }


    }
}
