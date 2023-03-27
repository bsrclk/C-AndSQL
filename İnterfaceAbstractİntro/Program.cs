using İnterfaceAbstractİntro.Abstract;
using İnterfaceAbstractİntro.Adepters;
using İnterfaceAbstractİntro.Concrete;
using İnterfaceAbstractİntro.Entities;
using System;

namespace İnterfaceAbstractİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract classlar newlenemez
            //BaseCustomerManager customerManager = new BaseCustomerManager();
            BaseCustomerManager customerManager = new NeroCustomerManager();
            //BaseCustomerManager customerManager1 = new StarbucksCustomerManager();
            //customerManager.Save(new Customer { DateOfBirth = new DateTime(1985,1,6),FirstName ="POYRAZ",LastName="Çolak",NatioanlityId="128762222"});

            BaseCustomerManager customerManager1 = new StarbucksCustomerManager(new MerninsServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "POYRAZ", LastName = "Çolak", NatioanlityId = "128762222" });


        }
    }








}
