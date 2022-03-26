using BoxLoadingAutomation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLoadingAutomation.Behaviour
{
    internal interface IOrderFactory
    {

        /// <summary>
        /// Get all orders from a json file
        /// </summary>
        /// <returns>list of order</returns>
        List<Order> GetOrders();
    }
}
