﻿using System;
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
        //Note: Initializing a WebClient takes some time and thus makes the first run on them slower. Keeping one in memory and using it for everything will result in only one initialization and therefore, should make calls quicker.
        string AuthKey = null;
        string ApiKey = null;
        //Gonna implement some timer functionality to update the AuthKey when needed
        public APICaller(WebClient webclient, string APIKey)
        {
            client = webclient; //Grabs our universal WebClient. Async is supported on it ofc.
            APIKey = ApiKey;
        }

        public APICaller(WebClient webclient)
        {
            client = webclient; //Grabs our universal WebClient. Async is supported on it ofc.
        }

        public string MemberAuthenticate(string Username, string Password)
        {
            string[] deserObj = JsonConvert.DeserializeObject<string[]>(client.DownloadString(string.Format("http://api.gamebanana.com/Core/Member/Authenticate?username={0}&password={1}", Username, Password))); //Enters the specified Username and Password and returns false or the authkey
            if (deserObj[0] != "false")
            { 
                //AuthKey = deserObj[0]; 
            }
            return deserObj[0];
        }

        public string AppAuthenticate(string api_password, string app_id, string userid)
        {
            try {
                string[] tempArray = JsonConvert.DeserializeObject<string[]>(client.DownloadString(string.Format("http://api.gamebanana.com/Core/App/Authenticate?api_password={0}&app_id={1}&userid={2}", api_password, app_id, userid)));
                AuthKey = tempArray[0];
                return tempArray[0];
            }
            catch { return "false"; }
        }


        #region Identification

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

        #endregion

        #region Data

        public T Data<T>(T type, int itemid, string fields)
        {
            //Grabs the submission type, id, and fields and deserializes the JSON object that the API returns
            return JsonConvert.DeserializeObject<T>(client.DownloadString(string.Format("http://api.gamebanana.com/Core/Item/Data?itemtype={0}&itemid={1}&fields={2}&return_object=1", typeof(T).Name, itemid, fields)));
        }

        public List<T> Data<T>(List<T> type, int[] itemid, string[] fields)
        {
            //Same as the first function but supports multi-call
            string itemTypes = "";
            string itemIDs = "";
            string itemFields = "";
            string finalURL = "http://api.gamebanana.com/Core/Item/Data?";

            foreach (object obj in type)
            {
                itemTypes += "&itemtype[]=" + obj.GetType().Name;
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
            List<T> toReturn = new List<T>();

            toReturn = JsonConvert.DeserializeObject<List<T>>(client.DownloadString(new Uri(finalURL)));
            return toReturn;
        }

        public string[] AllowedItemTypes()
        {
            return JsonConvert.DeserializeObject<string[]>(client.DownloadString("http://api.gamebanana.com/Core/Item/Data/AllowedItemTypes"));
        }

        public string[] AllowedItemTypes(string itemtype)
        {
            return JsonConvert.DeserializeObject<string[]>(client.DownloadString(string.Format("http://api.gamebanana.com/Core/Item/Data/AllowedFields?itemtype={0}", itemtype)));
        }

        #endregion

        #region List

        public List<T> ListLike<T> (string itemtype, string field, string searchField)
        {
            return JsonConvert.DeserializeObject<List<T>>(client.DownloadString(string.Format("http://api.gamebanana.com/Core/List/Like?itemtype={0}&field={1}&match={2}", itemtype, field, searchField)));
        }

        #endregion
    }
}