using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WorkShopMVC.Models
{
    public class Seller
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department department { get; set; }
        public ICollection<SelesRecord> seles { get; set; } = new List<SelesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            this.department = department;
        }

        public void AddSeller(SelesRecord sr)
        {
            seles.Add(sr);

        }

        public void RemoveSeles(SelesRecord sr)
        {
            seles.Remove(sr);
        }

        public double TotalSeles(DateTime Inicial, DateTime Final)
        {
            return seles.Where(sr => sr.Date >= Inicial && sr.Date <= Final).Sum(sr => sr.Amount);
        }
    }
}
