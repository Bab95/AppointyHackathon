using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using newproject.Controllers;
namespace newproject.Service
{
    public class CustomerService
    {
        static Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
		public void storeAgents(Dictionary<int, Customer> copyof)
		{
            customers = copyof;
		}

		public Dictionary<int, Customer> returnCustomer()
		{
            return customers;
		}
    }
}
