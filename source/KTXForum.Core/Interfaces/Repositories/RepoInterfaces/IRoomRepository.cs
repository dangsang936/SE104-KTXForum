using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Dormitory;

namespace KTXForum.Core.Interfaces
{
    public interface IRoomRepository
    {
        List<Room> GetAll();

        Room GetById(int id);

        void Add(Room room);

        void Update(Room room);

        void Delete(int id);
    }
}