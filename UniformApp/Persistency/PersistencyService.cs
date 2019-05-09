using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using UniformApp.Model;
using UniformApp.ViewModel;
using Newtonsoft.Json;

namespace UniformApp.Persistency
{
    class PersistencyService
    {
        public static async Task<List<ProcessOrder>> ReadProcessOrder<T>()
        {
            string Path = "http://localhost:55478";
            List<ProcessOrder> targetList = new List<ProcessOrder>();

            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true; //possible not working

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(Path);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetAsync("api/ProcessOrders").Result;
                    //await rTask;
                    if (response.IsSuccessStatusCode)
                    {

                        string res = await response.Content.ReadAsStringAsync();
                        var content = JsonConvert.DeserializeObject(res);




                        //var o = response.Content.ReadAsAsync<ProcessOrder>(new[] {new JsonMediaTypeFormatter()});



                        //var fuckoff = response.Content.ReadAsStreamAsync().Result;
                        //Encoding encode =
                        //    System.Text.Encoding.GetEncoding("utf-8");

                        //StreamReader sr = new StreamReader(fuckoff, encode);
                        //Char[] read = new Char[1024];

                        //int Count = sr.Read(read, 0, 1024);
                        //List<ProcessOrder> processOrders = new List<ProcessOrder>();







                        //IEnumerable<ProcessOrder> procesorderData = response.Content.ReadAsAsync<IEnumerable<ProcessOrder>>().Result;
                        //foreach (var p in procesorderData)
                        //{
                        //    ProcessOrder po = new ProcessOrder(Convert.ToInt32(p.Attribute));
                        //}


                        //ProcessOrder blah = response.Content.ReadAsJsonAsync<ProcessOrder>().Result;
                        //Console.WriteLine(blah);
                        //string blah2 = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(blah).ToString(); 
                        //ProcessOrder procesorderData =  response.Content.ReadAsAsync<ProcessOrder>().Result;
                        //foreach (ProcessOrder p in procesorderData)
                        //{
                        //targetList.Add(procesorderData);
                        //}
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }

                return targetList;


            }
        }
    }

    public static class HTTPClientExtensions
    {
        public static async Task<T> ReadAsJsonAsync<T>(this HttpContent content)
        {
            var dataAsString = await content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(dataAsString);
        }
    }

}
