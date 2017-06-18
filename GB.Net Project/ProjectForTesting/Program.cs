using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using GamebananaApi;
using Newtonsoft.Json;

namespace ProjectForTesting
{
    class Program
    {
        static WebClient web = new WebClient();
        static void Main(string[] args)
        {
            //APICaller ApiManager = new APICaller(web);
            //Console.WriteLine(ApiManager.Authenticate("Saghen", "RandomPassword"));
            //Console.WriteLine(ApiManager.Identify("Saghen"));
            //ApiManager.Data();
            AddObjectNames("", JsonConvert.DeserializeObject<List<object>>(web.DownloadString("http://api.gamebanana.com/Core/Item/Data?itemtype=Model&itemid=4023&fields=animated,apps_used,authors,catid,contestid,creator,cumulative_rating,date,description,Downloadable().bFileExists(),Downloadable().nGetFilesize(),Downloadable().sFileUrl(),downloads,feedback_instructions,file,Flags().aGetActiveFlagRowIds(),Flags().bSubmissionIsFlagged(),Flags().nGetActiveFlagsCount()")));
        }

        static public void AddObjectNames (string Fields, List<object> JSONDownload)
        {
            
        }
    }
}
