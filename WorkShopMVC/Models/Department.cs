using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkShopMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department( string name)
        {
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            sellers.Add(seller);
        }

        public double TotalSeles(DateTime inicial, DateTime final)
        {
            return sellers.Sum(sellers => sellers.TotalSeles(inicial, final));
        }
    }
}
