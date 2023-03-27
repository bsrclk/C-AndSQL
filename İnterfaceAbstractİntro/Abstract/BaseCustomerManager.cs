using İnterfaceAbstractİntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace İnterfaceAbstractİntro.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {//abstract sınıfının içinde içi dolu metot yapabiliyoruz 
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db" + customer.FirstName);
        }//ortak operasyon
    }
}
