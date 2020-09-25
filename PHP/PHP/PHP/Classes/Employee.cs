using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace PHP.Database.Classes
{
    public class Employee
    {
        public Employee() // Parameterless constructor for entity framework 
        {

        }
        public Employee(string employeeName, string password)
        {
            Employee_Name = employeeName;
            Employee_Password = ComputeSha256Hash(password);
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Password { get; set; }
        public static string ComputeSha256Hash(string rawData) // Passwords should never be stored as plane text
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }

}
