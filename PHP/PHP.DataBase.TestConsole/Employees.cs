using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHP.Database.Classes;
using PHP.Database;
using PHP.Database.Classes;
using System.Text.Json;

namespace PHP.DataBase.TestConsole
{
    class Employees
    {
        private readonly PHPRepo _phpRepo;
        public Employees(PHPRepo phpRepo)
        {
            _phpRepo = phpRepo;
        }
        public void Intialise()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("0 : return");
                Console.WriteLine("1 : Add Employee ");
                Console.WriteLine("2 : List Employee ");
                Console.WriteLine("3 : Delete Employee ");

                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "0":
                        cont = false;
                        break;
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        ListEmployees();
                        break;
                    default:
                        Console.WriteLine("select valid input");
                        break;
                }

            }
        }
        public void AddEmployee()
        {
            Console.WriteLine("new Employee entry");
            Console.WriteLine("Employee Name : ");
            string userName = Console.ReadLine();
            Console.WriteLine("Employee Password : ");
            string password = Console.ReadLine();
            _phpRepo.AddEmployee(userName,password);
        }
        public void ListEmployees()
        {
            Console.WriteLine("Avaliable Employees : ");
            string Employeelist = JsonSerializer.Serialize( _phpRepo.GetEmployees());
            Console.WriteLine(Employeelist);
        }
        public void DeleteEmployee()
        {
            Console.WriteLine("Select Employee to delete : ");
            ListEmployees();
            int id = int.Parse(Console.ReadLine());
            var EmployeeToDelete = _phpRepo.GetEmployeeById(id);
            _phpRepo.DeleteEmployee(EmployeeToDelete);

        }
    }
}
