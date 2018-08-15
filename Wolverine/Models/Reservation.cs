using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolverine
{
    public class Reservation
    {
        public string rID { get; set; }

        public string mID { get; set; }

        public string mFirstName { get; set; }

        public string mLastName { get; set; }

        public DateTime rDate { get; set; }

        public DateTime rStartTime { get; set; }

        public int rDuration { get; set; }

        public float rAmount { get; set; }

        public int rApproval { get; set; }
    }
}
