using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace GamebananaApi
{
    public class APICaller
    {
        WebClient client;
        string AuthKey = null;
        public APICaller (WebClient webclient)
        {
            client = webclient;
        }

        public string Authenticate(string Username, string Password)
        {
            string[] deserObj = JsonConvert.DeserializeObject<string[]>(client.DownloadString(string.Format("http://api.gamebanana.com/Core/Member/Authenticate?username={0}&password={1}", Username, Password)));
            if (deserObj[0] != "false") { AuthKey = deserObj[0]; }
            return deserObj[0];
        }

        public int Identify(string Username)
        {
            try
            {
                int[] deserObj = JsonConvert.DeserializeObject<int[]>(client.DownloadString(string.Format("http://api.gamebanana.com/Core/Member/Identify?username={0}", Username)));
                return deserObj[0];
            }
            catch
            {
                return 0;
            }
            
        }

        public string Identify(int ID)
        {
            try
            {
                string[] deserObj = JsonConvert.DeserializeObject<string[]>(client.DownloadString(string.Format("http://api.gamebanana.com/Core/Member/IdentifyByID?userid={0}", ID)));
                return deserObj[0];
            }
            catch
            {
                return null;
            }
        }

        public void Data (/*string itemtype, string itemid, string fields*/)
        {
            GamebananaDataType test = JsonConvert.DeserializeObject<GamebananaDataType>("http://api.gamebanana.com/Core/Item/Data?itemtype=Member&itemid=1382&fields=name,DefinitionList().aDonationMethods()");
            Console.WriteLine("Nice boop");
        }
    }
}
