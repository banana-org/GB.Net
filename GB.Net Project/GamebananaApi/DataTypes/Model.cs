using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamebananaApi.DataTypes.SubTypes;
using Newtonsoft.Json;

namespace GamebananaApi.DataTypes
{
    class Model
    {
        //So many variables
        public bool animated { get; set; }
        public string appsUsed { get; set; }
        public Author authors { get; set; }
        public string catId { get; set; }
        public int contestId { get; set; }
        public string creator { get; set; }
        public double cumlativeRating { get; set; }
        public string date { get; set; }
        public string description { get; set; }
        public class DownloadInfo
        {
            public bool fileExists { get; set; }
            public int getFileSize { get; set; }
            public string fileURL { get; set; }
            public string downloads { get; set; }
        }
        public string feedbackInstructions { get; set; }
        public string file { get; set; }
        public class Flags
        {
           public int[] activeFlagRowIDs { get; set; }
           public bool isFlagged { get; set; }
           public int activeFlagCount { get; set; }
        }
        public string lastPostDate { get; set; }
        public string lastPostUserId { get; set; }
        public bool uvMapped { get; set; }
        public string mdate { get; set; }
        public string modnote { get; set; }
        public string name { get; set; }
        public int polycount { get; set; }
        public int postcount { get; set; }
        public double rating { get; set; }
        public string screenshots { get; set; }
        public int studioId { get; set; }
        public string text { get; set; }
        public bool isTextured { get; set; }
        public bool isTrashed { get; set; }
        public int tricount { get; set; }
        public int userId { get; set; }
        public int views { get; set; }
        public int votes { get; set; }
        public bool isWithheld { get; set; }

        public void GetData (int ID, Model obj)
        {
            //For single-call api data to be retrieved and handled
        }

        public void SetData (object obj)
        {
            //For multi-call api data that has already been retrieved by ApiCaller.cs and sent here as an object that has yet to be decided
        }

        //Setup get and set for every variable 
    }
}
