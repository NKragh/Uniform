﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ProcessOrderHandler(ProcessOrderViewModel viewModel)
        {
            ProcessOrderViewModel = viewModel;
            
        }

        public void CreateProcessOrder()
        {
            var test = Persistency.PersistencyService.CreateObjectToDatabaseAsync<ProcessOrder>("ProcessOrder", ProcessOrderViewModel.NewProcessOrder).Result;
        }

        public void UpdateProcessOrder()
        {
            throw new NotImplementedException();
        }
        public void DeleteProcessOrder()
        {
            throw new NotImplementedException();
        }

        //public async void ReadObjectsFromDatabaseAsync()
        //{
        //    ProcessOrder processOrder = null;
        //    using (var client = new HttpClient(handler))
        //    {
        //        client.BaseAddress = new Uri(path);
        //        client.DefaultRequestHeaders.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        //        Task<HttpResponseMessage> rTask = client.GetAsync("api/ProcessOrders");
        //        await rTask;
        //        if (rTask.Result.IsSuccessStatusCode)
        //        {
        //            var cTask = rTask.Result.Content.ReadAsAsync<IEnumerable<ProcessOrder>>();
        //            await cTask;
        //            foreach (var c in cTask.Result)
        //            {
        //                ProcessOrderViewModel.processOrders.Add(c);
        //            }
        //            //Debug.WriteLine(cTask);
        //        }

        //    }
        //    //HttpResponseMessage response = await client.GetAsync(path);
        //    //if (response.IsSuccessStatusCode)
        //    //{
        //    //    processOrder = await response.Content.ReadAsAsync<ProcessOrder>();
        //    //}
        //    //return processOrder;
        //
        
    }
}