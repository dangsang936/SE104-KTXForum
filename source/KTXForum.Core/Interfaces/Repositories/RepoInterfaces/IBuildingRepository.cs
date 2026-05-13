using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Dormitory;

namespace KTXForum.Core.Interfaces
{
    public interface IBuildingRepository
    {
        List<Building> GetAll();

        Building GetById(int id);

        void Add(Building building);

        void Update(Building building);

        void Delete(int id);
    }
}