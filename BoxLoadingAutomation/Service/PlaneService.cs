using BoxLoadingAutomation.Behaviour;
using BoxLoadingAutomation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLoadingAutomation.Service
{
    internal class PlaneService : IPlaneService
    {
        private readonly IPlaneFactory _planeFactory;
        public PlaneService(IPlaneFactory planeFactory)
        {
            _planeFactory = planeFactory;
        }

        public void PrintSchedule()
        {
            //get plane schedule from factory
            var scheduledPlanes = _planeFactory.GetPlaneSchedule();

            foreach (var plane in scheduledPlanes)
            {
                Console.WriteLine($"Flight: {plane.Flight}, departure: {plane.Departure}, arrival: {plane.Arrival}, day: {plane.DayScheduled}");
            };

        }
    }
}
