
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace newproject.Controllers{
    public class Customer{
        public string Name{get;set;}
        public int id{get;set;}

        public string location{get;set;}
        public string longitude { get; set; }

        List<Order> previousOrders = new List<Order>();

        public int orderid;

        public string uid;
        public string pwd;

    }
}