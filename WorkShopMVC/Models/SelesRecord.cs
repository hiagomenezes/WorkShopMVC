using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShopMVC.Models.Enums;

namespace WorkShopMVC.Models
{
    public class SelesRecord
    {
        public int Id  { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller seller { get; set; }

        public SelesRecord()
        {
        }

        public SelesRecord(int integer, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = integer;
            Date = date;
            Amount = amount;
            Status = status;
            this.seller = seller;
        }
    }
}
