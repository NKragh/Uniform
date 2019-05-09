using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Persistency
{
    class PersistencyService
    {
        public static async Task<List<T>> ReadProcessOrder<T>()
        {
            string Path = "http://localhost:55478";
            List<T> targetList = new List<T>();

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
                        IEnumerable<T> procesorderData = response.Content.ReadAsAsync<IEnumerable<T>>().Result;
                        foreach (var p in procesorderData)
                        {
                            targetList.Add(p);
                        }
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
}
