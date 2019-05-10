using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.ViewModel;
using System.Net.Http;
using UniformApp.Model;
using System.Diagnostics;

namespace UniformApp.Handler
{
    class ProcessOrderHandler
    {
        public ProcessOrderViewModel ProcessOrderViewModel { get; set; }
        public HttpClientHandler handler = new HttpClientHandler();

        const string path = "http://localhost:55478/";

        public ProcessOrderHandler(ProcessOrderViewModel viewModel)
        {
            ProcessOrderViewModel = viewModel;
        }

        public async void CreateProcessOrderAsync(ProcessOrder processOrder)
        {
            //HttpResponseMessage response = await client.PostAsJsonAsync("api/ProcessOrders", processOrder);
            //response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            //return response.Headers.Location;
        }
        public async void ReadProcessOrder()
        {
            ProcessOrder processOrder = null;
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(path);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                Task<HttpResponseMessage> rTask = client.GetAsync("api/ProcessOrders");
                await rTask;
                if (rTask.Result.IsSuccessStatusCode)
                {
                    var cTask = rTask.Result.Content.ReadAsAsync<IEnumerable<ProcessOrder>>();
                    await cTask;
                    foreach (var c in cTask.Result)
                    {
                        ProcessOrderViewModel.processOrders.Add(c);
                    }
                    //Debug.WriteLine(cTask);
                }

            }
            //HttpResponseMessage response = await client.GetAsync(path);
            //if (response.IsSuccessStatusCode)
            //{
            //    processOrder = await response.Content.ReadAsAsync<ProcessOrder>();
            //}
            //return processOrder;
        }
        public async void UpdateProcessOrder()
        {
        }
        public async void DeleteProcessOrder()
        {
        }

        
    }
}
