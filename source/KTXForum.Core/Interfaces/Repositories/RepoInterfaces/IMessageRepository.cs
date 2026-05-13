using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Forum;

namespace KTXForum.Core.Interfaces
{
    public interface IMessageRepository
    {
        List<Message> GetAll();

        Message GetById(int id);

        void Add(Message message);

        void Update(Message message);

        void Delete(int id);
    }
}