using System;
using System.Collections.Generic;
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
        bool animated;
        string appsUsed;
        Author authors;
        string catId;
        int contestId;
        string creator;
        double cumlativeRating;
        string date;
        string description;
        class DownloadInfo
        {
            bool fileExists;
            int getFileSize;
            string fileURL;
            string downloads;
        }
        string feedbackInstructions;
        string file;
        class Flags
        {
            int[] activeFlagRowIDs;
            bool isFlagged;
            int activeFlagCount;
        }
        string lastPostDate;
        string lastPostUserId;
        bool uvMapped;
        string mdate;
        string modnote;
        string name;
        int polycount;
        int postcount;
        double rating;
        string screenshots;
        int studioId;
        string text;
        bool isTextured;
        bool isTrashed;
        int tricount;
        int userId;
        int views;
        int votes;
        bool isWithheld;

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
