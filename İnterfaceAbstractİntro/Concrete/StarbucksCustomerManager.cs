using İnterfaceAbstractİntro.Abstract;
using İnterfaceAbstractİntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace İnterfaceAbstractİntro.Concrete
{
    public class StarbucksCustomerManager :BaseCustomerManager// ICustomerService
    {
        //public void Save(Customer customer)
        //{
        //    throw new NotImplementedException();
        //} burada BaseBaseCustomerManager ı miras aldı base de ICustomerManager ın ortak kodları bulunuyor ve 
        //referans olarak kullanabilcek

        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
           // CheckIfRealPerson(customer);

            if(_customerCheckService.CheclIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            { 
            throw new Exception("Not a vaild person");

            }
        }
        
        
        
        //eğer if doğruşanmış ise save 
        //eğer doğrulanmamışsa doğrulanmış kişii değil
     
        //private void CheckIfRealPerson(Customer customer)
        //{//mersise direk burdan bağlanabilirim ama yarın nero da isterse
            //interface abilitiy olayı devreye giriyor 
            
        //}





    }
}
