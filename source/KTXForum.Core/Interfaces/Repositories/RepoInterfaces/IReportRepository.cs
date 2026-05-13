using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Forum;

namespace KTXForum.Core.Interfaces
{
    public interface IReportRepository
    {
        List<Report> GetAll();

        Report GetById(int id);

        void Add(Report report);

        void Update(Report report);

        void Delete(int id);
    }
}