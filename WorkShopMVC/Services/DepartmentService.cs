using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShopMVC.Models;

namespace WorkShopMVC.Services
{
    public class DepartmentService
    {
        private readonly WorkShopMVCContext _context;
        public DepartmentService(WorkShopMVCContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
