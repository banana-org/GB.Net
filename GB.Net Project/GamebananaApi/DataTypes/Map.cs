using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamebananaApi.DataTypes
{
    class Map
    {
        public readonly int itemID;
        public readonly string fields = "apps_used,authors,catid,contestid,creator,cumulative_rating,date,description,dev_state,Downloadable().nGetFilesize(),Downloadable().sFileUrl(),downloads,feedback_instructions,file,Flags().aGetActiveFlagRowIds(),Flags().nGetActiveFlagsCount(),lastpost_date,lastpost_userid,mdate,modnote,name,players,postcount,projectid,rating,Rating().SkillLevel().sGetGroupName(),Rating().SkillLevel().sGetTitle(),screenshots,Stats().nGetNewestSubmissionId(),Stats().nGetSubmissionCount(),studioid,tags,text,Trash().bIsTrashed(),userid,version,views,votes,Withhold().bIsWithheld()";
        public Map(int ID)
        {
            itemID = ID;
        }

        public string apps_used { get; set; }
        public string authors { get; set; }
        public int catid { get; set; }
        public int contestid { get; set; }
        public string creator { get; set; }
        public string cumulative_rating { get; set; }
        public int date { get; set; }
        public string description { get; set; }
        public string dev_state { get; set; }
        public int DownloadablenGetFilesize { get; set; }
        public string DownloadablesFileUrl { get; set; }
        public int downloads { get; set; }
        public string feedback_instructions { get; set; }   
        public string file { get; set; }
        public int[] FlagsaGetActiveFlagRowIds { get; set; }
        public int FlagsnGetActiveFlagsCount { get; set; }
        public int lastpost_date { get; set; }
        public int lastpost_userid { get; set; }
        public int mdate { get; set; }
        public string modnote { get; set; }
        public string name { get; set; }
        public string players { get; set; }
        public int postcount { get; set; }
        public int projectid { get; set; }
        public string rating { get; set; }
        public string RatingSkillLevelsGetGroupName { get; set; }
        public string RatingSkillLevelsGetTitle { get; set; }
        public string screenshots { get; set; }
        public int StatsnGetNewestSubmissionId { get; set; }
        public int StatsnGetSubmissionCount { get; set; }
        public int studioid { get; set; }
        public string tags { get; set; }
        public string text { get; set; }
        public bool TrashbIsTrashed { get; set; }
        public int userid { get; set; }
        public string version { get; set; }
        public int views { get; set; }
        public int votes { get; set; }
        public bool WithholdbIsWithheld { get; set; }
    }
}
