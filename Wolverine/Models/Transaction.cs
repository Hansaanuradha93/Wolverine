using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolverine.Models
{
    public class Transaction
    {
        public string tID { get; set; }

        public string mID { get; set; }

        public DateTime tDate { get; set; }

        public DateTime tStartTime { get; set; }

        public int tDuration { get; set; }

        public float tAmount { get; set; }
    }
}
