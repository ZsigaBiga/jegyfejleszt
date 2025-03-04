using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.DataContext.Entities
{
    public class RegisteredUser : User
    {
        public int Telephone { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        //Vásárolt jegyek :)
    }
}
