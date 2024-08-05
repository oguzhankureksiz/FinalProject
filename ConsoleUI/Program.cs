using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
var result = customerManager.GetAll();

foreach (var item in result.Data)
{
    Console.WriteLine(item.City);
}