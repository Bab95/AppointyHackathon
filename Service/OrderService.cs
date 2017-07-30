using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using newproject.Controllers;
namespace newproject.Service
{
    public class OrderService
    {
		static Dictionary<int, Order> orders = new Dictionary<int, Order>();
		public void storeOrders(Dictionary<int, Order> copyof)
		{
			orders = copyof;
		}

		Dictionary<int, Order> returnOrder()
		{
			return orders;
		}
    }
}
