using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain
{
    public class Country
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string IataZone { get; set; }

        public virtual IEnumerable<City> Cities { get; set; }
    }
}
