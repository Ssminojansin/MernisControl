using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;


 class Program
{
     static void Main(string[] args)
    {





        BaseCustomerManager customerManager = new StarbuckCustomerManager(new MernisServiceAdapter());
       customerManager.Save(new Customer {DateOfBirth = new DateTime(1994 , 08,10),FirstName="Coskun",LastName="Temenni",NationalityId="20428361118" });
        
    }

    
   
}