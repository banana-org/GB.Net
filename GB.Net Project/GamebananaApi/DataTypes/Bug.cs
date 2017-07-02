using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamebananaApi.DataTypes
{
    class Bug
    {
        public readonly int itemID;
        public readonly string fields = "date,lastpost_date,lastpost_userid,mdate,name,postcount,Stats().nGetNewestSubmissionId(),Stats().nGetSubmissionCount(),text,Trash().bIsTrashed()";

        public Bug(int ID)
        {
            itemID = ID;
        }

        public int date { get; set; }
        public int lastpost_date { get; set; }
        public int lastpost_userid { get; set; }
        public int mdate { get; set; }
        public string name { get; set; }
        public int postcount { get; set; }
        public int PostsPostcountnGetPostCount { get; set; }
        public int StatsnGetNewestSubmissionId { get; set; }
        public int StatsnGetSubmissionCount { get; set; }
        public string text { get; set; }
        public bool TrashbIsTrashed { get; set; }
    }
}
