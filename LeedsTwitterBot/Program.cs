using Newtonsoft.Json;
using RestSharp;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

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
            GetFplApiJson fplJson = new GetFplApiJson();
            fplJson.GetFplJson();

            //SendTweet sendTweet = new SendTweet();
            //sendTweet.SimpleTweet();
        }
    }
}
