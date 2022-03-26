using BoxLoadingAutomation.Behaviour;
using BoxLoadingAutomation.Entity;
using BoxLoadingAutomation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLoadingAutomation.Service
{
    internal class OrderService : IOrderService
    {
        private readonly IPlaneFactory _planeFactory;
        private readonly IOrderFactory _orderFactory;

        private const int PLANE_CAPACITY = 20;
        private List<Order> orders;
        public OrderService(IPlaneFactory planeFactory, IOrderFactory orderFactory)
        {
            _planeFactory = planeFactory;
            _orderFactory = orderFactory;
        }

        public List<Order> Process()
        {
            //get orders from factory
            var orders = _orderFactory.GetOrders();

            //get all planes from factory
            var planes = _planeFactory.GetPlaneSchedule();

            //iterate through planes day wise for order allocation
            foreach(var planeGroup in planes.GroupBy(x=> x.DayScheduled))
            {
                //iterate through each plane on that day
                foreach(var plane in planeGroup)
                {
                    //plane should not exeed it's capacity to carry box
                    if (plane.BoxLoad < PLANE_CAPACITY)
                    {
                        //get orders to whom plan is not assigned
                        var remainingOrders = orders.Where(order => order.PlaneAssigned == null && order.Destination == plane.Arrival).ToList();

                        //go through each order and assign plane based on its capacity
                        for (int i = 0; i < remainingOrders.Count; i++)
                        {
                            //if plane has reached it's capacity then break the loop and go for next plan for the day
                            if(plane.BoxLoad >= PLANE_CAPACITY)
                            {
                                break;
                            }

                            //assign plane to order and increase the plane boxload
                            remainingOrders[i].PlaneAssigned = plane;
                            plane.BoxLoad += 1;
                        }
                    }
                }
            }

            this.orders = orders;
            return orders;
        }

        public void PrintOrders()
        {
            //print all orders
            foreach(var order in orders)
            {
                if (order.PlaneAssigned != null)
                {
                    Console.WriteLine($"order: {order.Number}, flightNumber: {order.PlaneAssigned.Flight}, departure: {order.PlaneAssigned.Departure}, arrival: {order.PlaneAssigned.Arrival}, day: {order.PlaneAssigned.DayScheduled}");
                }
                else{
                    Console.WriteLine($"order: {order.Number}, flightNumber: not scheduled");
                }
            }
        }
    }
}
