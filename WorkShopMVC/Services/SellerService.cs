using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShopMVC.Data;
using WorkShopMVC.Models;
using Microsoft.EntityFrameworkCore;
using WorkShopMVC.Services.Exception;

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

        public void Update (Seller obj)
        {
            if(!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException e)
            {

                throw new DbConcurrencyException(e.Message);
            }
          
        }
    }
}
