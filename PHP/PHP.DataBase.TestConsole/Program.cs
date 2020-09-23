using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHP.Database;
using Microsoft.EntityFrameworkCore;

namespace PHP.DataBase.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AppSettings appSettings = new AppSettings()
            {
                URL = "database-1.cwocrrmlsxcx.us-east-1.rds.amazonaws.com",
                Port = "5432",
                UserName = " masterUser",
                Password = "7YhStMgcLH2VbZLtNNtw",
                DatabaseName = "test1"
            };
            PHPConext pHPConext = new PHPConext(appSettings);
            //try
            //{
            //    pHPConext.Database.EnsureCreated();
            //    pHPConext.SaveChanges();
            //    Console.WriteLine("DB Created");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Console.ReadLine();
            PHPRepo pHPRepo = new PHPRepo(pHPConext);
            Employees employees = new Employees(pHPRepo);
            Products products = new Products(pHPRepo);
            Sales sales = new Sales(pHPRepo);
            while (true) {
                Console.WriteLine("Select Page  : ");
                Console.WriteLine("1 : Employees ");
                Console.WriteLine("2 : Products ");
                Console.WriteLine("3 : Sales");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        employees.Intialise();
                        break;
                    case "2":
                        products.Intialise();
                        break;
                    case "3":
                        sales.Intialise();
                        break;
                    default:
                        Console.WriteLine("please give valid input");
                        break;
                }
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
        }
        
    }
    public class AppSettings : IDatabaseAppSettings
    {
        public string URL { get;set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DatabaseName { get; set; }
    }
}
