using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcCRM.Models
{
    public class MvcCRMContext : DbContext
    {
        public MvcCRMContext (DbContextOptions<MvcCRMContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCRM.Models.User> User { get; set; }
    }
}
