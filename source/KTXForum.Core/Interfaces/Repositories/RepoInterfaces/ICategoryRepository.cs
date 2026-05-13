using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Forum;

namespace KTXForum.Core.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();

        Category GetById(int id);

        void Add(Category category);

        void Update(Category category);

        void Delete(int id);
    }
}