using İnterfaceAbstractİntro.Abstract;
using System;

namespace İnterfaceAbstractİntro.Entities

{
    public class Customer: IEntity//somut sınıflar eğer çıplak kalıyorsa herhangi bir implmentasyon yada interface almıyorsa
                                  //ilerde sıkıntı çıkarabilir.sırf bu tip kurallar için buraya IEntity adında interface 
                                  //oluştururuz ve genellikle bunun veri tabanı nesnesi olduğunu gösteririz
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NatioanlityId { get; set; }
    }











}
