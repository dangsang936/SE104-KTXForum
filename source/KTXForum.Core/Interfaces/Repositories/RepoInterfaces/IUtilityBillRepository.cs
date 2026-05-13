using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Billing;

namespace KTXForum.Core.Interfaces
{
    public interface IUtilityBillRepository
    {
        List<Utility_Bill> GetAll();

        Utility_Bill GetById(int id);

        void Add(Utility_Bill utilityBill);

        void Update(Utility_Bill utilityBill);

        void Delete(int id);
    }
}