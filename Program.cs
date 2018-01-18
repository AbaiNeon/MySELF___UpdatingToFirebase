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
        }
    }
}