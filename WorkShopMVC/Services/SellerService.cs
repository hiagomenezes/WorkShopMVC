using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShopMVC.Data;
using WorkShopMVC.Models;

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
            obj.department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
