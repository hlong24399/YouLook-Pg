using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YouLook_Official.Models;

namespace YouLook_Official.Data
{
    public class RoleContext : DbContext
    {
        public RoleContext(DbContextOptions options) : base(options)
        {
        }

        //DbSet corresponds to a database table.
        public DbSet<UserRole> UserRoles { get; set; }
    }
}