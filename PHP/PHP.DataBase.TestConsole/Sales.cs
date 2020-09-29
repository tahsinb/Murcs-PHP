using PHP.Database;
using PHP.Database.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace PHP.DataBase.TestConsole
{
    class Sales
    {
        
        private readonly PHPRepo _phpRepo;
        public Sales(PHPRepo phpRepo)
        {
   
            _phpRepo = phpRepo;
        }
        public void Intialise()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("0 : return");
                Console.WriteLine("1 : Add Sale ");
                Console.WriteLine("2 : List Sale ");
                Console.WriteLine("3 : Delete Sale ");

                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "0":
                        cont = false;
                        break;
                    case "1":
                        AddSale();
                        break;
                    case "2":
                        ListSales();
                        break;
                    default:
                        Console.WriteLine("select valid input");
                        break;
                }

            }
        }
        public void AddSale()
        {
            Sale sale = new Sale();
            bool addProduct = true;
            sale.Sale_Date = DateTime.Now;
            Console.WriteLine("new Sale entry");
            Console.WriteLine("AddProducts from list or enter to exit  :");
            Console.WriteLine("Avaliable Products : ");
            Console.WriteLine(JsonConvert.SerializeObject (_phpRepo.GetProducts()));
            double cost = 0;
            while (addProduct) 
            {
                string input = Console.ReadLine();
                if(string.IsNullOrEmpty(input))
                {
                    addProduct = false;
                    break;
                }
                Product product = _phpRepo.GetProductbyId( int.Parse(input));
                
                if(!(product == default))
                {
                    ProductSale productSale = new ProductSale();
                    productSale.Product = product;
                    cost = cost + product.Price;
                    sale.ProductSales.Add(productSale);
                }
                else
                {
                    Console.WriteLine("invalid entry");
                }
            
            }
            sale.Total_Cost = cost;
            var emplopyees = _phpRepo.GetEmployees();
            if (emplopyees.Count > 0)
            {
                Console.WriteLine("select employee");
                string listString = JsonConvert.SerializeObject(emplopyees);
                Console.WriteLine(listString);
                int selection = int.Parse(Console.ReadLine());
                Employee employee = emplopyees.Where(e => e.EmployeeId == selection).FirstOrDefault();
                if (emplopyees != default) sale.Employee = employee;
            }
            Console.WriteLine("Customer Name");
            sale.Customer_Name = Console.ReadLine();
            _phpRepo.AddSalesRecord(sale);
        }
        public void ListSales()
        {
            Console.WriteLine("Avaliable Sales : ");
            var sales =_phpRepo.GetSales();
            List<string> outlist = new List<string>();
            foreach (Sale sale in sales) {
                outlist.Add($"Sale id : {sale.SaleId}");
                outlist.Add($"  Customer Name  :{sale.Customer_Name}");
                if (sale.Employee != null && string.IsNullOrEmpty(sale.Employee.Employee_Name))outlist.Add($"  Employee  Name  : {sale.Employee.Employee_Name}");
                outlist.Add($"  Sale Date {sale.Sale_Date}");
                outlist.Add($"  Items :");
                foreach (var item in sale.ProductSales)
                {
                    if(item != null) outlist.Add($"     item name  : {item.Product.Product_Name}    Product Price {item.Product.Price}");
                }
            }
            string Salelist = string.Join(Environment.NewLine,outlist);
            Console.WriteLine(Salelist);
        }
        public void DeleteSale()
        {
            Console.WriteLine("Select Sale to delete : ");
            ListSales();
            int id = int.Parse(Console.ReadLine());
            var SaleToDelete = _phpRepo.GetSaleById(id);
            _phpRepo.RemoveSales(SaleToDelete);

        }
    }
}
