using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WorkShopMVC.Models
{
    public class Seller
    {

        public int Id { get; set; }

        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Birth date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Base Salary")]
        [DataType(DataType.Currency)]
        //[DisplayFormat(DataFormatString = "{0:f2}")]
        public double BaseSalary { get; set; }
        public Department department { get; set; }
        public ICollection<SelesRecord> seles { get; set; } = new List<SelesRecord>();
        public int DepartmentId { get; set; }
        public Seller()
        {
        }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            
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
