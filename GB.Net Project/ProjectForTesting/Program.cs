using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using GamebananaApi;
using Newtonsoft.Json;
using GamebananaApi.DataTypes;
using GamebananaApi.DataTypes.ListDataTypes;

namespace ProjectForTesting
{
    class Program
    {
        static WebClient web = new WebClient();
        static void Main(string[] args)
        {
            
            APICaller ApiManager = new APICaller(web);
            
            Model exampleObject = new Model(3962);
            Model exampleObject2 = new Model(3962);
            Model exampleObject3 = new Model(3962);

            List<Model> SubmissionInstances = new List<Model>() { exampleObject, exampleObject2, exampleObject3 };
            int[] IDs = new int[] { exampleObject.itemID, exampleObject2.itemID, exampleObject3.itemID };
            string[] fields = new string[] { exampleObject.fields, exampleObject2.fields, exampleObject3.fields };

            var wow = ApiManager.Data(SubmissionInstances, IDs, fields);

            List<ListMember> nice = ApiManager.ListLike<ListMember>("Member", "name", "Saghen");

            string APIPassword = ApiManager.AppAuthenticate("145563CEF5637AD1", "565", "1377912");
        }
    }
}
