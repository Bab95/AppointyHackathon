using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using newproject.Controllers;
namespace newproject.Service
{
    public class AgentService
    {
        static Dictionary<int, Agent> agents = new Dictionary<int, Agent>();
        public void storeAgents(Dictionary<int, Agent> copyof){
            agents = copyof;
        }

        public Dictionary<int,Agent> returnAgents(){
            return agents;
        }
    }
}
