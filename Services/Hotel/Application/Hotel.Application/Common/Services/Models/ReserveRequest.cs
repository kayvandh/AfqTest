using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Services.Models
{
    public class ReserveRequest
    {
        public Guid SearchId { get; set; }
        public Guid PackgeId { get; set; }
        public ReserveContactInformation ContactInformation { get; set; }
        public List<Traveller> Travellers { get; set; }
        public bool LateCheckIn { get; set; }
        public int? LateCheckInTime { get; set; }
    }
}
