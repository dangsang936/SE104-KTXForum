using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Dormitory;

namespace KTXForum.Core.Interfaces
{
    public interface IRoomRegistrationRepository
    {
        List<RoomRegistration> GetAll();

        RoomRegistration GetById(int id);

        void Add(RoomRegistration registration);

        void Update(RoomRegistration registration);

        void Delete(int id);
    }
}