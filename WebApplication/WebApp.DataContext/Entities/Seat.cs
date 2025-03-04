using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.DataContext.Entities
{
     public class Seat
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public bool Available { get; set; }
    }
}
