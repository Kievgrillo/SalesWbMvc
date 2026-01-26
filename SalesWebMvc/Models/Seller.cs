using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();


        public Seller()
        {
        }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord salesrec)
        {
            Sales.Add(salesrec);
        }

        public void RemoveSales(SalesRecord salesrec)
        {
            Sales.Remove(salesrec);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(salesrec => salesrec.DateTime >= initial && salesrec.DateTime <= final).Sum(salesrec => salesrec.Amount);
        }
    }
}
