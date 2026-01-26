using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(DateTime dateTime, double amount, SalesStatus status, Seller seller)
        {
            DateTime = dateTime;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
