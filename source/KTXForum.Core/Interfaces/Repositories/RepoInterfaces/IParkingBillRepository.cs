using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Billing;

namespace KTXForum.Core.Interfaces
{
    public interface IParkingBillRepository
    {
        List<ParkingBill> GetAll();

        ParkingBill GetById(int id);

        void Add(ParkingBill parkingBill);

        void Update(ParkingBill parkingBill);

        void Delete(int id);
    }
}