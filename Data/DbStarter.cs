using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouLook_Official.Models;

namespace YouLook_Official.Data
{
    public class DbStarter
    {
        public static void Initialize(RoleContext context)
        {
            context.Database.EnsureCreated();

            //Check if there is any curernt table
            if (context.UserRoles.Any())
            {
                return;
            }

            var users = new UserRole[]
            {
                new UserRole{Name="Long",Role=1},
                new UserRole{Name="Kelly",Role=2},
            };

            foreach (UserRole u in users)
            {
                context.UserRoles.Add(u);
            };

            context.SaveChanges();
        }
    }
}
