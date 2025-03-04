using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.DataContext.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public Screening Screening { get; set; }

        public Seat Seat { get; set; }

        public bool Valid { get; set; }
    }
}
