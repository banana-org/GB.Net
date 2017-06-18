using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamebananaApi
{
    class GamebananaDataType
    {
        string AffiliatedStudio;
        string BanStatus;
        class Buddies
        {
            bool HasBuddies;
            bool bHasOnlineBuddies;
            int BuddiesCount;
            int OnlineBuddiesCount;
            List<int>[] BuddyRowIds;
            List<int>[] OnlineBuddyRowIds;
        }
        class Contest
        {
            List<int>[] ActiveContestRowIdsParticipatedIn;
            bool IsParticipatingInActiveContests;
        }
        string date;
        class ProfileInfo
        {
            string Bio;
            string ContactInfo;
            DonationMethods[] donationMethods;
            class PcSpecs { string _sTitle; string _sValue; }
            string SoftwareKit;
        }

        class DonationMethods
        {
            string _sTitle;
            string _sValue;
            string _sInputType;
            string _sInputPlaceholder;
            string _sIconClasses;
            class _aValidator
            {
                string _regexValidPattern;
                string _sWarningMessage;
            }
            string _sValueTemplate;
            string _sFormattedValue;
        }



    /*Events().aGetActiveEventRowIdsParticipatedIn()
    Events().bIsParticipatingInActiveEvents()
    Gag().aGetSectionsMemberIsGaggedFrom()
    Gag().bIsGaggedFromAnySection()
    Guild().bMemberIsInAnyGuild()
    Initiatives().aGetInitiativeParticipation()
    Initiatives().bIsInInitiatives()
    lastpost_date
    lastpost_userid
    mdate
    Medals().aGetLegendaryMedals()
    Medals().aGetMedals()
    Medals().aGetNormalMedals()
    Medals().aGetRareMedals()
    Modgroup().aGetModgroupsMemberIsNotPartOf()
    Modgroup().aGetModgroupsMemberIsPartOf()
    Modgroup().bIsAdmin()
    Modgroup().bIsInAnyModgroup()
    Modgroup().bIsModerator()
    Modgroup().bIsSuperAdmin()
    Modgroup().bIsSuperModerator()
    name
    name
    OnlineStatus().bIsOnline()
    OnlineStatus().sGetLocation()
    OnlineStatus().tsGetLastSeenTime()
    OnlineStatus().tsGetSessionCreationTime()
    postcount
    Posts().LastPost().idGetLastPostMemberRow()
    Posts().LastPost().sGetPostText()
    Posts().LastPost().tsGetLastPostTime()
    Posts().Postcount().nGetPostCount()
    Stats().nGetNewestSubmissionId()
    Stats().nGetSubmissionCount()
    Trash().bIsTrashed()
    Unlocks().aGetEnabledUnlocks()
    Url().sGetActivationUrl()
    Url().sGetAvatarUrl()
    Url().sGetBuddiesUrl()
    Url().sGetBuddyRequestsUrl()
    Url().sGetEditUrl()
    Url().sGetHistoryUrl()
    Url().sGetItemBaseUrl()
    Url().sGetLoginUrl()
    Url().sGetMedalsUrl()
    Url().sGetPointsLogUrl()
    Url().sGetProfileUrl()
    Url().sGetReactivationUrl()
    Url().sGetResetPasswordUrl()
    Url().sGetSettingsUrl()
    Url().sGetSigUrl()
    Url().sGetStampsLogUrl()
    Url().sGetSubscribersUrl()
    Url().sGetTrashUrl()
    Url().sGetUntrashUrl()
    Url().sGetUpicUrl()
    Url().sHdAvatarUrl()
    user_title
    Watches().nGetWatchedSubmissionCount()
    Withholds().bHasWithheldSubmissions()*/
    }
}
