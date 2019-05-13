using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
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
        private const string Path = "http://localhost:55478";

        public static async Task<bool> CreateObjectToDatabaseAsync<T>(string typeInput, ProcessOrder objectInput)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            List<T> returnList = new List<T>();


            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(Path);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var content = JsonConvert.SerializeObject(objectInput);

                    var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync($"api/{typeInput}", byteContent).Result;
                    Debug.WriteLine(response);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
            //return returnList;
            return true;
        }

        //TODO: find på bedre navne til både metoder og parametre -.-
        public static async Task<List<T>> ReadObjectsFromDatabaseAsync<T>(string typeInput)
        {
            //TODO kan være vi skal flytte den ud af metoden / finde ud af noget med det defaultCredentials
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            List<T> returnList = new List<T>();

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(Path);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetStringAsync($"api/{typeInput}/").Result;
                    if (response != null)
                    {
                        var content = JsonConvert.DeserializeObject<List<T>>(response);
                        returnList.AddRange(content);

                        #region OldButGold



                        //string res = response;
                        //res = res.Replace("\"","");
                        //res = res.Replace(",", ":");
                        //string[] resarr = res.Split('{','}');


                        //ProcessOrder po123 = new ProcessOrder();
                        //List<string> resarr2 = new List<string>();
                        //for (int i = 1; i < resarr.Length; i +=2)
                        //{
                        //    resarr2.Add(resarr[i]);
                        //}

                        //List<string> resarr3 = new List<string>();

                        //foreach (string s in resarr2)
                        //{
                        //    string[] temparr = s.Split(':');
                        //    for (int i = 1; i < temparr.Length; i+=2)
                        //    {
                        //        resarr3.Add(temparr[i]);
                        //    }
                        //}


                        //for (int i = 0; i < resarr3.Count; i+=8)
                        //{
                        //    ProcessOrder tempProcessOrder = new ProcessOrder();
                        //    tempProcessOrder.ProcessOrderNo = Convert.ToInt32(resarr3[i]);
                        //    tempProcessOrder.BatchCode = (resarr3[i+1]);
                        //    tempProcessOrder.IsComplete = Convert.ToBoolean(resarr3[i+2]);
                        //    tempProcessOrder.ColumnNo = Convert.ToInt32(resarr3[i+3]);
                        //    tempProcessOrder.ProductNo = Convert.ToInt32(resarr3[i+4]);
                        //    tempProcessOrder.Employee = Convert.ToInt32(resarr3[i+5]);
                        //    targetList.Add(tempProcessOrder);
                        //}



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

                        //public static class HTTPClientExtensions
                        //{
                        //    public static async Task<T> ReadAsJsonAsync<T>(this HttpContent content)
                        //    {
                        //        var dataAsString = await content.ReadAsStringAsync();
                        //        return JsonConvert.DeserializeObject<T>(dataAsString);
                        //    }
                        //}

                        #endregion
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
                return returnList;
            }
        }

        /* Note: Skal ikke bruges i vores system, men burde virke på denne måde.

        public static async Task<object> ReadSingleObjectFromDatabaseAsync<T>(string typeInput, dynamic identifierInput)
        {
            throw new NotImplementedException();
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            var content = new object();

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(Path);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetStringAsync($"api/{typeInput}/{identifierInput}").Result;
                    content = JsonConvert.DeserializeObject<T>(response);
                    //returnObject.Add(content);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }

                return content;
            }
        }

        */

        public static async Task<T> UpdateObjectToDatabaseAsync<T>(string typeInput, dynamic objectInput)
        {
            throw new NotImplementedException();
        }

        public static async Task<T> DeleteObjectFromDatabaseAsync<T>(string typeInput, dynamic identifierInput)
        {
            throw new NotImplementedException();
        }
    }


}
