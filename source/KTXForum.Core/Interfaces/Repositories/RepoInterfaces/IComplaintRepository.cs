using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Complaint;

namespace KTXForum.Core.Interfaces
{
    public interface IComplaintRepository
    {
        List<Complaint> GetAll();

        Complaint GetById(int id);

        void Add(Complaint complaint);

        void Update(Complaint complaint);

        void Delete(int id);
    }
}