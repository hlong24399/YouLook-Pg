using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouLook_Official.Models
{
    /*public enum Enum_role
    {
        Admin, User
    }*/

    public class UserRole
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Role { get; set; }
    }
}
