using System;
using System.Collections.Generic;
using System.Text;
using KTXForum.Core.Models.Billing;

namespace KTXForum.Core.Interfaces
{
    public interface IPaymentRepository
    {
        List<Payment> GetAll();

        Payment GetById(int id);

        void Add(Payment payment);

        void Update(Payment payment);

        void Delete(int id);
    }
}