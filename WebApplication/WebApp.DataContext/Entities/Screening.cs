using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.DataContext.Entities
{
    public class Screening
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public List<Seat> Seat { get; set; }
        public DateTime Date { get; set; }


    }
}
