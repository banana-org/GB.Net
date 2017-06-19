using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using GamebananaApi;
using Newtonsoft.Json;
using GamebananaApi.DataTypes;

namespace ProjectForTesting
{
    class Program
    {
        static WebClient web = new WebClient();
        static void Main(string[] args)
        {
            APICaller ApiManager = new APICaller(web);
            //Console.WriteLine(ApiManager.Authenticate("Saghen", "RandomPassword"));
            //Console.WriteLine(ApiManager.Identify("Saghen"));
            Model exampleObject = new Model();
            exampleObject = ApiManager.Data(exampleObject, 3962, exampleObject.fields);
        }
    }
}
