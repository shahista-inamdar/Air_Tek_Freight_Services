using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLoadingAutomation.Entity
{
    internal class Plane
    {
        public string Flight { get; set; }

        public string Departure { get; set; }

        public string Arrival { get; set; }

        public int BoxLoad { get; set; }

        public int DayScheduled { get; set; }
    }
}
