using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamebananaApi.DataTypes
{
    class Club
    {
        public readonly int itemID;
        public readonly string fields = "banner,date,mdate,members,Membership().aGetGuildLeaderRowIds(),Membership().aGetGuildMemberRowIds(),motto,name,postcount,text,Trash().bIsTrashed()";

        public Club(int ID)
        {
            itemID = ID;
        }

        public string banner { get; set; }
        public int date { get; set; }
        public int mdate { get; set; }
        public int members { get; set; }
        public int[] MembershipaGetGuildLeaderRowIds { get; set; }
        public int[] MembershipaGetGuildMemberRowIds { get; set; }
        public string motto { get; set; }
        public string name { get; set; }
        public int postcount { get; set; }
        public string text { get; set; }
        public bool TrashbIsTrashed { get; set; }
    }
}
