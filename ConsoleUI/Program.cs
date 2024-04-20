
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetAllByUnitPrice(100,400))
{
    Console.WriteLine(product.ProductName);
}

Console.ReadLine();