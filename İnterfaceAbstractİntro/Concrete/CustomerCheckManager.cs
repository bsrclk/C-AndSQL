using İnterfaceAbstractİntro.Abstract;
using İnterfaceAbstractİntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace İnterfaceAbstractİntro.Concrete
{//Genel bir operasyon yaptık staburcksa hiçbir şekilde bağlı değil
    class CustomerCheckManager : ICustomerCheckService
    {//void dönebilirdik ama bool da dönebiliriz
        //return true doğrulanmış dedik
        public bool  CheclIfRealPerson(Customer customer)
        {
            //return true; merninsi buraya bağlicaz
            //MerninsServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
            //Bu üstteki en kötü bağlama şekillerinden biridir
            //bu şekilde yaparsak mernins çalışmıyor kod da çalışmıyor bu böyle yapılmaz
            //adaepters diye bir klasör oluşturduk
            return true;
        
        }

       
    }
}
