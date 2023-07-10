using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
    }

    public class ProductCRUD
    {
        private List<Product> products;

        public ProductCRUD()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product prod)
        {
            products.Add(prod);
        }

        public List<Product> GetProduct()
        {
            return products;
        }

        public void UpdateProduct(Product prod)
        { 
            foreach(Product product in products)
            {
                if(product.Id == prod.Id)
                {
                    product.Name= prod.Name;
                    product.Price= prod.Price;
                    break;
                }
            }
        }

        public void DeleteProduct(int id)
        {
            foreach(Product product in products)
            {
                if( product.Id == id)
                {
                    products.Remove(product);
                    break;
                }
            }
        }
    }
}
