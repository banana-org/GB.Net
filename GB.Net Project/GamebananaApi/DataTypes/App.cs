using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamebananaApi.DataTypes
{
    class App
    {
        public readonly int itemID;
        public readonly string fields = "contestid,date,description,feedback_instructions,lastpost_date,lastpost_userid,mdate,name,postcount,Posts().Postcount().nGetPostCount(),screenshots,text,Trash().bIsTrashed(),userid,views,Withhold().bIsWithheld()";

        public App(int ID)
        {
            itemID = ID;
        }

        public int contestid { get; set; }
        public int date { get; set; }
        public string description { get; set; }
        public string feedback_instructions { get; set; }
        public int lastpost_date { get; set; }
        public int lastpost_userid { get; set; }
        public int mdate { get; set; }
        public string name { get; set; }
        public int postcount { get; set; }
        public int PostsPostcountnGetPostCount { get; set; }
        public string screenshots { get; set; }
        public string text { get; set; }
        public bool TrashbIsTrashed { get; set; }
        public int userid { get; set; }
        public int views { get; set; }
        public bool WithholdbIsWithheld { get; set; }
    }
}
