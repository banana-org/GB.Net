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
        //Note: Initializing a WebClient takes some time and thus makes the first run on them slower. Keeping one in memory should make calls quicker.
        string AuthKey = null;
        //Gonna implement some timer functionality to update the AuthKey when needed
        public APICaller(WebClient webclient)
        {
            client = webclient; //Grabs our universal WebClient. Async is supported on it ofc.
        }

        public string Authenticate(string Username, string Password)
        {
            string[] deserObj = JsonConvert.DeserializeObject<string[]>(client.DownloadString(string.Format("http://api.gamebanana.com/Core/Member/Authenticate?username={0}&password={1}", Username, Password))); //Enters the specified Username and Password and returns false or the authkey
            if (deserObj[0] != "false") { AuthKey = deserObj[0]; }
            return deserObj[0];
        }

        public int Identify(string Username)
        {
            try //This must be in a try block since the api returns false if it failed. This would cause an exception when setting it to an int[].
            {
                int[] deserObj = JsonConvert.DeserializeObject<int[]>(client.DownloadString(string.Format("http://api.gamebanana.com/Core/Member/Identify?username={0}", Username))); //Enters the username into the api and returns the ID or 0 if the member does not exist
                return deserObj[0];
            }
            catch
            {
                return 0; //Catches the exception and since we know the answer is false, we use 0 as no member has that id.
            }
        }

        public string Identify(int ID)
        {
            //Another option is to use an ID and find the username and this is that. A try catch block is not needed since a string can take the "false" value
            string[] deserObj = JsonConvert.DeserializeObject<string[]>(client.DownloadString(string.Format("http://api.gamebanana.com/Core/Member/IdentifyByID?userid={0}", ID))); //Enters the ID into the api and returns the username or null if the member does not exist
            if (deserObj[0] != "false") { return deserObj[0]; } //If the member exists, return the username
            else { return null; } //If the member does not exist, return null to the user
        }

        public void Data(/*string itemtype, string itemid, string fields*/)
        {
            //In-dev stages. Still writing Pseudo code for efficient implementation
            GamebananaDataType test = JsonConvert.DeserializeObject<GamebananaDataType>("http://api.gamebanana.com/Core/Item/Data?itemtype=Member&itemid=1382&fields=name,DefinitionList().aDonationMethods()");
            Console.WriteLine("Nice boop");
        }
    }
}
