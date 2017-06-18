using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using GamebananaApi;

namespace ProjectForTesting
{
    class Program
    {
        static WebClient web = new WebClient();
        static void Main(string[] args)
        {
            APICaller ApiManager = new APICaller(web);
            Console.WriteLine(ApiManager.Authenticate("Saghen", "RandomPassword"));
            Console.WriteLine(ApiManager.Identify("Saghen"));
            ApiManager.Data();
        }
    }
}
