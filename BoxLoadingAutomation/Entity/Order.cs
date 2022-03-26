using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLoadingAutomation.Entity
{
    internal class Order
    {
        public string Number { get; set; }

        public string Destination { get; set; }

        public Plane PlaneAssigned { get; set; }
    }
}
