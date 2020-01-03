using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShopMVC.Data;
using WorkShopMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace WorkShopMVC.Services
{
    public class SellerService
    {
        private readonly WorkShopMVCContext _context;
        public SellerService(WorkShopMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Inset(Seller obj)
        {
            //obj.department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int Id)
        {
            return _context.Seller.Include(obj => obj.department).FirstOrDefault(obj => obj.Id == Id);
        }

        public void Remove(int Id)
        {
            var obj = _context.Seller.Find(Id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
