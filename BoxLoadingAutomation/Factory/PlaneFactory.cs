using BoxLoadingAutomation.Behaviour;
using BoxLoadingAutomation.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLoadingAutomation.Factory
{
    internal class PlaneFactory : IPlaneFactory
    {
        public List<Plane> GetPlaneSchedule()
        {
            return new List<Plane>()
            {
                new Plane()
                {
                    Flight = "1",
                    Departure = "YUL",
                    Arrival = "YYZ",
                    BoxLoad = 0,
                    DayScheduled = 1
                },
                new Plane()
                {
                    Flight = "2",
                    Departure = "YUL",
                    Arrival = "YYC",
                    BoxLoad = 0,
                    DayScheduled = 1
                },
                new Plane()
                {
                    Flight = "3",
                    Departure = "YUL",
                    Arrival = "YVR",
                    BoxLoad = 0,
                    DayScheduled = 1
                },
                new Plane()
                {
                    Flight = "4",
                    Departure = "YUL",
                    Arrival = "YYZ",
                    BoxLoad = 0,
                    DayScheduled = 2
                },
                new Plane()
                {
                    Flight = "5",
                    Departure = "YUL",
                    Arrival = "YYC",
                    BoxLoad = 0,
                    DayScheduled = 2
                },
                new Plane()
                {
                    Flight = "6",
                    Departure = "YUL",
                    Arrival = "YVR",
                    BoxLoad = 0,
                    DayScheduled = 2
                },
            };

        }
    }
}
