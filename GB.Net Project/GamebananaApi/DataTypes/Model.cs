using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamebananaApi.DataTypes.SubTypes;
using Newtonsoft.Json;

namespace GamebananaApi.DataTypes
{
    class Model
    {
        //So many variables
        public bool Animated { get; set; }
        public string AppsUsed { get; set; }
        public Author Authors { get; set; }
        public string CatId { get; set; }
        public int ContestId { get; set; }
        public string Creator { get; set; }
        public double CumlativeRating { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public class DownloadInfo
        {
            public bool FileExists { get; set; }
            public int GetFileSize { get; set; }
            public string FileURL { get; set; }
            public string Downloads { get; set; }
        }
        public string FeedbackInstructions { get; set; }
        public string File { get; set; }
        public class Flags
        {
           public int[] ActiveFlagRowIDs { get; set; }
           public bool IsFlagged { get; set; }
           public int ActiveFlagCount { get; set; }
        }
        public string LastPostDate { get; set; }
        public string LastPostUserId { get; set; }
        public bool UvMapped { get; set; }
        public string Mdate { get; set; }
        public string Modnote { get; set; }
        public string Name { get; set; }
        public int Polycount { get; set; }
        public int Postcount { get; set; }
        public double Rating { get; set; }
        public string Screenshots { get; set; }
        public int StudioId { get; set; }
        public string Text { get; set; }
        public bool IsTextured { get; set; }
        public bool IsTrashed { get; set; }
        public int Tricount { get; set; }
        public int UserId { get; set; }
        public int Views { get; set; }
        public int Votes { get; set; }
        public bool IsWithheld { get; set; }

        public Model ()
        {

        }

        public void GetData (int ID, Model obj)
        {
            //For single-call api data to be retrieved and handled
        }

        public void SetData (object obj)
        {
            //For multi-call api data that has already been retrieved by ApiCaller.cs and sent here as an object that has yet to be decided
        }

        //Setup get and set for every variable 
    }
}
