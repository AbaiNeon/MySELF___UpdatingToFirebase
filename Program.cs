using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //json-строку отправляем в firebase
            string json = File.ReadAllText(@"C:\name_of_folder\data.json");

            var request = WebRequest.CreateHttp("https://test-b138f.firebaseio.com/.json");
            request.Method = "POST";
            request.ContentType = "application/json";

            var buffer = Encoding.UTF8.GetBytes(json);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);

            //получение данных из Firebase
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://test-b138f.firebaseio.com/-L37EB6WnyIUrzGFXK4D/.json");
            //request.ContentType = "application/json: charset=utf-8";

            //HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //string data;
            //using (Stream responsestream = response.GetResponseStream())
            //{
            //    StreamReader read = new StreamReader(responsestream, Encoding.UTF8);
            //    data = read.ReadToEnd();
            //}

            //List<User> userList = JsonConvert.DeserializeObject<List<User>>(data);
        }
    }
}