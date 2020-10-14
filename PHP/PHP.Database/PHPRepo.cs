using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PHP.Database.Classes;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace PHP.Database
{
    public class PHPRepo
    {
        private readonly PHPConext _pHPContext;
        public PHPRepo(PHPConext pHPConext)
        {
            _pHPContext = pHPConext;
        }
        #region sales 
        public void AddSalesRecord(Sale sale)
        {
            _pHPContext.Sales.Add(sale);
            _pHPContext.SaveChanges();
        }
        public void EditSalesRecord(Sale sale)
        {
            var SaleToEdit = _pHPContext.Sales.Update(sale);
            _pHPContext.SaveChanges();
        }
        public Sale GetSaleById(int id)
        {
            return _pHPContext.Sales.Where(s => s.SaleId == id).FirstOrDefault();
        }
        public List<Sale> GetSales()
        {
            return _pHPContext.Sales.Include(s=>s.ProductSales).ThenInclude(p=>p.Product).ToList();
        }
        public void RemoveSales(Sale sale)
        {
            _pHPContext.Sales.Remove(sale);
            _pHPContext.SaveChanges();
        }
        /// <summary>
        /// Gets Sales between dates "intial date" and "endDate"
        /// </summary>
        /// <param name="initialDate"> the start date </param>
        /// <param name="endDate">the end date </param>
        /// <returns></returns>
        public List<Sale> GetSaleByDate(DateTime initialDate, DateTime endDate)
        {
            return _pHPContext.Sales.Where(s => DateTime.Compare(s.Sale_Date, initialDate) > 0 && DateTime.Compare(s.Sale_Date, endDate) < 0).Include(s => s.ProductSales).ThenInclude(p => p.Product).ToList();
        }
        public int GetMaxSaleId()
        {
            return _pHPContext.Sales.Select(s=>s.SaleId).DefaultIfEmpty(0).Max();
        }
        #endregion

        #region Employees 
        public void AddEmployee(string employeeName,string password)
        {
            Employee employee = new Employee(employeeName, password);
            _pHPContext.Employees.Add(employee);
            _pHPContext.SaveChanges();
        }
        public void EditEmployee(Employee employee)
        {

            var EmployeeToedit = _pHPContext.Employees.Update(employee);
            _pHPContext.SaveChanges();
        }
        public Employee GetEmployeeById(int id)
        {
            return _pHPContext.Employees.Where(e=>e.EmployeeId == id).FirstOrDefault();
        }
        public List<Employee> GetEmployees()
        {
            return _pHPContext.Employees.ToList();
        }
        public bool VerifyPassword(int id, string password)
        {
            string HashedPassword = Employee.ComputeSha256Hash(password);
            Employee employee = _pHPContext.Employees.Where(e=>e.EmployeeId == id).FirstOrDefault();
            if (employee == default) return false;
            return HashedPassword == employee.Employee_Password;

        }
        public void DeleteEmployee(Employee employee)
        {
            _pHPContext.Employees.Remove(employee);
            _pHPContext.SaveChanges();
        }

        #endregion
        #region Products 
        public void AddProductRecord(Product product)
        {
            _pHPContext.Products.Add(product);
            _pHPContext.SaveChanges();
        }
        public void EditProductRecord(Product product)
        {
            var productToEdit = _pHPContext.Products.Update(product);
            _pHPContext.SaveChanges();
        }
        public Product GetProductbyId(int id)
        {
            return _pHPContext.Products.Where(s => s.ProductId == id).FirstOrDefault();
        }
        public void deleteProduct(Product product)
        {
            _pHPContext.Products.Remove(product);
            _pHPContext.SaveChanges();
        }
        public List<Product> GetProducts()
        {
            return _pHPContext.Products.ToList();
        }
        #endregion
    }




}
