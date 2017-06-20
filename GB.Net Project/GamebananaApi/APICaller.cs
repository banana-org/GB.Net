using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Newtonsoft.Json;
using System.Net;
using GamebananaApi.DataTypes;

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

        public T Data<T>(T type, int itemid, string fields)
        {
            //Grabs the submission type, id, and fields and deserializes the JSON object that the API returns
            return JsonConvert.DeserializeObject<T>(client.DownloadString(string.Format("http://api.gamebanana.com/Core/Item/Data?itemtype={0}&itemid={1}&fields={2}&return_object=1", typeof(T).Name, itemid, fields)));
        }

        public List<object> Data<T>(List<T> type, int[] itemid, string[] fields)
        {
            //Same as the first function but supports multi-call
            string itemTypes = "";
            Type[] types = new Type[type.Count];
            string itemIDs = "";
            string itemFields = "";
            string finalURL = "http://api.gamebanana.com/Core/Item/Data?";

            int i = 0;
            foreach (object obj in type)
            {
                itemTypes += "&itemtype[]=" + obj.GetType().Name;
                types[i] = obj.GetType();
                i++;
            }
            foreach (int ID in itemid)
            {
                itemIDs += "&itemid[]=" + ID;
            }
            foreach (string field in fields)
            {
                itemFields += "&fields[]=" + field;
            }
            finalURL += itemTypes + itemIDs + itemFields + "&return_object=1";

            List<object> JSONObjects = JsonConvert.DeserializeObject(client.DownloadString(finalURL));
            List<object> toReturn = new List<object>();

            i = 0;
            foreach (string str in JSONObjects)
            {
                toReturn.Add(GenericMethod(type[i], JSONObjects[i]));
                i++;
            }
            return toReturn;
        }

        public T GenericMethod<T> (T obj, dynamic JSONObj)
        {
            return JsonConvert.DeserializeObject<T>(JSONObj);
        }
    }
}