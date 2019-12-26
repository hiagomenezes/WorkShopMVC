using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WorkShopMVC.Models
{
    public class WorkShopMVCContext : DbContext
    {
        public WorkShopMVCContext (DbContextOptions<WorkShopMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WorkShopMVC.Models.Department> Department { get; set; }
    }
}
