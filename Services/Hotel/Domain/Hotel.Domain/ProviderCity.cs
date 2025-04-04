using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain
{
    public class ProviderCity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int ProviderId { get; set; }
        public string Code { get; set; }

        public virtual City City { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
