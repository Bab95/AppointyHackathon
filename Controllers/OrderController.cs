using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using newproject.Service;
namespace newproject.Controllers
{
    [Route("api/order")]
    public class OrderController : Controller
    {
        OrderService os = new OrderService();
        static int dicId = 0;
        [HttpGet]
        public ActionResult Get()
        {
            Dictionary<int, Order> orders = new Dictionary<int, Order>();

            Order a1 = new Order();
            Order a2 = new Order();
            Order a3 = new Order();
            Order a4 = new Order();

            a1.Name = "orderkumar1";
            a1.price = 1000;
            a1.id = dicId++;
            a1.placingDate = new DateTime(2017, 08, 04);
            a1.Quantity = 200;

            a2.Name = "orderkumar1";
            a2.price = 1000;
            a2.id = dicId++;
            a2.placingDate = new DateTime(2017, 08, 04);
            a2.Quantity = 300;

            a3.Name = "orderkumar1";
            a3.price = 1000;
            a3.id = dicId++;
            a3.placingDate = new DateTime(2017, 08, 04);
            a3.Quantity = 400;

            a4.Name = "orderkumar1";
            a4.price = 1000;
            a4.id = dicId++;
            a4.placingDate = new DateTime(2017, 08, 04);
            a4.Quantity = 500;

            orders.Add(a1.id, a1);
            orders.Add(a2.id, a2);
            orders.Add(a3.id, a3);
            orders.Add(a4.id, a4);
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public ActionResult GetOrder(int id)
        {

            Dictionary<int, Order> orders = new Dictionary<int, Order>();

            Order a1 = new Order();
            Order a2 = new Order();
            Order a3 = new Order();
            Order a4 = new Order();

            a1.Name = "orderkumar1";
            a1.price = 1000;
            a1.id = dicId++;
            a1.placingDate = new DateTime(2017, 08, 04);
            a1.Quantity = 200;


            a2.Name = "orderkumar1";
            a2.price = 1000;
            a2.id = dicId++;
            a2.placingDate = new DateTime(2017, 08, 04);
            a2.Quantity = 300;

            a3.Name = "orderkumar1";
            a3.price = 1000;
            a3.id = dicId++;
            a3.placingDate = new DateTime(2017, 08, 04);
            a3.Quantity = 400;

            a4.Name = "orderkumar1";
            a4.price = 1000;
            a4.id = dicId++;
            a4.placingDate = new DateTime(2017, 08, 04);
            a4.Quantity = 400;

            orders.Add(a1.id, a1);
            orders.Add(a2.id, a2);
            orders.Add(a3.id, a3);
            orders.Add(a4.id, a4);

            foreach (KeyValuePair<int, Order> k in orders)
            {
                if (id == k.Key)
                {
                    Order x = k.Value;
                    return Ok(x);

                }
            }

            return BadRequest("Order you are searching for doesn't exist");
        }

        [HttpDelete("{id}")]

        public ActionResult Cancel(int id)
        {

            Dictionary<int, Order> orders = new Dictionary<int, Order>();

            Order a1 = new Order();
            Order a2 = new Order();
            Order a3 = new Order();
            Order a4 = new Order();

            a1.Name = "orderkumar1";
            a1.price = 1000;
            a1.id = dicId++;
            a1.placingDate = new DateTime(2017, 08, 04);
            a1.Quantity = 200;


            a2.Name = "orderkumar1";
            a2.price = 1000;
            a2.id = dicId++;
            a2.placingDate = new DateTime(2017, 08, 04);
            a2.Quantity = 300;

            a3.Name = "orderkumar1";
            a3.price = 1000;
            a3.id = dicId++;
            a3.placingDate = new DateTime(2017, 08, 04);
            a3.Quantity = 300;

            a4.Name = "orderkumar1";
            a4.price = 1000;
            a4.id = dicId++;
            a4.placingDate = new DateTime(2017, 08, 04);
            a4.Quantity = 500;

            orders.Add(a1.id, a1);
            orders.Add(a2.id, a2);
            orders.Add(a3.id, a3);
            orders.Add(a4.id, a4);

            foreach (KeyValuePair<int, Order> k in orders)
            {
                if (id == k.Key)
                {
                    CustomerService cs = new CustomerService();
                    AgentService ag = new AgentService();
                    Dictionary<int, Agent> rty = ag.returnAgents();
                    Dictionary<int, Customer> dict = new Dictionary<int, Customer>();
                    string lat1="";
                    string long1="";
                    dict = cs.returnCustomer();
                    Order v = k.Value;
                    foreach(KeyValuePair<int,Customer> p in dict){
                        Customer c = p.Value;
                        if(c.id==v.customerid){
                            lat1 = c.location;
                            long1 = c.longitude;
                        }
                    }
                    ///////here pickup agent..
                    Agent pick = new Agent();

                    pick = OrderManager.PickUpAgent(lat1,long1,rty);
					Order x = k.Value;
					orders.Remove(id);

                    return Ok(pick);

                }
            }

            os.storeOrders(orders);

            return BadRequest("Order doesn't exist");

        }

        [HttpPut("{id}")]
        public ActionResult Update(int id,Order o){

			Dictionary<int, Order> orders = new Dictionary<int, Order>();

			Order a1 = new Order();
			Order a2 = new Order();
			Order a3 = new Order();
			Order a4 = new Order();

			a1.Name = "orderkumar1";
			a1.price = 1000;
			a1.id = dicId++;
			a1.placingDate = new DateTime(2017, 08, 04);
            a1.Quantity = 200;

			a2.Name = "orderkumar1";
			a2.price = 1000;
			a2.id = dicId++;
			a2.placingDate = new DateTime(2017, 08, 04);
            a2.Quantity = 300;

			a3.Name = "orderkumar1";
			a3.price = 1000;
			a3.id = dicId++;
			a3.placingDate = new DateTime(2017, 08, 04);
            a3.Quantity = 400;

			a4.Name = "orderkumar1";
			a4.price = 1000;
			a4.id = dicId++;
			a4.placingDate = new DateTime(2017, 08, 04);
            a4.Quantity = 500;

			orders.Add(a1.id, a1);
			orders.Add(a2.id, a2);
			orders.Add(a3.id, a3);
			orders.Add(a4.id, a4);

			foreach (KeyValuePair<int, Order> k in orders)
			{
				if (id == k.Key)
				{
					orders.Remove(id);
                    orders.Add(id,o);

					return Ok(o);

				}
			}

            os.storeOrders(orders);

            return BadRequest("Order doesn't Exist visit www.order.com to place order!!!");
            
        }

        [HttpPost]
        public ActionResult PlaceOrder(Order order){

			Dictionary<int, Order> orders = new Dictionary<int, Order>();

			Order a1 = new Order();
			Order a2 = new Order();
			Order a3 = new Order();
			Order a4 = new Order();

			a1.Name = "orderkumar1";
			a1.price = 1000;
			a1.id = dicId++;
			a1.placingDate = new DateTime(2017, 08, 04);
            a1.Quantity = 200;

			a2.Name = "orderkumar1";
			a2.price = 1000;
			a2.id = dicId++;
			a2.placingDate = new DateTime(2017, 08, 04);
            a2.Quantity = 300;

			a3.Name = "orderkumar1";
			a3.price = 1000;
			a3.id = dicId++;
			a3.placingDate = new DateTime(2017, 08, 04);
            a3.Quantity = 400; 

			a4.Name = "orderkumar1";
			a4.price = 1000;
			a4.id = dicId++;
			a4.placingDate = new DateTime(2017, 08, 04);
            a4.Quantity = 500;

			orders.Add(a1.id, a1);
			orders.Add(a2.id, a2);
			orders.Add(a3.id, a3);
			orders.Add(a4.id, a4);

			foreach (KeyValuePair<int, Order> k in orders)
			{
				if (order.id == k.Key)
				{
					
                    return BadRequest("Order Already Exist");

				}
			}

            orders.Add(order.id,order);

            orders[order.id].Quantity--;

            os.storeOrders(orders);
            return Ok(order);
        }




    }
}
