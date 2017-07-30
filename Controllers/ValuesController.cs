
//This is agentController File
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using newproject.Service;
namespace newproject.Controllers
{
    [Route("api/values")]
    public class ValuesController : Controller
    {
        AgentService ap = new AgentService();
        static int dicId = 0, count = 0;
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
			Dictionary<int, Agent> agents = new Dictionary<int, Agent>();

			Agent a1 = new Agent();
			Agent a2 = new Agent();
			Agent a3 = new Agent();

			a1.Name = "agentkumar1";
			a1.freeStatus = true;
			a1.id = dicId++;
			a1.latitude = "0.0.0.0";
			a1.longitude = "";

			a2.Name = "agentkumar2";
			a2.freeStatus = true;
			a2.id = dicId++;
			a2.latitude = "0.0.0.0";
			a2.longitude = "";


			a3.Name = "agentkumar3";
			a3.freeStatus = true;
			a3.id = dicId++;
			a3.latitude = "0.0.0.0";
			a3.longitude = "";



			agents.Add(a1.id, a1);
			agents.Add(a2.id, a2);
			agents.Add(a3.id, a3);
            return Ok(agents);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
			Dictionary<int, Agent> agents = new Dictionary<int, Agent>();

			Agent a1 = new Agent();
			Agent a2 = new Agent();
			Agent a3 = new Agent();

			a1.Name = "agentkumar1";
			a1.freeStatus = true;
			a1.id = dicId++;
			a1.latitude = "0.0.0.0";
			a1.longitude = "";

			a2.Name = "agentkumar2";
			a2.freeStatus = true;
			a2.id = dicId++;
			a2.latitude = "0.0.0.0";
			a2.longitude = "";
			
            a3.Name = "agentkumar3";
			a3.freeStatus = true;
			a3.id = dicId++;
			a3.latitude = "0.0.0.0";
			a3.longitude = "";


			agents.Add(a1.id, a1);
			agents.Add(a2.id, a2);
            agents.Add(a3.id, a3);


			foreach (KeyValuePair<int, Agent> a in agents)
			{
				if (id == a.Key)
				{
                    Agent x = a.Value;
                    return Ok(x);
				}
			}
            return BadRequest("User Not Exist");
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody]Agent agentSubmit)
        {
			//var client = new HttpClient();

			Dictionary<int, Agent> agents = new Dictionary<int, Agent>();

			Agent a1 = new Agent();
			Agent a2 = new Agent();
			Agent a3 = new Agent();

			a1.Name = "agentkumar1";
			a1.freeStatus = true;
			a1.id = dicId++;
			a1.latitude = "0.0.0.0";
			a1.longitude = "";

			a2.Name = "agentkumar2";
			a2.freeStatus = true;
			a2.id = dicId++;
			a2.latitude = "0.0.0.0";
			a2.longitude = "";


			a3.Name = "agentkumar3";
			a3.freeStatus = true;
			a3.id = dicId++;
			a3.latitude = "0.0.0.0";
			a3.longitude = "";




            agents.Add(a1.id, a1);
			agents.Add(a2.id, a2);
			agents.Add(a3.id, a3);


            foreach(KeyValuePair<int,Agent> a in agents){
                if(a.Key==agentSubmit.id){
                    return BadRequest("User with this id already exists");
                }
            }

            agents.Add(agentSubmit.id, agentSubmit);
            ap.storeAgents(agents);
            return Ok(agentSubmit);


            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Agent newAgent)
        {
			Dictionary<int, Agent> agents = new Dictionary<int, Agent>();

			Agent a1 = new Agent();
			Agent a2 = new Agent();
			Agent a3 = new Agent();

			a1.Name = "agentkumar1";
			a1.freeStatus = true;
			a1.id = dicId++;
			a1.latitude = "0.0.0.0";
			a1.longitude = "";

			a2.Name = "agentkumar2";
			a2.freeStatus = true;
			a2.id = dicId++;
			a2.latitude = "0.0.0.0";
			a2.longitude = "";


			a3.Name = "agentkumar3";
			a3.freeStatus = true;
			a3.id = dicId++;
			
            a3.latitude = "0.0.0.0";
			a3.longitude = "";


			agents.Add(a1.id, a1);
			agents.Add(a2.id, a2);
			agents.Add(a3.id, a3);


			foreach(KeyValuePair<int,Agent> a in agents){
                if(a.Key==id){
                    agents.Remove(id);
                    agents.Add(id,newAgent);
                    ap.storeAgents(agents);
                    return Ok(newAgent);
                }
            }
            return BadRequest("This is User doesn't exist");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
			Dictionary<int, Agent> agents = new Dictionary<int, Agent>();

			Agent a1 = new Agent();
			Agent a2 = new Agent();
			Agent a3 = new Agent();

			a1.Name = "agentkumar1";
			a1.freeStatus = true;
			a1.id = dicId++;
			a1.latitude = "0.0.0.0";
			a1.longitude = "";

			a2.Name = "agentkumar2";
			a2.freeStatus = true;
			a2.id = dicId++;
			a2.latitude = "0.0.0.0";
			a2.longitude = "";


			a3.Name = "agentkumar3";
			a3.freeStatus = true;
			a3.id = dicId++;
			a3.latitude = "0.0.0.0";
			a3.longitude = "";




			agents.Add(a1.id, a1);
			agents.Add(a2.id, a2);
			agents.Add(a3.id, a3);

			foreach(KeyValuePair<int,Agent> a in agents){
                if(id==a.Key){
                    Agent x = new Agent();
                    x = agents[id];
                    agents.Remove(id);
                    ap.storeAgents(agents);
                    return Ok(x);
                }
            }
            return BadRequest("User with given id doesn't exists");
        }
    }
}
