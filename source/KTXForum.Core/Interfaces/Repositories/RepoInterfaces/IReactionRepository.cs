using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Forum;

namespace KTXForum.Core.Interfaces
{
    public interface IReactionRepository
    {
        List<Reaction> GetAll();

        Reaction GetById(int id);

        void Add(Reaction reaction);

        void Update(Reaction reaction);

        void Delete(int id);
    }
}