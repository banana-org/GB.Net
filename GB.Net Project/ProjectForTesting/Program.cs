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
            Model exampleObject = new Model(3962);
            Model exampleObject2 = new Model(3962);
            Model exampleObject3 = new Model(3962);
            //exampleObject = ApiManager.Data(exampleObject, exampleObject.itemID, exampleObject.fields);

            List<Model> SubmissionInstances = new List<Model>() { exampleObject, exampleObject2, exampleObject3 };
            int[] IDs = new int[] { exampleObject.itemID, exampleObject2.itemID, exampleObject3.itemID };
            string[] fields = new string[] { exampleObject.fields, exampleObject2.fields, exampleObject3.fields };

            exampleObject = ApiManager.Data(SubmissionInstances, IDs, fields);
        }
    }
}
