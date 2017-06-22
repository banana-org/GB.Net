using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamebananaApi.DataTypes.ListDataTypes
{
    public class ListMember
    {
        public int id { get; set; }
        public string name { get; set; }

        public string fields = "name";
    }
}
