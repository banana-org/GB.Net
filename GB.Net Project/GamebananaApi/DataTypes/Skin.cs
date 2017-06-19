namespace GamebananaApi.DataTypes
{
    public class Skin
    {
        public readonly int itemID;
        public readonly string fields = "apps_used,authors,catid,contestid,creator,cumulative_rating,date,description,Downloadable().bFileExists(),Downloadable().nGetFilesize(),Downloadable().sFileUrl(),downloads,feedback_instructions,file,Flags().aGetActiveFlagRowIds(),lastpost_date,lastpost_userid,mdate,model_class,modnote,name,postcount,rating,render,screenshots,studioid,text,texture_class,Trash().bIsTrashed(),userid,views,votes,Withhold().bIsWithheld()";
        public Skin (int ID)
        {
            itemID = ID;
        }

        //So many variables
        public string apps_used { get; set; }
        public string authors { get; set; }
        public int catid { get; set; }
        public int contestid { get; set; }
        public string creator { get; set; }
        public float cumulative_rating { get; set; }
        public int date { get; set; }
        public string description { get; set; }
        public bool DownloadablebFileExists { get; set; }
        public int DownloadablenGetFilesize { get; set; }
        public string DownloadablesFileUrl { get; set; }
        public int downloads { get; set; }
        public string feedback_instructions { get; set; }
        public string file { get; set; }
        public int[] FlagsaGetActiveFlagRowIds { get; set; }
        public int lastpost_date { get; set; }
        public int lastpost_userid { get; set; }
        public int mdate { get; set; }
        public string model_class { get; set; }
        public string modnote { get; set; }
        public string name { get; set; }
        public int postcount { get; set; }
        public float rating { get; set; }
        public string render { get; set; }
        public string screenshots { get; set; }
        public int studioid { get; set; }
        public string text { get; set; }
        public string texture_class { get; set; }
        public bool TrashbIsTrashed { get; set; }
        public int userid { get; set; }
        public int views { get; set; }
        public int votes { get; set; }
        public bool WithholdbIsWithheld { get; set; }
    }
}
