using İnterfaceAbstractİntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace İnterfaceAbstractİntro.Abstract
{
    public interface ICustomerCheckService
    {//bir classın içerisine bunu yazmak yerine interface
     //içine yazdık, çünkü nero da ilerde isteyebilir
        bool CheclIfRealPerson(Customer customer);
        
      
        
    }
}
