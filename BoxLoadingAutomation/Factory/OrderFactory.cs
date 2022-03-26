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
    internal class OrderFactory : IOrderFactory
    {
        public List<Order> GetOrders()
        {
            var orders = new List<Order>();
            using (StreamReader reader = new StreamReader("Metadata/coding-assigment-orders.json"))
            {
                string json = reader.ReadToEnd();
                dynamic items = JsonConvert.DeserializeObject<dynamic>(json);


                foreach (var key in items)
                {
                    orders.Add(
                        new Order()
                        {
                            Number = key.Name,
                            Destination = key.Value["destination"],
                        });
                }

            }
            return orders;
        }
    }
}
