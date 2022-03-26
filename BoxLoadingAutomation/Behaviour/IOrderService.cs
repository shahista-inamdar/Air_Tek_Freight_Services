using BoxLoadingAutomation.Entity;
using System.Collections.Generic;

namespace BoxLoadingAutomation.Behaviour
{
    internal interface IOrderService
    {
        /// <summary>
        /// Process all orders and assign them to plane
        /// </summary>
        /// <returns></returns>
        List<Order> Process();

        /// <summary>
        /// Print all orders with their assignment status
        /// </summary>
        void PrintOrders();
    }
}
