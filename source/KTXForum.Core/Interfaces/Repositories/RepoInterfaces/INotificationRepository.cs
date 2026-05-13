using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.User;

namespace KTXForum.Core.Interfaces
{
    public interface INotificationRepository
    {
        List<Notification> GetAll();

        Notification GetById(int id);

        void Add(Notification notification);

        void Update(Notification notification);

        void Delete(int id);
    }
}