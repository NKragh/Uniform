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

        /// <summary>
        /// Post an object to the database.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="typeInput">Type of object as string.</param>
        /// <param name="objectInput">Object to add to database.</param>
        /// <returns></returns>
        public static async Task<bool> CreateObjectToDatabaseAsync<T>(string typeInput, ProcessOrder objectInput)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;


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

                    var response = client.PostAsync($"api/{typeInput}s", byteContent).Result;
                    Debug.WriteLine(response);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Get all objects from database.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="typeInput">Type of object as string.</param>
        /// <returns></returns>
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
                    var response = client.GetStringAsync($"api/{typeInput}s/").Result;
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


        /// <summary>
        /// Read single object from database indexed by identifier.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="typeInput">Type of object as string.</param>
        /// <param name="identifierInput">Index of object to get</param>
        /// <returns></returns>
        public static async Task<object> ReadObjectsFromDatabaseAsync<T>(string typeInput, dynamic identifierInput)
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
                    var response = client.GetStringAsync($"api/{typeInput}s/{identifierInput}").Result;
                    if (response != null)
                    {
                        var content = JsonConvert.DeserializeObject<List<T>>(response);
                        returnList.AddRange(content);
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
                return returnList;
            }
        }

        /// <summary>
        /// Put an object in indexed location.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="typeInput">Type of object as string.</param>
        /// <param name="objectInput">Object with new values.</param>
        /// <param name="identifierInput">Index of object to update.</param>
        /// <returns></returns>
        public static async Task<bool> UpdateObjectToDatabaseAsync<T>(string typeInput, dynamic objectInput, int identifierInput)
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

                    var response = client.PutAsync($"api/{typeInput}s", byteContent).Result;
                    Debug.WriteLine(response);
                    return response.IsSuccessStatusCode;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Delete an object from the database. CAUTION: This command cannot be reverted!
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="typeInput">Type of object as string.</param>
        /// <param name="identifierInput">Index to be deleted.</param>
        /// <returns></returns>
        public static async Task<bool> DeleteObjectFromDatabaseAsync<T>(string typeInput, dynamic identifierInput)
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
                    var response = client.DeleteAsync($"api/{typeInput}s/{identifierInput}").Result;
                    Debug.WriteLine(response);
                    return response.IsSuccessStatusCode;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
        }
    }


}
