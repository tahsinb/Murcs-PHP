using PHP.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHP.Database.Classes;
using System.Text.Json;

namespace PHP.DataBase.TestConsole
{
    public class Products
    {
        private readonly PHPRepo _phpRepo;
        public Products(PHPRepo phpRepo)
        {
            _phpRepo = phpRepo;
        }
        public void Intialise()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("0 : return");
                Console.WriteLine("1 : Add Product ");
                Console.WriteLine("2 : List Product ");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "0":
                        cont = false;
                        break;
                    case "1":
                        AddProduct();
                        break;
                    case "2" :
                        ListProducts();
                        break;
                    default :
                        Console.WriteLine("select valid input");
                        break;   
                }
                
            }
        }
        public void AddProduct()
        {
            Console.WriteLine("new product entry");
            Product product = new Product();
            Console.WriteLine("Product Name : ");
            product.Product_Name = Console.ReadLine();
            Console.WriteLine("Product Price : ");
            product.Price = float.Parse(Console.ReadLine());
            Console.WriteLine("initial stock level :");
            product.Stock_Level = int.Parse(Console.ReadLine());
            _phpRepo.AddProductRecord(product);
        }
        public void ListProducts()
        {
            Console.WriteLine("Avaliable products : ");
            string productlist = JsonSerializer.Serialize(_phpRepo.GetProducts());
            Console.WriteLine(productlist);
        }
        public void DeleteProduct()
        {
            Console.WriteLine("Select product to delete : ");
            ListProducts();
            int id = int.Parse(Console.ReadLine());
            var productToDelete = _phpRepo.GetProductbyId(id);
            _phpRepo.deleteProduct(productToDelete);

        }
    }
}
