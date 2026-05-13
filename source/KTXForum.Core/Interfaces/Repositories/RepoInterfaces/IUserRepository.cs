using KTXForum.Core.Models.User;
using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models;

namespace KTXForum.Core.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();

        User GetById(int id);

        void Add(User user);

        void Update(User user);

        void Delete(int id);
    }
}