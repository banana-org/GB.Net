using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamebananaApi.DataTypes.SubTypes;
using Newtonsoft.Json;

namespace GamebananaApi.DataTypes
{
    public class Model
    {
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


        public Model()
        {

        }

        public void GetData(int ID, Model obj)
        {
            //For single-call api data to be retrieved and handled
        }

        public void SetData(object obj)
        {
            //For multi-call api data that has already been retrieved by ApiCaller.cs and sent here as an object that has yet to be decided
        }

        //Setup get and set for every variable 
    }
}
