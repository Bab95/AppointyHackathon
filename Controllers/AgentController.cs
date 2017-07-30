using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace newproject.Controllers
{
    [Route("api/agent")]
    public class AgentController : Controller
    {

        static int dicId = 0;
        // GET api/get
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/agent/5
        [HttpGet("agent/{id}")]
        public Agent GetAgent(int id)
        {
            Dictionary<int,Agent> agents = new Dictionary<int,Agent>();

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



			agents.Add(dicId,a1);
            agents.Add(dicId,a2);
            agents.Add(dicId,a3);


            foreach(KeyValuePair<int,Agent> a in agents){
                if(id==a.Key){
                    return a.Value;
                }
            }

            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            //var client = new HttpClient();
        }
// PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }


}
