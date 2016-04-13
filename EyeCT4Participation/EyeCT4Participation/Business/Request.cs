using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Participation.Business
{
    class Request
    {
        public int requestID { get; set; }

        public int needyID { get; set; }

        public string Description { get; set; }

        public bool urgency { get; set; }

        public string location { get; set; }

        public int travelTime { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public int totalVolunteer { get; set; }

        public List<string> reactionlist { get; set; }
    }
}
