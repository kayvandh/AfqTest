using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain
{
    public class Provider
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DisplayName { get; set; }
        public string BaseAddress { get; set; }
        public string Properties { get; set; }

        public virtual IEnumerable<ProviderCity> ProviderCities { get; set; }
    }
}
