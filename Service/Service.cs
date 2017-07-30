//Order Database
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using newproject.Controllers;
namespace newproject.Service
{
    public class Service
    {
        public static Dictionary<int, Order> orders = new Dictionary<int, Order>();

        public void storeDictionary(Dictionary<int,Order> copyDict){
            orders = copyDict;
        } 
        public Dictionary<int,Order> returnDictionary(){
            return orders;
        }
    }
}
