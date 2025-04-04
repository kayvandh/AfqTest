using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Models
{
    public class ReserveContactInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string NationalId { get; set; }
        public string PassportNumber { get; set; }

    }
}
