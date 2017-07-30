using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using newproject.Service;
using Newtonsoft.Json;
namespace newproject.Controllers
{
    [Route("api/sol")]
    public class sol:Controller
    {
        public static string cust1="22.719568",ag1="23.2599333";
        public static string cust2="75.857727",ag2="77.412615";
		[HttpGet]
		[Route("distance")]
		public async Task<ActionResult> GetDistance()
		{
			 HttpClient client = new HttpClient();
             Uri uri = new Uri("https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins=" + cust1 + "," + cust2 + "&destinations=" + ag1 + "," + ag2);
             var response = await client.GetAsync(uri);
             var json = await response.Content.ReadAsStringAsync();
            //JavaScriptSerializer js = new JavaScriptSerializer();
             dynamic jsonObj = JsonConvert.DeserializeObject<object>(json);
             var distance = jsonObj.rows[0].elements[0].distance.value;

            return Ok(distance);
		}
         
    }
}
