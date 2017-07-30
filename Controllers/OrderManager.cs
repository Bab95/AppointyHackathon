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
    /*public class Integer{
        public int a;
        public Integer(int b){
            a = b;
        }
    }*/
    public class OrderManager
    {
        public static Agent PickUpAgent(string lat1,string long1,Dictionary<int,Agent> agents){
            int mindistance = 2000;
            Agent a = new Agent();
            for (int i = 0; i < agents.Count();i++){

                string lat2 = agents[i].latitude;
                string long2 = agents[i].longitude;
                int dist =  GetDistance(lat1, long1, lat2, long2).Result;
                if(dist < mindistance){
                    a = agents[i];
                }
                
            }

            return a;
        }

        /*Async static void GetDistance(string lat1,string long1,string lat2,string long2){
            HttpClient httpClient = new HttpClient();
			Uri uri = new Uri("https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins=" + lat1 + "," + long1 + "&destinations=" + lat2 + "," + long2;var response =  httpClient.GetAsync(uri);
			var json =  response.Content.ReadAsStringAsync();
			dynamic jsonObj = JsonConvert.DeserializeObject<object>(json);
			//Here we have to extract distance 

        }*/
        public static async Task<int> GetDistance(string lat1,string long1,string lat2,string long2)
		{
			HttpClient client = new HttpClient();
            Uri uri = new Uri("https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins=" + lat1 + "," + long1 + "&destinations=" +lat2 + "," + long2);
			var response = await client.GetAsync(uri);
			var json = await response.Content.ReadAsStringAsync();
			//JavaScriptSerializer js = new JavaScriptSerializer();
			dynamic jsonObj = JsonConvert.DeserializeObject<object>(json);
            var distance = Convert.ToUInt32(jsonObj.rows[0].elements[0].distance.value);

            //Integer iv = new Integer(90);
            return distance;
		}
    }
}
