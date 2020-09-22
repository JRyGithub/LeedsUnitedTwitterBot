using Newtonsoft.Json;
using RestSharp;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Net.Http;

namespace LeedsTwitterBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.Run();
        }
        public void Run(){
            //GetFplApiJson fplJson = new GetFplApiJson();
            //fplJson.GetFplJsonAsync();

            //SendTweet sendTweet = new SendTweet();
            //sendTweet.SimpleTweet();

            TestJSONtoModel jsonToModel = new TestJSONtoModel();
            jsonToModel.TestJsonToModelAsync();
        }
    }
}
