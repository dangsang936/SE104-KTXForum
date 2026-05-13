using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.User;

namespace KTXForum.Core.Interfaces
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetAll();

        Vehicle GetById(int id);

        void Add(Vehicle vehicle);

        void Update(Vehicle vehicle);

        void Delete(int id);
    }
}