using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using newproject.Service;
namespace newproject.Controllers
{
    [Route("api/customer")]
    public class CustomerController:Controller{
        static int dicCount = 0;
        CustomerService cs = new CustomerService();
        [HttpGet]
        public ActionResult Get(){
            Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();
            Customer c4 = new Customer();

            c1.id = dicCount++;
            c1.Name = "customerKumar1";
            c1.uid = "c.k-1";
            c1.pwd = "password";
            c1.location = "23.2171";
            c1.orderid = 4;
            c1.longitude = "77.406";


            c2.id = dicCount++;
            c2.Name = "customerKumar1";
            c2.uid = "c.k-2";
            c2.pwd = "password";
            c2.location = "23.2171";
            c2.orderid = 4;
            c2.longitude = "77.406";
            
            c3.id = dicCount++;
            c3.Name = "customerKumar1";
            c3.uid = "c.k-3";
            c3.pwd = "password";
            c3.location = "23.2171";
            c3.orderid = 3;
            c3.longitude = "77.406";
            

            c4.id = dicCount++;
            c4.Name = "customerKumar1";
            c4.uid = "c.k-4";
            c4.pwd = "password";
            c4.location = "23.2171";
            c4.orderid = 4;
            c4.longitude = "77.406";

            customers.Add(c1.id,c1);
            customers.Add(c2.id, c2);
            customers.Add(c3.id, c3);
            customers.Add(c4.id, c4);

            return Ok(customers);
        }

        [HttpGet("{id}")]
        public ActionResult GetUser(int id){
            Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();
            Customer c4 = new Customer();

            c1.id = dicCount++;
            c1.Name = "customerKumar1";
            c1.uid = "c.k-1";
            c1.pwd = "password";
            c1.location = "23.2171
            c1.orderid = 1;
            c1.longitude = "77.406";

            c2.id = dicCount++;
            c2.Name = "customerKumar1";
            c2.uid = "c.k-2";
            c2.pwd = "password";
            c2.location = "23.2171";
            c2.orderid = 2;
            c2.longitude = "77.406";
            
            c3.id = dicCount++;
            c3.Name = "customerKumar1";
            c3.uid = "c.k-3";
            c3.pwd = "password";
            c3.location = "23.2171"
            c3.orderid = 3;
            c3.longitude = "77.406";
            
            c4.id = dicCount++;
            c4.Name = "customerKumar1";
            c4.uid = "c.k-4";
            c4.pwd = "password";
            c4.location = "23.2171";
            c4.orderid = 4;
            c4.longitude = "77.406";
            
            customers.Add(c1.id, c1);
            customers.Add(c2.id, c2);
            customers.Add(c3.id, c3);
            customers.Add(c4.id, c4);

            foreach(KeyValuePair<int,Customer> k in customers){
                if(id==k.Key){
                    Customer c = new Customer();
                    c = k.Value;
                    return Ok(c);
                }
            }

            return BadRequest("Customer with this id doesn't exists");

        }

        [HttpPost]
        public ActionResult AddUser(Customer customerSubmit)
        {
            Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();
            Customer c4 = new Customer();

            c1.id = dicCount++;
            c1.Name = "customerKumar1";
            c1.uid = "c.k-1";
            c1.pwd = "password";
            c1.location = "23.2171

            c1.orderid = 1;
            c1.longitude = "77.406";

            c2.id = dicCount++;
            c2.Name = "customerKumar1";
            c2.uid = "c.k-2";
            c2.pwd = "password";
            c2.location = "23.2171";
            c2.orderid = 2;
            c2.longitude = "77.406";

            c3.id = dicCount++;
            c3.Name = "customerKumar1";
            c3.uid = "c.k-3";
            c3.pwd = "password";
            c3.location = "23.2171"

            c3.orderid = 3;
            c3.longitude = "77.406";

            c4.id = dicCount++;
            c4.Name = "customerKumar1";
            c4.uid = "c.k-4";
            c4.pwd = "password";
            c4.location = "23.2171";
            c4.orderid = 4;
            c4.longitude = "77.406";

            customers.Add(c1.id, c1);
            customers.Add(c2.id, c2);
            customers.Add(c3.id, c3);
            customers.Add(c4.id, c4);
            cs.storeAgents(customers);
            foreach (KeyValuePair<int, Customer> k in customers)
            {
                if (customerSubmit.id == k.Key)
                {
                    
                    return BadRequest("User Already exist");
                }
            }

            customers.Add(customerSubmit.id,customerSubmit);
            cs.storeAgents(customers);
            return Ok(customers);

        }





    } 
}
