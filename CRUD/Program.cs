using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductCRUD crud = new ProductCRUD();
            int option = 0;
            do
            {
                Console.WriteLine("1.Add Product Details");
                Console.WriteLine("2.Update Product Details");
                Console.WriteLine("3.Delete Product Details");
                Console.WriteLine("4.Display Product Datails");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Product p = new Product();
                        Console.WriteLine("Enter Product Id");
                        p.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name");
                        p.Name = Console.ReadLine();
                        Console.WriteLine("Enter Product Price");
                        p.Price = Convert.ToDouble(Console.ReadLine());

                        crud.AddProduct(p);
                        break;

                    case 2:
                        Product p1 = new Product();
                        Console.WriteLine("Enter Product Id");
                        p1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name");
                        p1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Product Price");
                        p1.Price = Convert.ToDouble(Console.ReadLine());

                        crud.UpdateProduct(p1);
                        break;

                    case 3:

                        Console.WriteLine("Enter Id to Delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteProduct(id);
                        break;

                    case 4:
                        List<Product> list = crud.GetProduct();
                        foreach (Product P in list)
                        {
                            Console.WriteLine($"{P.Id}-{P.Name}-{P.Price}");
                        }
                        break;
                
                }
                Console.WriteLine("Enter 1 to Continue");
                option=Convert.ToInt32(Console.ReadLine());
            } while (option == 1);
        }
    }
}
