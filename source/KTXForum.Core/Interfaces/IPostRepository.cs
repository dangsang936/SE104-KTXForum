using KTXForum.Core.Models.Forum;
using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Interfaces
{
    public interface IPostRepository
    {
        List<Post> GetAll();

        Post GetById(int id);

        void Add(Post post);

        void Update(Post post);

        void Delete(int id);
    }
}
