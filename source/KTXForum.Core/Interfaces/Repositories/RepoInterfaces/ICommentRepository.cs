using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Forum;

namespace KTXForum.Core.Interfaces
{
    public interface ICommentRepository
    {
        List<Comment> GetAll();

        Comment GetById(int id);

        void Add(Comment comment);

        void Update(Comment comment);

        void Delete(int id);
    }
}