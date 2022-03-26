using BoxLoadingAutomation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLoadingAutomation.Behaviour
{
    internal interface IPlaneFactory
    {
        /// <summary>
        /// Get plane schedule
        /// </summary>
        /// <returns>return all plane</returns>
        List<Plane> GetPlaneSchedule();
    }
}
