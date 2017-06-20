using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamebananaApi.DataTypes
{
    class Wip
    {
        public readonly int itemID;
        public readonly string fields = "catid,contestid,date,description,Downloadable().bFileExists(),Downloadable().nGetFilesize(),Downloadable().sFileUrl(),downloads,feedback_instructions,file,Flags().aGetActiveFlagRowIds(),Flags().bSubmissionIsFlagged(),Flags().nGetActiveFlagsCount(),lastpost_date,lastpost_userid,mdate,modnote,name,postcount,Posts().Postcount().nGetPostCount(),private,screenshots,studioid,text,Trash().bIsTrashed(),userid,views,Withhold().bIsWithheld()";

        public Wip(int ID)
        {
            itemID = ID;
        }

        public int catid { get; set; }
        public int contestid { get; set; }
        public int date { get; set; }
        public string description { get; set; }
        public bool DownloadablebFileExists { get; set; }
        public int DownloadablenGetFilesize { get; set; }
        public string DownloadablesFileUrl { get; set; }
        public int downloads { get; set; }
        public string feedback_instructions { get; set; }
        public bool file { get; set; }
        public int[] FlagsaGetActiveFlagRowIds { get; set; }
        public bool FlagsbSubmissionIsFlagged { get; set; }
        public int FlagsnGetActiveFlagsCount { get; set; }
        public int lastpost_date { get; set; }
        public int lastpost_userid { get; set; }
        public int mdate { get; set; }
        public string modnote { get; set; }
        public string name { get; set; }
        public int postcount { get; set; }
        public int PostsPostcountnGetPostCount { get; set; }
        public string _private { get; set; }
        public string screenshots { get; set; }
        public string studioid { get; set; }
        public string text { get; set; }
        public bool TrashbIsTrashed { get; set; }
        public int userid { get; set; }
        public int views { get; set; }
        public bool WithholdbIsWithheld { get; set; }

    }
}
