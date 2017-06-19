namespace GamebananaApi.DataTypes
{
    public class Model
    {
        public readonly int itemID;
        public readonly string fields = "animated,apps_used,authors,catid,contestid,creator,cumulative_rating,date,description,Downloadable().bFileExists(),Downloadable().nGetFilesize(),Downloadable().sFileUrl(),downloads,feedback_instructions,file,Flags().aGetActiveFlagRowIds(),Flags().nGetActiveFlagsCount(),lastpost_date,lastpost_userid,mapped,mdate,modnote,name,polycount,postcount,Posts().Postcount().nGetPostCount(),rating,screenshots,Stats().nGetNewestSubmissionId(),Stats().nGetSubmissionCount(),studioid,text,textured,Trash().bIsTrashed(),tricount,userid,views,votes,Withhold().bIsWithheld()";
        
        public Model (int ID)
        {
            itemID = ID;
        }
        
        //So many variables
        public string animated { get; set; }
        public string apps_used { get; set; }
        public string authors { get; set; }
        public int catid { get; set; }
        public int contestid { get; set; }
        public string creator { get; set; }
        public string cumulative_rating { get; set; }
        public int date { get; set; }
        public string description { get; set; }
        public bool Downloadableb_FileExists { get; set; }
        public int Downloadable_nGetFilesize { get; set; }
        public string Downloadable_sFileUrl { get; set; }
        public int downloads { get; set; }
        public string feedback_instructions { get; set; }
        public string file { get; set; }
        public int[] Flags_aGetActiveFlagRowIds { get; set; }
        public int Flags_nGetActiveFlagsCount { get; set; }
        public int lastpost_date { get; set; }
        public int lastpost_userid { get; set; }
        public string mapped { get; set; }
        public int mdate { get; set; }
        public string modnote { get; set; }
        public string name { get; set; }
        public string polycount { get; set; }
        public int postcount { get; set; }
        public int PostsPostcountnGetPostCount { get; set; }
        public string rating { get; set; }
        public string screenshots { get; set; }
        public int Stats_nGetNewestSubmissionId { get; set; }
        public int Stats_nGetSubmissionCount { get; set; }
        public int studioid { get; set; }
        public string text { get; set; }
        public string textured { get; set; }
        public bool TrashbIsTrashed { get; set; }
        public string tricount { get; set; }
        public int userid { get; set; }
        public int views { get; set; }
        public int votes { get; set; }
        public bool WithholdbIsWithheld { get; set; }
    }
}
