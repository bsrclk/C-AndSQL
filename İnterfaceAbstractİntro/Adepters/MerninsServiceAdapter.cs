using İnterfaceAbstractİntro.Abstract;
using İnterfaceAbstractİntro.Entities;
using MerninsServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceAbstractİntro.Adepters
{
    public class MerninsServiceAdapter : ICustomerCheckService
    {
        public bool CheclIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt32(customer.NatioanlityId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}