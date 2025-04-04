using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain
{
    public class City
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string TitleFa { get; set; }
        public string TitleEn { get; set; }
        public string IataCode { get; set; }

        public virtual Country Country { get; set; }
        public virtual IEnumerable<ProviderCity> ProviderCities { get; set; }
    }
}
