using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class ProcessOrderHandler
    {
        public ProcessOrderViewModel ProcessOrderViewModel { get; set; }

        //const string Path = "http://localhost:55478";

        public ProcessOrderHandler(ProcessOrderViewModel processOrderViewModel)
        {
            ProcessOrderViewModel = processOrderViewModel;
        }

        public void CreateProcessOrder()
        {
            Debug.WriteLine("Its Working.gif!");
        }

        //public async void ReadProcessOrder()
        //{
        //    HttpClientHandler handler = new HttpClientHandler();
        //    handler.UseDefaultCredentials = true; //possible not working
        //    using (var client = new HttpClient(handler))
        //    {
        //        client.BaseAddress = new Uri(Path);
        //        client.DefaultRequestHeaders.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        //        try
        //        {
        //            var response = client.GetAsync("api/ProcessOrders").Result;
        //            //await rTask;
        //            if (response.IsSuccessStatusCode)
        //            {
        //                IEnumerable<ProcessOrder> procesorderData =
        //                    response.Content.ReadAsAsync<IEnumerable<ProcessOrder>>()
        //                        .Result;
        //                foreach (var p in procesorderData)
        //                {
        //                    ProcessOrderViewModel.ProcessOrderCatalog.ProcessOrderList.Add(p);
        //                }
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            throw new NotImplementedException();
        //        }


        //    }
        //}
    }
}
