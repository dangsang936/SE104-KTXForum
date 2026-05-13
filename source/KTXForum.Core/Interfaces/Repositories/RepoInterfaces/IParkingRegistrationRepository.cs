using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Dormitory;

namespace KTXForum.Core.Interfaces
{
    public interface IParkingRegistrationRepository
    {
        List<ParkingRegistration> GetAll();

        ParkingRegistration GetById(int id);

        void Add(ParkingRegistration registration);

        void Update(ParkingRegistration registration);

        void Delete(int id);
    }
}