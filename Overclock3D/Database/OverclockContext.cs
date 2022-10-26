using Microsoft.EntityFrameworkCore;
using Overclock3D.Database.Models;

namespace Overclock3D.Database
{
    public partial class OverclockContext : DbContext
    {
        public OverclockContext()
        {
        }

        public OverclockContext(DbContextOptions<OverclockContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Access> Accesses { get; set; } = null!;
        public virtual DbSet<CompEntries2> CompEntries2s { get; set; } = null!;
        public virtual DbSet<CompEntries3> CompEntries3s { get; set; } = null!;
        public virtual DbSet<CompEntries4> CompEntries4s { get; set; } = null!;
        public virtual DbSet<CompEntry> CompEntries { get; set; } = null!;
        public virtual DbSet<ForumsAccess> ForumsAccesses { get; set; } = null!;
        public virtual DbSet<ForumsAdminhelp> ForumsAdminhelps { get; set; } = null!;
        public virtual DbSet<ForumsAdministrator> ForumsAdministrators { get; set; } = null!;
        public virtual DbSet<ForumsAdminlog> ForumsAdminlogs { get; set; } = null!;
        public virtual DbSet<ForumsAdminmessage> ForumsAdminmessages { get; set; } = null!;
        public virtual DbSet<ForumsAdminutil> ForumsAdminutils { get; set; } = null!;
        public virtual DbSet<ForumsAdvModule> ForumsAdvModules { get; set; } = null!;
        public virtual DbSet<ForumsAdvPage> ForumsAdvPages { get; set; } = null!;
        public virtual DbSet<ForumsAdvPagesUser> ForumsAdvPagesUsers { get; set; } = null!;
        public virtual DbSet<ForumsAdvSetting> ForumsAdvSettings { get; set; } = null!;
        public virtual DbSet<ForumsAdvSettinggroup> ForumsAdvSettinggroups { get; set; } = null!;
        public virtual DbSet<ForumsAlbum> ForumsAlbums { get; set; } = null!;
        public virtual DbSet<ForumsAlbumpicture> ForumsAlbumpictures { get; set; } = null!;
        public virtual DbSet<ForumsAlbumupdate> ForumsAlbumupdates { get; set; } = null!;
        public virtual DbSet<ForumsAnnouncement> ForumsAnnouncements { get; set; } = null!;
        public virtual DbSet<ForumsAnnouncementread> ForumsAnnouncementreads { get; set; } = null!;
        public virtual DbSet<ForumsAttachment> ForumsAttachments { get; set; } = null!;
        public virtual DbSet<ForumsAttachmentpermission> ForumsAttachmentpermissions { get; set; } = null!;
        public virtual DbSet<ForumsAttachmenttype> ForumsAttachmenttypes { get; set; } = null!;
        public virtual DbSet<ForumsAttachmentview> ForumsAttachmentviews { get; set; } = null!;
        public virtual DbSet<ForumsAvatar> ForumsAvatars { get; set; } = null!;
        public virtual DbSet<ForumsBbcode> ForumsBbcodes { get; set; } = null!;
        public virtual DbSet<ForumsBookmarksite> ForumsBookmarksites { get; set; } = null!;
        public virtual DbSet<ForumsCalendar> ForumsCalendars { get; set; } = null!;
        public virtual DbSet<ForumsCalendarcustomfield> ForumsCalendarcustomfields { get; set; } = null!;
        public virtual DbSet<ForumsCalendarmoderator> ForumsCalendarmoderators { get; set; } = null!;
        public virtual DbSet<ForumsCalendarpermission> ForumsCalendarpermissions { get; set; } = null!;
        public virtual DbSet<ForumsCannedreply> ForumsCannedreplies { get; set; } = null!;
        public virtual DbSet<ForumsCookieTracker> ForumsCookieTrackers { get; set; } = null!;
        public virtual DbSet<ForumsCpsession> ForumsCpsessions { get; set; } = null!;
        public virtual DbSet<ForumsCron> ForumsCrons { get; set; } = null!;
        public virtual DbSet<ForumsCronlog> ForumsCronlogs { get; set; } = null!;
        public virtual DbSet<ForumsCustomavatar> ForumsCustomavatars { get; set; } = null!;
        public virtual DbSet<ForumsCustomprofilepic> ForumsCustomprofilepics { get; set; } = null!;
        public virtual DbSet<ForumsDatastore> ForumsDatastores { get; set; } = null!;
        public virtual DbSet<ForumsDeletionlog> ForumsDeletionlogs { get; set; } = null!;
        public virtual DbSet<ForumsDiscussion> ForumsDiscussions { get; set; } = null!;
        public virtual DbSet<ForumsDiscussionread> ForumsDiscussionreads { get; set; } = null!;
        public virtual DbSet<ForumsDtoGarageComment> ForumsDtoGarageComments { get; set; } = null!;
        public virtual DbSet<ForumsDtoGarageImage> ForumsDtoGarageImages { get; set; } = null!;
        public virtual DbSet<ForumsDtoGarageSearch> ForumsDtoGarageSearches { get; set; } = null!;
        public virtual DbSet<ForumsDtoGarageVehicle> ForumsDtoGarageVehicles { get; set; } = null!;
        public virtual DbSet<ForumsEditlog> ForumsEditlogs { get; set; } = null!;
        public virtual DbSet<ForumsEvent> ForumsEvents { get; set; } = null!;
        public virtual DbSet<ForumsExternalcache> ForumsExternalcaches { get; set; } = null!;
        public virtual DbSet<ForumsFaq> ForumsFaqs { get; set; } = null!;
        public virtual DbSet<ForumsForum> ForumsForums { get; set; } = null!;
        public virtual DbSet<ForumsForumpermission> ForumsForumpermissions { get; set; } = null!;
        public virtual DbSet<ForumsForumprefixset> ForumsForumprefixsets { get; set; } = null!;
        public virtual DbSet<ForumsForumread> ForumsForumreads { get; set; } = null!;
        public virtual DbSet<ForumsGroupmessage> ForumsGroupmessages { get; set; } = null!;
        public virtual DbSet<ForumsGroupmessageHash> ForumsGroupmessageHashes { get; set; } = null!;
        public virtual DbSet<ForumsGroupread> ForumsGroupreads { get; set; } = null!;
        public virtual DbSet<ForumsHoliday> ForumsHolidays { get; set; } = null!;
        public virtual DbSet<ForumsHumanverify> ForumsHumanverifies { get; set; } = null!;
        public virtual DbSet<ForumsHvanswer> ForumsHvanswers { get; set; } = null!;
        public virtual DbSet<ForumsHvquestion> ForumsHvquestions { get; set; } = null!;
        public virtual DbSet<ForumsIcon> ForumsIcons { get; set; } = null!;
        public virtual DbSet<ForumsImagecategory> ForumsImagecategories { get; set; } = null!;
        public virtual DbSet<ForumsImagecategorypermission> ForumsImagecategorypermissions { get; set; } = null!;
        public virtual DbSet<ForumsImpexerror> ForumsImpexerrors { get; set; } = null!;
        public virtual DbSet<ForumsInfraction> ForumsInfractions { get; set; } = null!;
        public virtual DbSet<ForumsInfractionban> ForumsInfractionbans { get; set; } = null!;
        public virtual DbSet<ForumsInfractiongroup> ForumsInfractiongroups { get; set; } = null!;
        public virtual DbSet<ForumsInfractionlevel> ForumsInfractionlevels { get; set; } = null!;
        public virtual DbSet<ForumsLanguage> ForumsLanguages { get; set; } = null!;
        public virtual DbSet<ForumsMailqueue> ForumsMailqueues { get; set; } = null!;
        public virtual DbSet<ForumsMatchReport> ForumsMatchReports { get; set; } = null!;
        public virtual DbSet<ForumsModeration> ForumsModerations { get; set; } = null!;
        public virtual DbSet<ForumsModerator> ForumsModerators { get; set; } = null!;
        public virtual DbSet<ForumsModeratorlog> ForumsModeratorlogs { get; set; } = null!;
        public virtual DbSet<ForumsNotice> ForumsNotices { get; set; } = null!;
        public virtual DbSet<ForumsNoticecriterion> ForumsNoticecriteria { get; set; } = null!;
        public virtual DbSet<ForumsNoticedismissed> ForumsNoticedismisseds { get; set; } = null!;
        public virtual DbSet<ForumsPasswordhistory> ForumsPasswordhistories { get; set; } = null!;
        public virtual DbSet<ForumsPaymentapi> ForumsPaymentapis { get; set; } = null!;
        public virtual DbSet<ForumsPaymentinfo> ForumsPaymentinfos { get; set; } = null!;
        public virtual DbSet<ForumsPaymenttransaction> ForumsPaymenttransactions { get; set; } = null!;
        public virtual DbSet<ForumsPhrase> ForumsPhrases { get; set; } = null!;
        public virtual DbSet<ForumsPhrasetype> ForumsPhrasetypes { get; set; } = null!;
        public virtual DbSet<ForumsPicture> ForumsPictures { get; set; } = null!;
        public virtual DbSet<ForumsPicturecomment> ForumsPicturecomments { get; set; } = null!;
        public virtual DbSet<ForumsPicturecommentHash> ForumsPicturecommentHashes { get; set; } = null!;
        public virtual DbSet<ForumsPlugin> ForumsPlugins { get; set; } = null!;
        public virtual DbSet<ForumsPm> ForumsPms { get; set; } = null!;
        public virtual DbSet<ForumsPmreceipt> ForumsPmreceipts { get; set; } = null!;
        public virtual DbSet<ForumsPmtext> ForumsPmtexts { get; set; } = null!;
        public virtual DbSet<ForumsPmthrottle> ForumsPmthrottles { get; set; } = null!;
        public virtual DbSet<ForumsPodcast> ForumsPodcasts { get; set; } = null!;
        public virtual DbSet<ForumsPodcastitem> ForumsPodcastitems { get; set; } = null!;
        public virtual DbSet<ForumsPoll> ForumsPolls { get; set; } = null!;
        public virtual DbSet<ForumsPollvote> ForumsPollvotes { get; set; } = null!;
        public virtual DbSet<ForumsPost> ForumsPosts { get; set; } = null!;
        public virtual DbSet<ForumsPostedithistory> ForumsPostedithistories { get; set; } = null!;
        public virtual DbSet<ForumsPosthash> ForumsPosthashes { get; set; } = null!;
        public virtual DbSet<ForumsPostindex> ForumsPostindices { get; set; } = null!;
        public virtual DbSet<ForumsPostlog> ForumsPostlogs { get; set; } = null!;
        public virtual DbSet<ForumsPostparsed> ForumsPostparseds { get; set; } = null!;
        public virtual DbSet<ForumsPrefix> ForumsPrefixes { get; set; } = null!;
        public virtual DbSet<ForumsPrefixpermission> ForumsPrefixpermissions { get; set; } = null!;
        public virtual DbSet<ForumsPrefixset> ForumsPrefixsets { get; set; } = null!;
        public virtual DbSet<ForumsProduct> ForumsProducts { get; set; } = null!;
        public virtual DbSet<ForumsProductcode> ForumsProductcodes { get; set; } = null!;
        public virtual DbSet<ForumsProductdependency> ForumsProductdependencies { get; set; } = null!;
        public virtual DbSet<ForumsProfileblockprivacy> ForumsProfileblockprivacies { get; set; } = null!;
        public virtual DbSet<ForumsProfilefield> ForumsProfilefields { get; set; } = null!;
        public virtual DbSet<ForumsProfilefieldcategory> ForumsProfilefieldcategories { get; set; } = null!;
        public virtual DbSet<ForumsProfilevisitor> ForumsProfilevisitors { get; set; } = null!;
        public virtual DbSet<ForumsRank> ForumsRanks { get; set; } = null!;
        public virtual DbSet<ForumsReminder> ForumsReminders { get; set; } = null!;
        public virtual DbSet<ForumsReputation> ForumsReputations { get; set; } = null!;
        public virtual DbSet<ForumsReputationlevel> ForumsReputationlevels { get; set; } = null!;
        public virtual DbSet<ForumsRssfeed> ForumsRssfeeds { get; set; } = null!;
        public virtual DbSet<ForumsRsslog> ForumsRsslogs { get; set; } = null!;
        public virtual DbSet<ForumsSearch> ForumsSearches { get; set; } = null!;
        public virtual DbSet<ForumsSession> ForumsSessions { get; set; } = null!;
        public virtual DbSet<ForumsSetting> ForumsSettings { get; set; } = null!;
        public virtual DbSet<ForumsSettinggroup> ForumsSettinggroups { get; set; } = null!;
        public virtual DbSet<ForumsSigparsed> ForumsSigparseds { get; set; } = null!;
        public virtual DbSet<ForumsSigpic> ForumsSigpics { get; set; } = null!;
        public virtual DbSet<ForumsSkSpamlog> ForumsSkSpamlogs { get; set; } = null!;
        public virtual DbSet<ForumsSmilie> ForumsSmilies { get; set; } = null!;
        public virtual DbSet<ForumsSocialgroup> ForumsSocialgroups { get; set; } = null!;
        public virtual DbSet<ForumsSocialgroupcategory> ForumsSocialgroupcategories { get; set; } = null!;
        public virtual DbSet<ForumsSocialgroupicon> ForumsSocialgroupicons { get; set; } = null!;
        public virtual DbSet<ForumsSocialgroupmember> ForumsSocialgroupmembers { get; set; } = null!;
        public virtual DbSet<ForumsSocialgrouppicture> ForumsSocialgrouppictures { get; set; } = null!;
        public virtual DbSet<ForumsSpamlog> ForumsSpamlogs { get; set; } = null!;
        public virtual DbSet<ForumsStat> ForumsStats { get; set; } = null!;
        public virtual DbSet<ForumsStrike> ForumsStrikes { get; set; } = null!;
        public virtual DbSet<ForumsStyle> ForumsStyles { get; set; } = null!;
        public virtual DbSet<ForumsSubscribediscussion> ForumsSubscribediscussions { get; set; } = null!;
        public virtual DbSet<ForumsSubscribeevent> ForumsSubscribeevents { get; set; } = null!;
        public virtual DbSet<ForumsSubscribeforum> ForumsSubscribeforums { get; set; } = null!;
        public virtual DbSet<ForumsSubscribegroup> ForumsSubscribegroups { get; set; } = null!;
        public virtual DbSet<ForumsSubscribethread> ForumsSubscribethreads { get; set; } = null!;
        public virtual DbSet<ForumsSubscription> ForumsSubscriptions { get; set; } = null!;
        public virtual DbSet<ForumsSubscriptionlog> ForumsSubscriptionlogs { get; set; } = null!;
        public virtual DbSet<ForumsSubscriptionpermission> ForumsSubscriptionpermissions { get; set; } = null!;
        public virtual DbSet<ForumsTachyforumcounter> ForumsTachyforumcounters { get; set; } = null!;
        public virtual DbSet<ForumsTachyforumpost> ForumsTachyforumposts { get; set; } = null!;
        public virtual DbSet<ForumsTachythreadcounter> ForumsTachythreadcounters { get; set; } = null!;
        public virtual DbSet<ForumsTachythreadpost> ForumsTachythreadposts { get; set; } = null!;
        public virtual DbSet<ForumsTag> ForumsTags { get; set; } = null!;
        public virtual DbSet<ForumsTagsearch> ForumsTagsearches { get; set; } = null!;
        public virtual DbSet<ForumsTagthread> ForumsTagthreads { get; set; } = null!;
        public virtual DbSet<ForumsTemplate> ForumsTemplates { get; set; } = null!;
        public virtual DbSet<ForumsTemplatehistory> ForumsTemplatehistories { get; set; } = null!;
        public virtual DbSet<ForumsThread> ForumsThreads { get; set; } = null!;
        public virtual DbSet<ForumsThreadrate> ForumsThreadrates { get; set; } = null!;
        public virtual DbSet<ForumsThreadread> ForumsThreadreads { get; set; } = null!;
        public virtual DbSet<ForumsThreadredirect> ForumsThreadredirects { get; set; } = null!;
        public virtual DbSet<ForumsThreadview> ForumsThreadviews { get; set; } = null!;
        public virtual DbSet<ForumsTrackWhitelist> ForumsTrackWhitelists { get; set; } = null!;
        public virtual DbSet<ForumsUpgradelog> ForumsUpgradelogs { get; set; } = null!;
        public virtual DbSet<ForumsUser> ForumsUsers { get; set; } = null!;
        public virtual DbSet<ForumsUseractivation> ForumsUseractivations { get; set; } = null!;
        public virtual DbSet<ForumsUserban> ForumsUserbans { get; set; } = null!;
        public virtual DbSet<ForumsUserchangelog> ForumsUserchangelogs { get; set; } = null!;
        public virtual DbSet<ForumsUsercss> ForumsUsercsses { get; set; } = null!;
        public virtual DbSet<ForumsUsercsscache> ForumsUsercsscaches { get; set; } = null!;
        public virtual DbSet<ForumsUserfield> ForumsUserfields { get; set; } = null!;
        public virtual DbSet<ForumsUsergroup> ForumsUsergroups { get; set; } = null!;
        public virtual DbSet<ForumsUsergroupleader> ForumsUsergroupleaders { get; set; } = null!;
        public virtual DbSet<ForumsUsergrouprequest> ForumsUsergrouprequests { get; set; } = null!;
        public virtual DbSet<ForumsUserlist> ForumsUserlists { get; set; } = null!;
        public virtual DbSet<ForumsUsernote> ForumsUsernotes { get; set; } = null!;
        public virtual DbSet<ForumsUserpromotion> ForumsUserpromotions { get; set; } = null!;
        public virtual DbSet<ForumsUsertextfield> ForumsUsertextfields { get; set; } = null!;
        public virtual DbSet<ForumsUsertitle> ForumsUsertitles { get; set; } = null!;
        public virtual DbSet<ForumsVbfield> ForumsVbfields { get; set; } = null!;
        public virtual DbSet<ForumsVisitormessage> ForumsVisitormessages { get; set; } = null!;
        public virtual DbSet<ForumsVisitormessageHash> ForumsVisitormessageHashes { get; set; } = null!;
        public virtual DbSet<ForumsWord> ForumsWords { get; set; } = null!;
        public virtual DbSet<Hit> Hits { get; set; } = null!;
        public virtual DbSet<ImagesList> ImagesLists { get; set; } = null!;
        public virtual DbSet<IpbadminLog> IpbadminLogs { get; set; } = null!;
        public virtual DbSet<IpbadminLoginLog> IpbadminLoginLogs { get; set; } = null!;
        public virtual DbSet<IpbadminPermissionRow> IpbadminPermissionRows { get; set; } = null!;
        public virtual DbSet<Ipbannouncement> Ipbannouncements { get; set; } = null!;
        public virtual DbSet<IpbapiLog> IpbapiLogs { get; set; } = null!;
        public virtual DbSet<IpbapiUser> IpbapiUsers { get; set; } = null!;
        public virtual DbSet<Ipbattachment> Ipbattachments { get; set; } = null!;
        public virtual DbSet<IpbattachmentsType> IpbattachmentsTypes { get; set; } = null!;
        public virtual DbSet<Ipbbadword> Ipbbadwords { get; set; } = null!;
        public virtual DbSet<Ipbbanfilter> Ipbbanfilters { get; set; } = null!;
        public virtual DbSet<IpbbbcodeMediatag> IpbbbcodeMediatags { get; set; } = null!;
        public virtual DbSet<IpbbulkMail> IpbbulkMails { get; set; } = null!;
        public virtual DbSet<IpbcacheSimple> IpbcacheSimples { get; set; } = null!;
        public virtual DbSet<IpbcacheStore> IpbcacheStores { get; set; } = null!;
        public virtual DbSet<Ipbcaptcha> Ipbcaptchas { get; set; } = null!;
        public virtual DbSet<IpbcontentCachePost> IpbcontentCachePosts { get; set; } = null!;
        public virtual DbSet<IpbcontentCacheSig> IpbcontentCacheSigs { get; set; } = null!;
        public virtual DbSet<IpbconvApp> IpbconvApps { get; set; } = null!;
        public virtual DbSet<IpbconvLink> IpbconvLinks { get; set; } = null!;
        public virtual DbSet<IpbconvergeLocal> IpbconvergeLocals { get; set; } = null!;
        public virtual DbSet<IpbcoreApplication> IpbcoreApplications { get; set; } = null!;
        public virtual DbSet<IpbcoreEditorAutosave> IpbcoreEditorAutosaves { get; set; } = null!;
        public virtual DbSet<IpbcoreGeolocationCache> IpbcoreGeolocationCaches { get; set; } = null!;
        public virtual DbSet<IpbcoreHook> IpbcoreHooks { get; set; } = null!;
        public virtual DbSet<IpbcoreHooksFile> IpbcoreHooksFiles { get; set; } = null!;
        public virtual DbSet<IpbcoreIncomingEmail> IpbcoreIncomingEmails { get; set; } = null!;
        public virtual DbSet<IpbcoreIncomingEmailLog> IpbcoreIncomingEmailLogs { get; set; } = null!;
        public virtual DbSet<IpbcoreInlineMessage> IpbcoreInlineMessages { get; set; } = null!;
        public virtual DbSet<IpbcoreItemMarker> IpbcoreItemMarkers { get; set; } = null!;
        public virtual DbSet<IpbcoreItemMarkersStorage> IpbcoreItemMarkersStorages { get; set; } = null!;
        public virtual DbSet<IpbcoreLike> IpbcoreLikes { get; set; } = null!;
        public virtual DbSet<IpbcoreLikeCache> IpbcoreLikeCaches { get; set; } = null!;
        public virtual DbSet<IpbcoreRssImported> IpbcoreRssImporteds { get; set; } = null!;
        public virtual DbSet<IpbcoreShareLink> IpbcoreShareLinks { get; set; } = null!;
        public virtual DbSet<IpbcoreShareLinksCache> IpbcoreShareLinksCaches { get; set; } = null!;
        public virtual DbSet<IpbcoreShareLinksLog> IpbcoreShareLinksLogs { get; set; } = null!;
        public virtual DbSet<IpbcoreSoftDeleteLog> IpbcoreSoftDeleteLogs { get; set; } = null!;
        public virtual DbSet<IpbcoreSysConfSetting> IpbcoreSysConfSettings { get; set; } = null!;
        public virtual DbSet<IpbcoreSysCpSession> IpbcoreSysCpSessions { get; set; } = null!;
        public virtual DbSet<IpbcoreSysLang> IpbcoreSysLangs { get; set; } = null!;
        public virtual DbSet<IpbcoreSysLangWord> IpbcoreSysLangWords { get; set; } = null!;
        public virtual DbSet<IpbcoreSysLogin> IpbcoreSysLogins { get; set; } = null!;
        public virtual DbSet<IpbcoreSysModule> IpbcoreSysModules { get; set; } = null!;
        public virtual DbSet<IpbcoreSysSettingsTitle> IpbcoreSysSettingsTitles { get; set; } = null!;
        public virtual DbSet<IpbcoreTag> IpbcoreTags { get; set; } = null!;
        public virtual DbSet<IpbcoreTagsCache> IpbcoreTagsCaches { get; set; } = null!;
        public virtual DbSet<IpbcoreTagsPerm> IpbcoreTagsPerms { get; set; } = null!;
        public virtual DbSet<IpbcoreUagent> IpbcoreUagents { get; set; } = null!;
        public virtual DbSet<IpbcoreUagentGroup> IpbcoreUagentGroups { get; set; } = null!;
        public virtual DbSet<IpbcustomBbcode> IpbcustomBbcodes { get; set; } = null!;
        public virtual DbSet<IpbdnamesChange> IpbdnamesChanges { get; set; } = null!;
        public virtual DbSet<Ipbemoticon> Ipbemoticons { get; set; } = null!;
        public virtual DbSet<IpberrorLog> IpberrorLogs { get; set; } = null!;
        public virtual DbSet<Ipbfaq> Ipbfaqs { get; set; } = null!;
        public virtual DbSet<Ipbforum> Ipbforums { get; set; } = null!;
        public virtual DbSet<IpbforumPerm> IpbforumPerms { get; set; } = null!;
        public virtual DbSet<Ipbgroup> Ipbgroups { get; set; } = null!;
        public virtual DbSet<IpbignoredUser> IpbignoredUsers { get; set; } = null!;
        public virtual DbSet<IpbinlineNotification> IpbinlineNotifications { get; set; } = null!;
        public virtual DbSet<IpbloginMethod> IpbloginMethods { get; set; } = null!;
        public virtual DbSet<IpbmailErrorLog> IpbmailErrorLogs { get; set; } = null!;
        public virtual DbSet<IpbmailQueue> IpbmailQueues { get; set; } = null!;
        public virtual DbSet<Ipbmember> Ipbmembers { get; set; } = null!;
        public virtual DbSet<IpbmemberStatusAction> IpbmemberStatusActions { get; set; } = null!;
        public virtual DbSet<IpbmemberStatusReply> IpbmemberStatusReplies { get; set; } = null!;
        public virtual DbSet<IpbmemberStatusUpdate> IpbmemberStatusUpdates { get; set; } = null!;
        public virtual DbSet<IpbmembersPartial> IpbmembersPartials { get; set; } = null!;
        public virtual DbSet<IpbmessagePost> IpbmessagePosts { get; set; } = null!;
        public virtual DbSet<IpbmessageTopic> IpbmessageTopics { get; set; } = null!;
        public virtual DbSet<IpbmessageTopicUserMap> IpbmessageTopicUserMaps { get; set; } = null!;
        public virtual DbSet<IpbmobileNotification> IpbmobileNotifications { get; set; } = null!;
        public virtual DbSet<IpbmodQueuedItem> IpbmodQueuedItems { get; set; } = null!;
        public virtual DbSet<Ipbmoderator> Ipbmoderators { get; set; } = null!;
        public virtual DbSet<IpbmoderatorLog> IpbmoderatorLogs { get; set; } = null!;
        public virtual DbSet<IpbopenidTemp> IpbopenidTemps { get; set; } = null!;
        public virtual DbSet<IpbpermissionIndex> IpbpermissionIndices { get; set; } = null!;
        public virtual DbSet<IpbpfieldsContent> IpbpfieldsContents { get; set; } = null!;
        public virtual DbSet<IpbpfieldsDatum> IpbpfieldsData { get; set; } = null!;
        public virtual DbSet<IpbpfieldsGroup> IpbpfieldsGroups { get; set; } = null!;
        public virtual DbSet<Ipbpoll> Ipbpolls { get; set; } = null!;
        public virtual DbSet<Ipbpost> Ipbposts { get; set; } = null!;
        public virtual DbSet<IpbprofileFriend> IpbprofileFriends { get; set; } = null!;
        public virtual DbSet<IpbprofileFriendsFlood> IpbprofileFriendsFloods { get; set; } = null!;
        public virtual DbSet<IpbprofilePortal> IpbprofilePortals { get; set; } = null!;
        public virtual DbSet<IpbprofilePortalView> IpbprofilePortalViews { get; set; } = null!;
        public virtual DbSet<IpbprofileRating> IpbprofileRatings { get; set; } = null!;
        public virtual DbSet<IpbquestionAndAnswer> IpbquestionAndAnswers { get; set; } = null!;
        public virtual DbSet<IpbrcClass> IpbrcClasses { get; set; } = null!;
        public virtual DbSet<IpbrcComment> IpbrcComments { get; set; } = null!;
        public virtual DbSet<IpbrcModpref> IpbrcModprefs { get; set; } = null!;
        public virtual DbSet<IpbrcReport> IpbrcReports { get; set; } = null!;
        public virtual DbSet<IpbrcReportsIndex> IpbrcReportsIndices { get; set; } = null!;
        public virtual DbSet<IpbrcStatus> IpbrcStatuses { get; set; } = null!;
        public virtual DbSet<IpbrcStatusSev> IpbrcStatusSevs { get; set; } = null!;
        public virtual DbSet<IpbreputationCache> IpbreputationCaches { get; set; } = null!;
        public virtual DbSet<IpbreputationIndex> IpbreputationIndices { get; set; } = null!;
        public virtual DbSet<IpbreputationLevel> IpbreputationLevels { get; set; } = null!;
        public virtual DbSet<IpbrssExport> IpbrssExports { get; set; } = null!;
        public virtual DbSet<IpbrssImport> IpbrssImports { get; set; } = null!;
        public virtual DbSet<IpbrssImported> IpbrssImporteds { get; set; } = null!;
        public virtual DbSet<IpbsearchSession> IpbsearchSessions { get; set; } = null!;
        public virtual DbSet<Ipbsession> Ipbsessions { get; set; } = null!;
        public virtual DbSet<IpbskinCache> IpbskinCaches { get; set; } = null!;
        public virtual DbSet<IpbskinCollection> IpbskinCollections { get; set; } = null!;
        public virtual DbSet<IpbskinCss> IpbskinCsses { get; set; } = null!;
        public virtual DbSet<IpbskinCssPreviou> IpbskinCssPrevious { get; set; } = null!;
        public virtual DbSet<IpbskinGeneratorSession> IpbskinGeneratorSessions { get; set; } = null!;
        public virtual DbSet<IpbskinMergeChange> IpbskinMergeChanges { get; set; } = null!;
        public virtual DbSet<IpbskinMergeSession> IpbskinMergeSessions { get; set; } = null!;
        public virtual DbSet<IpbskinReplacement> IpbskinReplacements { get; set; } = null!;
        public virtual DbSet<IpbskinTemplate> IpbskinTemplates { get; set; } = null!;
        public virtual DbSet<IpbskinTemplatesCache> IpbskinTemplatesCaches { get; set; } = null!;
        public virtual DbSet<IpbskinTemplatesPreviou> IpbskinTemplatesPrevious { get; set; } = null!;
        public virtual DbSet<IpbskinUrlMapping> IpbskinUrlMappings { get; set; } = null!;
        public virtual DbSet<IpbspamServiceLog> IpbspamServiceLogs { get; set; } = null!;
        public virtual DbSet<IpbspiderLog> IpbspiderLogs { get; set; } = null!;
        public virtual DbSet<IpbtagsIndex> IpbtagsIndices { get; set; } = null!;
        public virtual DbSet<IpbtaskLog> IpbtaskLogs { get; set; } = null!;
        public virtual DbSet<IpbtaskManager> IpbtaskManagers { get; set; } = null!;
        public virtual DbSet<IpbtemplateSandr> IpbtemplateSandrs { get; set; } = null!;
        public virtual DbSet<Ipbtitle> Ipbtitles { get; set; } = null!;
        public virtual DbSet<Ipbtopic> Ipbtopics { get; set; } = null!;
        public virtual DbSet<IpbtopicMmod> IpbtopicMmods { get; set; } = null!;
        public virtual DbSet<IpbtopicRating> IpbtopicRatings { get; set; } = null!;
        public virtual DbSet<IpbtopicView> IpbtopicViews { get; set; } = null!;
        public virtual DbSet<IpbtwitterConnect> IpbtwitterConnects { get; set; } = null!;
        public virtual DbSet<IpbupgradeHistory> IpbupgradeHistories { get; set; } = null!;
        public virtual DbSet<IpbupgradeSession> IpbupgradeSessions { get; set; } = null!;
        public virtual DbSet<Ipbvalidating> Ipbvalidatings { get; set; } = null!;
        public virtual DbSet<Ipbvoter> Ipbvoters { get; set; } = null!;
        public virtual DbSet<IpbwarnLog> IpbwarnLogs { get; set; } = null!;
        public virtual DbSet<Link> Links { get; set; } = null!;
        public virtual DbSet<Tblcomp> Tblcomps { get; set; } = null!;
        public virtual DbSet<TblcompDell> TblcompDells { get; set; } = null!;
        public virtual DbSet<Tblcontent> Tblcontents { get; set; } = null!;
        public virtual DbSet<TblcontentBak> TblcontentBaks { get; set; } = null!;
        public virtual DbSet<TblcontentBak2> TblcontentBak2s { get; set; } = null!;
        public virtual DbSet<Tblcontentdatum> Tblcontentdata { get; set; } = null!;
        public virtual DbSet<Tbllogin> Tbllogins { get; set; } = null!;
        public virtual DbSet<Tblpoll> Tblpolls { get; set; } = null!;
        public virtual DbSet<Tblsnippet> Tblsnippets { get; set; } = null!;
        public virtual DbSet<Tbluser> Tblusers { get; set; } = null!;

        // Unable to generate entity type for table 'forums_DTO_garage_feature' since its primary key could not be scaffolded. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Access>(entity =>
            {
                entity.HasKey(e => new { e.Ip, e.Date })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("access");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Ip, e.Date, e.CountLnk, e.CountImg }, "access");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .HasColumnName("ip");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.CountImg).HasColumnName("count_img");

                entity.Property(e => e.CountLnk).HasColumnName("count_lnk");
            });

            modelBuilder.Entity<CompEntries2>(entity =>
            {
                entity.ToTable("comp_entries2");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Ip)
                    .HasMaxLength(255)
                    .HasColumnName("ip");

                entity.Property(e => e.TheDate)
                    .HasColumnType("datetime")
                    .HasColumnName("theDate");

                entity.Property(e => e.UserRef).HasColumnName("userRef");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<CompEntries3>(entity =>
            {
                entity.ToTable("comp_entries3");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age)
                    .HasMaxLength(11)
                    .HasColumnName("age");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.Ip)
                    .HasMaxLength(255)
                    .HasColumnName("ip");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("location");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.TheDate)
                    .HasColumnType("datetime")
                    .HasColumnName("theDate");

                entity.Property(e => e.UserRef).HasColumnName("userRef");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<CompEntries4>(entity =>
            {
                entity.ToTable("comp_entries4");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer)
                    .HasColumnType("text")
                    .HasColumnName("answer");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Ip)
                    .HasMaxLength(255)
                    .HasColumnName("ip");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("location");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.TheDate)
                    .HasColumnType("datetime")
                    .HasColumnName("theDate");

                entity.Property(e => e.UserRef).HasColumnName("userRef");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<CompEntry>(entity =>
            {
                entity.ToTable("comp_entries");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Ip)
                    .HasMaxLength(255)
                    .HasColumnName("ip");

                entity.Property(e => e.TheDate)
                    .HasColumnType("datetime")
                    .HasColumnName("theDate");

                entity.Property(e => e.UserRef).HasColumnName("userRef");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<ForumsAccess>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Forumid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_access");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Accessmask).HasColumnName("accessmask");
            });

            modelBuilder.Entity<ForumsAdminhelp>(entity =>
            {
                entity.HasKey(e => e.Adminhelpid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_adminhelp");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Script, e.Action, e.Optionname }, "phraseunique")
                    .IsUnique();

                entity.Property(e => e.Adminhelpid).HasColumnName("adminhelpid");

                entity.Property(e => e.Action)
                    .HasMaxLength(25)
                    .HasColumnName("action")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Displayorder)
                    .HasColumnName("displayorder")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Optionname)
                    .HasMaxLength(100)
                    .HasColumnName("optionname")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Product)
                    .HasMaxLength(25)
                    .HasColumnName("product")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Script)
                    .HasMaxLength(50)
                    .HasColumnName("script")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Volatile).HasColumnName("volatile");
            });

            modelBuilder.Entity<ForumsAdministrator>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_administrator");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.Adminpermissions).HasColumnName("adminpermissions");

                entity.Property(e => e.Cssprefs)
                    .HasMaxLength(250)
                    .HasColumnName("cssprefs")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dismissednews)
                    .HasColumnType("text")
                    .HasColumnName("dismissednews");

                entity.Property(e => e.Dtogarageperms)
                    .HasColumnName("dtogarageperms")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Languageid).HasColumnName("languageid");

                entity.Property(e => e.Navprefs)
                    .HasColumnType("mediumtext")
                    .HasColumnName("navprefs");

                entity.Property(e => e.Notes)
                    .HasColumnType("mediumtext")
                    .HasColumnName("notes");
            });

            modelBuilder.Entity<ForumsAdminlog>(entity =>
            {
                entity.HasKey(e => e.Adminlogid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_adminlog");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Script, e.Action }, "script_action");

                entity.Property(e => e.Adminlogid).HasColumnName("adminlogid");

                entity.Property(e => e.Action)
                    .HasMaxLength(20)
                    .HasColumnName("action")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Extrainfo)
                    .HasMaxLength(200)
                    .HasColumnName("extrainfo")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(45)
                    .HasColumnName("ipaddress")
                    .IsFixedLength();

                entity.Property(e => e.Script)
                    .HasMaxLength(50)
                    .HasColumnName("script")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsAdminmessage>(entity =>
            {
                entity.HasKey(e => e.Adminmessageid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_adminmessage");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Script, e.Action }, "script_action");

                entity.HasIndex(e => e.Varname, "varname");

                entity.Property(e => e.Adminmessageid).HasColumnName("adminmessageid");

                entity.Property(e => e.Action)
                    .HasMaxLength(20)
                    .HasColumnName("action")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Dismissable).HasColumnName("dismissable");

                entity.Property(e => e.Execurl)
                    .HasColumnType("mediumtext")
                    .HasColumnName("execurl");

                entity.Property(e => e.Method)
                    .HasColumnType("enum('get','post')")
                    .HasColumnName("method")
                    .HasDefaultValueSql("'post'");

                entity.Property(e => e.Script)
                    .HasMaxLength(50)
                    .HasColumnName("script")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('undone','done','dismissed')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'undone'");

                entity.Property(e => e.Statususerid).HasColumnName("statususerid");

                entity.Property(e => e.Varname)
                    .HasMaxLength(250)
                    .HasColumnName("varname")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsAdminutil>(entity =>
            {
                entity.HasKey(e => e.Title)
                    .HasName("PRIMARY");

                entity.ToTable("forums_adminutil");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Text)
                    .HasColumnType("mediumtext")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<ForumsAdvModule>(entity =>
            {
                entity.HasKey(e => e.Modid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_adv_modules");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Identifier, "identifier");

                entity.Property(e => e.Modid).HasColumnName("modid");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Altshell)
                    .HasMaxLength(255)
                    .HasColumnName("altshell");

                entity.Property(e => e.CodeParsed)
                    .HasColumnType("text")
                    .HasColumnName("code_parsed");

                entity.Property(e => e.Colspan).HasColumnName("colspan");

                entity.Property(e => e.DynaPrefix)
                    .HasMaxLength(50)
                    .HasColumnName("dyna_prefix");

                entity.Property(e => e.Filename)
                    .HasColumnType("text")
                    .HasColumnName("filename");

                entity.Property(e => e.Formcode)
                    .HasColumnType("text")
                    .HasColumnName("formcode");

                entity.Property(e => e.Identifier)
                    .HasMaxLength(100)
                    .HasColumnName("identifier")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Inctype)
                    .HasMaxLength(20)
                    .HasColumnName("inctype")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .HasColumnName("link")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Options).HasColumnName("options");

                entity.Property(e => e.Parent)
                    .HasMaxLength(255)
                    .HasColumnName("parent")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Templatelist)
                    .HasColumnType("text")
                    .HasColumnName("templatelist");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userperms)
                    .HasMaxLength(255)
                    .HasColumnName("userperms")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Useshell).HasColumnName("useshell");
            });

            modelBuilder.Entity<ForumsAdvPage>(entity =>
            {
                entity.HasKey(e => e.Pageid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_adv_pages");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Name, "name")
                    .IsUnique();

                entity.Property(e => e.Pageid).HasColumnName("pageid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Advanced)
                    .HasColumnType("text")
                    .HasColumnName("advanced");

                entity.Property(e => e.Cleanoutput).HasColumnName("cleanoutput");

                entity.Property(e => e.Colspan).HasColumnName("colspan");

                entity.Property(e => e.CustomTitle)
                    .HasMaxLength(255)
                    .HasColumnName("custom_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Customize).HasColumnName("customize");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Formcode)
                    .HasColumnType("text")
                    .HasColumnName("formcode");

                entity.Property(e => e.Meta)
                    .HasColumnType("text")
                    .HasColumnName("meta");

                entity.Property(e => e.Modules)
                    .HasColumnType("text")
                    .HasColumnName("modules");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Parentlist)
                    .HasMaxLength(255)
                    .HasColumnName("parentlist")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Styleid).HasColumnName("styleid");

                entity.Property(e => e.Template)
                    .HasColumnType("text")
                    .HasColumnName("template");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userperms)
                    .HasMaxLength(255)
                    .HasColumnName("userperms")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Useshell).HasColumnName("useshell");
            });

            modelBuilder.Entity<ForumsAdvPagesUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_adv_pages_user");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Pageid, e.Userid }, "pageid")
                    .IsUnique();

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Layout)
                    .HasColumnType("text")
                    .HasColumnName("layout");

                entity.Property(e => e.Pageid).HasColumnName("pageid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsAdvSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_adv_setting");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Defaultvalue)
                    .HasMaxLength(250)
                    .HasColumnName("defaultvalue")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Grouptitle)
                    .HasMaxLength(50)
                    .HasColumnName("grouptitle")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Optioncode)
                    .HasColumnType("mediumtext")
                    .HasColumnName("optioncode");

                entity.Property(e => e.Serialize).HasColumnName("serialize");

                entity.Property(e => e.Value)
                    .HasColumnType("mediumtext")
                    .HasColumnName("value");

                entity.Property(e => e.Varname)
                    .HasMaxLength(100)
                    .HasColumnName("varname")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsAdvSettinggroup>(entity =>
            {
                entity.HasKey(e => e.Grouptitle)
                    .HasName("PRIMARY");

                entity.ToTable("forums_adv_settinggroup");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Grouptitle)
                    .HasMaxLength(50)
                    .HasColumnName("grouptitle")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            });

            modelBuilder.Entity<ForumsAlbum>(entity =>
            {
                entity.HasKey(e => e.Albumid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_album");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Userid, e.Lastpicturedate }, "userid");

                entity.Property(e => e.Albumid).HasColumnName("albumid");

                entity.Property(e => e.Coverpictureid).HasColumnName("coverpictureid");

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Description)
                    .HasColumnType("mediumtext")
                    .HasColumnName("description");

                entity.Property(e => e.Lastpicturedate).HasColumnName("lastpicturedate");

                entity.Property(e => e.Moderation).HasColumnName("moderation");

                entity.Property(e => e.State)
                    .HasColumnType("enum('public','private','profile')")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<ForumsAlbumpicture>(entity =>
            {
                entity.HasKey(e => new { e.Albumid, e.Pictureid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_albumpicture");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Albumid, e.Dateline }, "albumid");

                entity.HasIndex(e => e.Pictureid, "pictureid");

                entity.Property(e => e.Albumid).HasColumnName("albumid");

                entity.Property(e => e.Pictureid).HasColumnName("pictureid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");
            });

            modelBuilder.Entity<ForumsAlbumupdate>(entity =>
            {
                entity.HasKey(e => e.Albumid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_albumupdate");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Albumid)
                    .ValueGeneratedNever()
                    .HasColumnName("albumid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");
            });

            modelBuilder.Entity<ForumsAnnouncement>(entity =>
            {
                entity.HasKey(e => e.Announcementid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_announcement");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Forumid, "forumid");

                entity.HasIndex(e => new { e.Enddate, e.Forumid, e.Startdate }, "startdate");

                entity.Property(e => e.Announcementid).HasColumnName("announcementid");

                entity.Property(e => e.Announcementoptions).HasColumnName("announcementoptions");

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Pagetext)
                    .HasColumnType("mediumtext")
                    .HasColumnName("pagetext");

                entity.Property(e => e.Startdate).HasColumnName("startdate");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Views).HasColumnName("views");
            });

            modelBuilder.Entity<ForumsAnnouncementread>(entity =>
            {
                entity.HasKey(e => new { e.Announcementid, e.Userid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_announcementread");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Userid, "userid");

                entity.Property(e => e.Announcementid).HasColumnName("announcementid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsAttachment>(entity =>
            {
                entity.HasKey(e => e.Attachmentid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_attachment");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Filehash, "filehash");

                entity.HasIndex(e => e.Filesize, "filesize");

                entity.HasIndex(e => new { e.Posthash, e.Userid }, "posthash");

                entity.HasIndex(e => e.Postid, "postid");

                entity.HasIndex(e => e.Userid, "userid");

                entity.HasIndex(e => e.Visible, "visible");

                entity.Property(e => e.Attachmentid).HasColumnName("attachmentid");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Extension)
                    .HasMaxLength(20)
                    .HasColumnName("extension")
                    .HasDefaultValueSql("''")
                    .UseCollation("latin1_bin");

                entity.Property(e => e.Filedata)
                    .HasColumnType("mediumblob")
                    .HasColumnName("filedata");

                entity.Property(e => e.Filehash)
                    .HasMaxLength(32)
                    .HasColumnName("filehash")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Filename)
                    .HasMaxLength(100)
                    .HasColumnName("filename")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Filesize).HasColumnName("filesize");

                entity.Property(e => e.Importattachmentid).HasColumnName("importattachmentid");

                entity.Property(e => e.Posthash)
                    .HasMaxLength(32)
                    .HasColumnName("posthash")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Postid).HasColumnName("postid");

                entity.Property(e => e.Thumbnail)
                    .HasColumnType("mediumblob")
                    .HasColumnName("thumbnail");

                entity.Property(e => e.ThumbnailDateline).HasColumnName("thumbnail_dateline");

                entity.Property(e => e.ThumbnailFilesize).HasColumnName("thumbnail_filesize");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<ForumsAttachmentpermission>(entity =>
            {
                entity.HasKey(e => e.Attachmentpermissionid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_attachmentpermission");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Extension, e.Usergroupid }, "extension")
                    .IsUnique();

                entity.HasIndex(e => e.Usergroupid, "usergroupid");

                entity.Property(e => e.Attachmentpermissionid).HasColumnName("attachmentpermissionid");

                entity.Property(e => e.Attachmentpermissions).HasColumnName("attachmentpermissions");

                entity.Property(e => e.Extension)
                    .HasMaxLength(20)
                    .HasColumnName("extension")
                    .HasDefaultValueSql("''")
                    .UseCollation("latin1_bin");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<ForumsAttachmenttype>(entity =>
            {
                entity.HasKey(e => e.Extension)
                    .HasName("PRIMARY");

                entity.ToTable("forums_attachmenttype");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Enabled, "enabled");

                entity.Property(e => e.Extension)
                    .HasMaxLength(20)
                    .HasColumnName("extension")
                    .HasDefaultValueSql("''")
                    .IsFixedLength()
                    .UseCollation("latin1_bin");

                entity.Property(e => e.Display).HasColumnName("display");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Mimetype)
                    .HasMaxLength(255)
                    .HasColumnName("mimetype")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Newwindow).HasColumnName("newwindow");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Thumbnail).HasColumnName("thumbnail");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<ForumsAttachmentview>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_attachmentviews");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Attachmentid, "postid");

                entity.Property(e => e.Attachmentid).HasColumnName("attachmentid");
            });

            modelBuilder.Entity<ForumsAvatar>(entity =>
            {
                entity.HasKey(e => e.Avatarid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_avatar");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Avatarid).HasColumnName("avatarid");

                entity.Property(e => e.Avatarpath)
                    .HasMaxLength(100)
                    .HasColumnName("avatarpath")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Displayorder)
                    .HasColumnName("displayorder")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Imagecategoryid).HasColumnName("imagecategoryid");

                entity.Property(e => e.Importavatarid).HasColumnName("importavatarid");

                entity.Property(e => e.Minimumposts).HasColumnName("minimumposts");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsBbcode>(entity =>
            {
                entity.HasKey(e => e.Bbcodeid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_bbcode");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Bbcodetag, e.Twoparams }, "uniquetag")
                    .IsUnique();

                entity.Property(e => e.Bbcodeid).HasColumnName("bbcodeid");

                entity.Property(e => e.Bbcodeexample)
                    .HasMaxLength(200)
                    .HasColumnName("bbcodeexample")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Bbcodeexplanation)
                    .HasColumnType("mediumtext")
                    .HasColumnName("bbcodeexplanation");

                entity.Property(e => e.Bbcodereplacement)
                    .HasColumnType("mediumtext")
                    .HasColumnName("bbcodereplacement");

                entity.Property(e => e.Bbcodetag)
                    .HasMaxLength(200)
                    .HasColumnName("bbcodetag")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Buttonimage)
                    .HasMaxLength(250)
                    .HasColumnName("buttonimage")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Twoparams).HasColumnName("twoparams");
            });

            modelBuilder.Entity<ForumsBookmarksite>(entity =>
            {
                entity.HasKey(e => e.Bookmarksiteid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_bookmarksite");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Bookmarksiteid).HasColumnName("bookmarksiteid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Iconpath)
                    .HasMaxLength(250)
                    .HasColumnName("iconpath")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Utf8encode).HasColumnName("utf8encode");
            });

            modelBuilder.Entity<ForumsCalendar>(entity =>
            {
                entity.HasKey(e => e.Calendarid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_calendar");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Displayorder, "displayorder");

                entity.Property(e => e.Calendarid).HasColumnName("calendarid");

                entity.Property(e => e.Birthdaycount).HasColumnName("birthdaycount");

                entity.Property(e => e.Cutoff).HasColumnName("cutoff");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Endyear)
                    .HasColumnName("endyear")
                    .HasDefaultValueSql("'2006'");

                entity.Property(e => e.Eventcount).HasColumnName("eventcount");

                entity.Property(e => e.Holidays).HasColumnName("holidays");

                entity.Property(e => e.Moderatenew).HasColumnName("moderatenew");

                entity.Property(e => e.Neweventemail)
                    .HasColumnType("text")
                    .HasColumnName("neweventemail");

                entity.Property(e => e.Options).HasColumnName("options");

                entity.Property(e => e.Startofweek).HasColumnName("startofweek");

                entity.Property(e => e.Startyear)
                    .HasColumnName("startyear")
                    .HasDefaultValueSql("'2000'");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsCalendarcustomfield>(entity =>
            {
                entity.HasKey(e => e.Calendarcustomfieldid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_calendarcustomfield");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Calendarid, "calendarid");

                entity.Property(e => e.Calendarcustomfieldid).HasColumnName("calendarcustomfieldid");

                entity.Property(e => e.Allowentry)
                    .HasColumnName("allowentry")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Calendarid).HasColumnName("calendarid");

                entity.Property(e => e.Description)
                    .HasColumnType("mediumtext")
                    .HasColumnName("description");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Options)
                    .HasColumnType("mediumtext")
                    .HasColumnName("options");

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsCalendarmoderator>(entity =>
            {
                entity.HasKey(e => e.Calendarmoderatorid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_calendarmoderator");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Userid, e.Calendarid }, "userid");

                entity.Property(e => e.Calendarmoderatorid).HasColumnName("calendarmoderatorid");

                entity.Property(e => e.Calendarid).HasColumnName("calendarid");

                entity.Property(e => e.Neweventemail).HasColumnName("neweventemail");

                entity.Property(e => e.Permissions).HasColumnName("permissions");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsCalendarpermission>(entity =>
            {
                entity.HasKey(e => e.Calendarpermissionid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_calendarpermission");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Calendarid, "calendarid");

                entity.HasIndex(e => e.Usergroupid, "usergroupid");

                entity.Property(e => e.Calendarpermissionid).HasColumnName("calendarpermissionid");

                entity.Property(e => e.Calendarid).HasColumnName("calendarid");

                entity.Property(e => e.Calendarpermissions).HasColumnName("calendarpermissions");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");
            });

            modelBuilder.Entity<ForumsCannedreply>(entity =>
            {
                entity.ToTable("forums_cannedreplies");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Reply)
                    .HasColumnType("text")
                    .HasColumnName("reply");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsCookieTracker>(entity =>
            {
                entity.ToTable("forums_cookie_tracker");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Browser)
                    .HasColumnType("text")
                    .HasColumnName("browser");

                entity.Property(e => e.BrowserVersion)
                    .HasColumnType("text")
                    .HasColumnName("browser_version");

                entity.Property(e => e.CookieHash)
                    .HasColumnType("text")
                    .HasColumnName("cookie_hash");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Ipaddress)
                    .HasColumnType("text")
                    .HasColumnName("ipaddress");

                entity.Property(e => e.Language)
                    .HasColumnType("text")
                    .HasColumnName("language");

                entity.Property(e => e.Os)
                    .HasColumnType("text")
                    .HasColumnName("os");

                entity.Property(e => e.Platform)
                    .HasColumnType("text")
                    .HasColumnName("platform");

                entity.Property(e => e.UserAgent)
                    .HasColumnType("text")
                    .HasColumnName("user_agent");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasColumnType("text")
                    .HasColumnName("username");
            });

            modelBuilder.Entity<ForumsCpsession>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Hash })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_cpsession");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Hash)
                    .HasMaxLength(32)
                    .HasColumnName("hash")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dateline).HasColumnName("dateline");
            });

            modelBuilder.Entity<ForumsCron>(entity =>
            {
                entity.HasKey(e => e.Cronid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_cron");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Nextrun, "nextrun");

                entity.HasIndex(e => e.Varname, "varname")
                    .IsUnique();

                entity.Property(e => e.Cronid).HasColumnName("cronid");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Day).HasColumnName("day");

                entity.Property(e => e.Filename)
                    .HasMaxLength(50)
                    .HasColumnName("filename")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Hour).HasColumnName("hour");

                entity.Property(e => e.Loglevel).HasColumnName("loglevel");

                entity.Property(e => e.Minute)
                    .HasMaxLength(100)
                    .HasColumnName("minute")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Nextrun).HasColumnName("nextrun");

                entity.Property(e => e.Product)
                    .HasMaxLength(25)
                    .HasColumnName("product")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Varname)
                    .HasMaxLength(100)
                    .HasColumnName("varname")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Volatile).HasColumnName("volatile");

                entity.Property(e => e.Weekday).HasColumnName("weekday");
            });

            modelBuilder.Entity<ForumsCronlog>(entity =>
            {
                entity.HasKey(e => e.Cronlogid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_cronlog");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Varname, "varname");

                entity.Property(e => e.Cronlogid).HasColumnName("cronlogid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Description)
                    .HasColumnType("mediumtext")
                    .HasColumnName("description");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Varname)
                    .HasMaxLength(100)
                    .HasColumnName("varname")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsCustomavatar>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_customavatar");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Filedata)
                    .HasColumnType("mediumblob")
                    .HasColumnName("filedata");

                entity.Property(e => e.FiledataThumb)
                    .HasColumnType("mediumblob")
                    .HasColumnName("filedata_thumb");

                entity.Property(e => e.Filename)
                    .HasMaxLength(100)
                    .HasColumnName("filename")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Filesize).HasColumnName("filesize");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.HeightThumb).HasColumnName("height_thumb");

                entity.Property(e => e.Importcustomavatarid).HasColumnName("importcustomavatarid");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.Property(e => e.WidthThumb).HasColumnName("width_thumb");
            });

            modelBuilder.Entity<ForumsCustomprofilepic>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_customprofilepic");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Filedata)
                    .HasColumnType("mediumblob")
                    .HasColumnName("filedata");

                entity.Property(e => e.Filename)
                    .HasMaxLength(100)
                    .HasColumnName("filename")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Filesize).HasColumnName("filesize");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Importcustomprofilepicid).HasColumnName("importcustomprofilepicid");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<ForumsDatastore>(entity =>
            {
                entity.HasKey(e => e.Title)
                    .HasName("PRIMARY");

                entity.ToTable("forums_datastore");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Data)
                    .HasColumnType("mediumtext")
                    .HasColumnName("data");

                entity.Property(e => e.Unserialize).HasColumnName("unserialize");
            });

            modelBuilder.Entity<ForumsDeletionlog>(entity =>
            {
                entity.HasKey(e => new { e.Primaryid, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_deletionlog");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Type, e.Dateline }, "type");

                entity.Property(e => e.Primaryid).HasColumnName("primaryid");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('post','thread','visitormessage','groupmessage','picturecomment')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'post'");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Reason)
                    .HasMaxLength(125)
                    .HasColumnName("reason")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsDiscussion>(entity =>
            {
                entity.HasKey(e => e.Discussionid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_discussion");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Groupid, e.Lastpost }, "groupid");

                entity.Property(e => e.Discussionid).HasColumnName("discussionid");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Firstpostid).HasColumnName("firstpostid");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Lastpost).HasColumnName("lastpost");

                entity.Property(e => e.Lastposter)
                    .HasMaxLength(255)
                    .HasColumnName("lastposter");

                entity.Property(e => e.Lastposterid).HasColumnName("lastposterid");

                entity.Property(e => e.Lastpostid).HasColumnName("lastpostid");

                entity.Property(e => e.Moderation).HasColumnName("moderation");

                entity.Property(e => e.Subscribers)
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("subscribers")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<ForumsDiscussionread>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Discussionid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_discussionread");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Readtime, "readtime");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Discussionid).HasColumnName("discussionid");

                entity.Property(e => e.Readtime).HasColumnName("readtime");
            });

            modelBuilder.Entity<ForumsDtoGarageComment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PRIMARY");

                entity.ToTable("forums_DTO_garage_comment");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.Display)
                    .IsRequired()
                    .HasColumnName("display")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TimeAdded)
                    .HasColumnType("timestamp")
                    .HasColumnName("time_added")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.TimeModified)
                    .HasColumnType("timestamp")
                    .HasColumnName("time_modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Useripaddress)
                    .HasMaxLength(15)
                    .HasColumnName("useripaddress")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VehicleId).HasColumnName("vehicle_id");
            });

            modelBuilder.Entity<ForumsDtoGarageImage>(entity =>
            {
                entity.HasKey(e => e.ImageId)
                    .HasName("PRIMARY");

                entity.ToTable("forums_DTO_garage_image");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.Caption)
                    .HasMaxLength(100)
                    .HasColumnName("caption")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DisplayOrder).HasColumnName("display_order");

                entity.Property(e => e.ThumbVersion)
                    .HasColumnName("thumbVersion")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TimeAdded)
                    .HasColumnType("timestamp")
                    .HasColumnName("time_added")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.TimeModified)
                    .HasColumnType("timestamp")
                    .HasColumnName("time_modified")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.VbaThumbVersion)
                    .HasColumnName("vbaThumbVersion")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VehicleId).HasColumnName("vehicle_id");
            });

            modelBuilder.Entity<ForumsDtoGarageSearch>(entity =>
            {
                entity.HasKey(e => e.Searchid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_DTO_garage_search");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Searchid).HasColumnName("searchid");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Displayterms)
                    .HasColumnType("mediumtext")
                    .HasColumnName("displayterms");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .HasColumnName("ipaddress")
                    .IsFixedLength();

                entity.Property(e => e.Searchterms)
                    .HasColumnType("mediumtext")
                    .HasColumnName("searchterms");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ForumsDtoGarageVehicle>(entity =>
            {
                entity.HasKey(e => e.VehicleId)
                    .HasName("PRIMARY");

                entity.ToTable("forums_DTO_garage_vehicle");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.VehicleId).HasColumnName("vehicle_id");

                entity.Property(e => e.Allowcomments)
                    .IsRequired()
                    .HasColumnName("allowcomments")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("color")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CommentThreadId)
                    .HasColumnName("commentThreadID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Display).HasColumnName("display");

                entity.Property(e => e.Drivetrainmods)
                    .HasColumnType("text")
                    .HasColumnName("drivetrainmods");

                entity.Property(e => e.Exteriormods)
                    .HasColumnType("text")
                    .HasColumnName("exteriormods");

                entity.Property(e => e.History)
                    .HasColumnType("text")
                    .HasColumnName("history");

                entity.Property(e => e.Icemods)
                    .HasColumnType("text")
                    .HasColumnName("icemods");

                entity.Property(e => e.Interiormods)
                    .HasColumnType("text")
                    .HasColumnName("interiormods");

                entity.Property(e => e.Make)
                    .HasMaxLength(50)
                    .HasColumnName("make")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .HasColumnName("model")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Packages)
                    .HasColumnType("text")
                    .HasColumnName("packages");

                entity.Property(e => e.Suspensionmods)
                    .HasColumnType("text")
                    .HasColumnName("suspensionmods");

                entity.Property(e => e.TimeAdded)
                    .HasColumnType("timestamp")
                    .HasColumnName("time_added")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.TimeModified)
                    .HasColumnType("timestamp")
                    .HasColumnName("time_modified")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Views)
                    .HasColumnName("views")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Wheelsandtires)
                    .HasColumnType("text")
                    .HasColumnName("wheelsandtires");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<ForumsEditlog>(entity =>
            {
                entity.HasKey(e => e.Postid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_editlog");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Postid)
                    .ValueGeneratedNever()
                    .HasColumnName("postid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Hashistory).HasColumnName("hashistory");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .HasColumnName("reason")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsEvent>(entity =>
            {
                entity.HasKey(e => e.Eventid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_event");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Calendarid, "calendarid");

                entity.HasIndex(e => new { e.DatelineTo, e.DatelineFrom, e.Visible, e.Calendarid }, "daterange");

                entity.HasIndex(e => e.Userid, "userid");

                entity.HasIndex(e => e.Visible, "visible");

                entity.Property(e => e.Eventid).HasColumnName("eventid");

                entity.Property(e => e.Allowsmilies)
                    .HasColumnName("allowsmilies")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Calendarid).HasColumnName("calendarid");

                entity.Property(e => e.Customfields)
                    .HasColumnType("mediumtext")
                    .HasColumnName("customfields");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.DatelineFrom).HasColumnName("dateline_from");

                entity.Property(e => e.DatelineTo).HasColumnName("dateline_to");

                entity.Property(e => e.Dst)
                    .HasColumnName("dst")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Event)
                    .HasColumnType("mediumtext")
                    .HasColumnName("event");

                entity.Property(e => e.Recuroption)
                    .HasMaxLength(6)
                    .HasColumnName("recuroption")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Recurring).HasColumnName("recurring");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Utc)
                    .HasPrecision(4, 2)
                    .HasColumnName("utc");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<ForumsExternalcache>(entity =>
            {
                entity.HasKey(e => e.Cachehash)
                    .HasName("PRIMARY");

                entity.ToTable("forums_externalcache");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Dateline, e.Cachehash }, "dateline");

                entity.HasIndex(e => e.Forumid, "forumid");

                entity.Property(e => e.Cachehash)
                    .HasMaxLength(32)
                    .HasColumnName("cachehash")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Headers)
                    .HasColumnType("mediumtext")
                    .HasColumnName("headers");

                entity.Property(e => e.Text)
                    .HasColumnType("mediumtext")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<ForumsFaq>(entity =>
            {
                entity.HasKey(e => e.Faqname)
                    .HasName("PRIMARY");

                entity.ToTable("forums_faq");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Faqparent, "faqparent");

                entity.Property(e => e.Faqname)
                    .HasMaxLength(250)
                    .HasColumnName("faqname")
                    .HasDefaultValueSql("''")
                    .UseCollation("latin1_bin");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Faqparent)
                    .HasMaxLength(50)
                    .HasColumnName("faqparent")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Product)
                    .HasMaxLength(25)
                    .HasColumnName("product")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Volatile).HasColumnName("volatile");
            });

            modelBuilder.Entity<ForumsForum>(entity =>
            {
                entity.HasKey(e => e.Forumid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_forum");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Childlist)
                    .HasColumnType("text")
                    .HasColumnName("childlist");

                entity.Property(e => e.Daysprune).HasColumnName("daysprune");

                entity.Property(e => e.Defaultsortfield)
                    .HasMaxLength(50)
                    .HasColumnName("defaultsortfield")
                    .HasDefaultValueSql("'lastpost'");

                entity.Property(e => e.Defaultsortorder)
                    .HasColumnType("enum('asc','desc')")
                    .HasColumnName("defaultsortorder")
                    .HasDefaultValueSql("'desc'");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionClean)
                    .HasColumnType("text")
                    .HasColumnName("description_clean");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Imageprefix)
                    .HasMaxLength(100)
                    .HasColumnName("imageprefix")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Importcategoryid).HasColumnName("importcategoryid");

                entity.Property(e => e.Importforumid).HasColumnName("importforumid");

                entity.Property(e => e.Lasticonid).HasColumnName("lasticonid");

                entity.Property(e => e.Lastpost).HasColumnName("lastpost");

                entity.Property(e => e.Lastposter)
                    .HasMaxLength(100)
                    .HasColumnName("lastposter")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lastpostid).HasColumnName("lastpostid");

                entity.Property(e => e.Lastprefixid)
                    .HasMaxLength(25)
                    .HasColumnName("lastprefixid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lastthread)
                    .HasMaxLength(250)
                    .HasColumnName("lastthread")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lastthreadid).HasColumnName("lastthreadid");

                entity.Property(e => e.Link)
                    .HasMaxLength(200)
                    .HasColumnName("link")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Newpostemail)
                    .HasColumnType("text")
                    .HasColumnName("newpostemail");

                entity.Property(e => e.Newthreademail)
                    .HasColumnType("text")
                    .HasColumnName("newthreademail");

                entity.Property(e => e.Options).HasColumnName("options");

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Parentlist)
                    .HasMaxLength(250)
                    .HasColumnName("parentlist")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Replycount).HasColumnName("replycount");

                entity.Property(e => e.Showprivate).HasColumnName("showprivate");

                entity.Property(e => e.Styleid).HasColumnName("styleid");

                entity.Property(e => e.Threadcount)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("threadcount")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TitleClean)
                    .HasMaxLength(100)
                    .HasColumnName("title_clean")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsForumpermission>(entity =>
            {
                entity.HasKey(e => e.Forumpermissionid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_forumpermission");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Usergroupid, e.Forumid }, "ugid_fid")
                    .IsUnique();

                entity.Property(e => e.Forumpermissionid).HasColumnName("forumpermissionid");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Forumpermissions).HasColumnName("forumpermissions");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");
            });

            modelBuilder.Entity<ForumsForumprefixset>(entity =>
            {
                entity.HasKey(e => new { e.Forumid, e.Prefixsetid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_forumprefixset");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Prefixsetid)
                    .HasMaxLength(25)
                    .HasColumnName("prefixsetid")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsForumread>(entity =>
            {
                entity.HasKey(e => new { e.Forumid, e.Userid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_forumread");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Readtime, "readtime");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Readtime).HasColumnName("readtime");
            });

            modelBuilder.Entity<ForumsGroupmessage>(entity =>
            {
                entity.HasKey(e => e.Gmid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_groupmessage");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Discussionid, e.Dateline, e.State }, "discussionid");

                entity.HasIndex(e => new { e.Title, e.Pagetext }, "gm_ft")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => new { e.Postuserid, e.Discussionid, e.State }, "postuserid");

                entity.Property(e => e.Gmid).HasColumnName("gmid");

                entity.Property(e => e.Allowsmilie).HasColumnName("allowsmilie");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Discussionid).HasColumnName("discussionid");

                entity.Property(e => e.Ipaddress).HasColumnName("ipaddress");

                entity.Property(e => e.Pagetext)
                    .HasColumnType("mediumtext")
                    .HasColumnName("pagetext");

                entity.Property(e => e.Postuserid).HasColumnName("postuserid");

                entity.Property(e => e.Postusername)
                    .HasMaxLength(100)
                    .HasColumnName("postusername")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Reportthreadid).HasColumnName("reportthreadid");

                entity.Property(e => e.State)
                    .HasColumnType("enum('visible','moderation','deleted')")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'visible'");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsGroupmessageHash>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_groupmessage_hash");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.HasIndex(e => new { e.Postuserid, e.Dupehash }, "postuserid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Dupehash)
                    .HasMaxLength(32)
                    .HasColumnName("dupehash")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Postuserid).HasColumnName("postuserid");
            });

            modelBuilder.Entity<ForumsGroupread>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Groupid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_groupread");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Readtime, "readtime");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Readtime).HasColumnName("readtime");
            });

            modelBuilder.Entity<ForumsHoliday>(entity =>
            {
                entity.HasKey(e => e.Holidayid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_holiday");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Varname, "varname");

                entity.Property(e => e.Holidayid).HasColumnName("holidayid");

                entity.Property(e => e.Allowsmilies)
                    .HasColumnName("allowsmilies")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Recuroption)
                    .HasMaxLength(6)
                    .HasColumnName("recuroption")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Recurring).HasColumnName("recurring");

                entity.Property(e => e.Varname)
                    .HasMaxLength(100)
                    .HasColumnName("varname")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsHumanverify>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_humanverify");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.HasIndex(e => e.Hash, "hash");

                entity.Property(e => e.Answer)
                    .HasColumnType("mediumtext")
                    .HasColumnName("answer");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Hash)
                    .HasMaxLength(32)
                    .HasColumnName("hash")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Viewed).HasColumnName("viewed");
            });

            modelBuilder.Entity<ForumsHvanswer>(entity =>
            {
                entity.HasKey(e => e.Answerid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_hvanswer");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Questionid, "questionid");

                entity.Property(e => e.Answerid).HasColumnName("answerid");

                entity.Property(e => e.Answer)
                    .HasMaxLength(255)
                    .HasColumnName("answer")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Questionid).HasColumnName("questionid");
            });

            modelBuilder.Entity<ForumsHvquestion>(entity =>
            {
                entity.HasKey(e => e.Questionid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_hvquestion");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Questionid).HasColumnName("questionid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Regex)
                    .HasMaxLength(255)
                    .HasColumnName("regex")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsIcon>(entity =>
            {
                entity.HasKey(e => e.Iconid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_icon");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Iconid).HasColumnName("iconid");

                entity.Property(e => e.Displayorder)
                    .HasColumnName("displayorder")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Iconpath)
                    .HasMaxLength(100)
                    .HasColumnName("iconpath")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Imagecategoryid).HasColumnName("imagecategoryid");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsImagecategory>(entity =>
            {
                entity.HasKey(e => e.Imagecategoryid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_imagecategory");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Imagecategoryid).HasColumnName("imagecategoryid");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Imagetype).HasColumnName("imagetype");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsImagecategorypermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_imagecategorypermission");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Imagecategoryid, e.Usergroupid }, "imagecategoryid");

                entity.Property(e => e.Imagecategoryid).HasColumnName("imagecategoryid");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");
            });

            modelBuilder.Entity<ForumsImpexerror>(entity =>
            {
                entity.HasKey(e => e.Errorid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_impexerror");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Errorid).HasColumnName("errorid");

                entity.Property(e => e.Classnumber)
                    .HasMaxLength(3)
                    .HasColumnName("classnumber")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Error)
                    .HasMaxLength(250)
                    .HasColumnName("error")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Errortype)
                    .HasMaxLength(10)
                    .HasColumnName("errortype")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Importid).HasColumnName("importid");

                entity.Property(e => e.Remedy)
                    .HasMaxLength(250)
                    .HasColumnName("remedy")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ForumsInfraction>(entity =>
            {
                entity.HasKey(e => e.Infractionid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_infraction");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Expires, e.Action }, "expires");

                entity.HasIndex(e => e.Infractionlevelid, "infractonlevelid");

                entity.HasIndex(e => e.Postid, "postid");

                entity.HasIndex(e => e.Threadid, "threadid");

                entity.HasIndex(e => new { e.Userid, e.Action }, "userid");

                entity.Property(e => e.Infractionid).HasColumnName("infractionid");

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.Actiondateline).HasColumnName("actiondateline");

                entity.Property(e => e.Actionreason)
                    .HasMaxLength(255)
                    .HasColumnName("actionreason")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Actionuserid).HasColumnName("actionuserid");

                entity.Property(e => e.Customreason)
                    .HasMaxLength(255)
                    .HasColumnName("customreason")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Expires).HasColumnName("expires");

                entity.Property(e => e.Infractionlevelid).HasColumnName("infractionlevelid");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasColumnName("note")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.Postid).HasColumnName("postid");

                entity.Property(e => e.Threadid).HasColumnName("threadid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Whoadded).HasColumnName("whoadded");
            });

            modelBuilder.Entity<ForumsInfractionban>(entity =>
            {
                entity.HasKey(e => e.Infractionbanid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_infractionban");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Usergroupid, "usergroupid");

                entity.Property(e => e.Infractionbanid).HasColumnName("infractionbanid");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Banusergroupid).HasColumnName("banusergroupid");

                entity.Property(e => e.Method)
                    .HasColumnType("enum('points','infractions')")
                    .HasColumnName("method")
                    .HasDefaultValueSql("'infractions'");

                entity.Property(e => e.Period)
                    .HasMaxLength(5)
                    .HasColumnName("period")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");
            });

            modelBuilder.Entity<ForumsInfractiongroup>(entity =>
            {
                entity.HasKey(e => e.Infractiongroupid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_infractiongroup");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Usergroupid, e.Pointlevel }, "usergroupid");

                entity.Property(e => e.Infractiongroupid).HasColumnName("infractiongroupid");

                entity.Property(e => e.Orusergroupid).HasColumnName("orusergroupid");

                entity.Property(e => e.Override).HasColumnName("override");

                entity.Property(e => e.Pointlevel).HasColumnName("pointlevel");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");
            });

            modelBuilder.Entity<ForumsInfractionlevel>(entity =>
            {
                entity.HasKey(e => e.Infractionlevelid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_infractionlevel");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Infractionlevelid).HasColumnName("infractionlevelid");

                entity.Property(e => e.Expires).HasColumnName("expires");

                entity.Property(e => e.Extend).HasColumnName("extend");

                entity.Property(e => e.Period)
                    .HasColumnType("enum('H','D','M','N')")
                    .HasColumnName("period")
                    .HasDefaultValueSql("'H'");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.Warning).HasColumnName("warning");
            });

            modelBuilder.Entity<ForumsLanguage>(entity =>
            {
                entity.HasKey(e => e.Languageid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_language");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Languageid).HasColumnName("languageid");

                entity.Property(e => e.Calformat1override)
                    .HasMaxLength(50)
                    .HasColumnName("calformat1override")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Calformat2override)
                    .HasMaxLength(50)
                    .HasColumnName("calformat2override")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Charset)
                    .HasMaxLength(15)
                    .HasColumnName("charset")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dateoverride)
                    .HasMaxLength(50)
                    .HasColumnName("dateoverride")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Decimalsep)
                    .HasMaxLength(1)
                    .HasColumnName("decimalsep")
                    .HasDefaultValueSql("'.'")
                    .IsFixedLength();

                entity.Property(e => e.Imagesoverride)
                    .HasMaxLength(150)
                    .HasColumnName("imagesoverride")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Languagecode)
                    .HasMaxLength(12)
                    .HasColumnName("languagecode")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Locale)
                    .HasMaxLength(20)
                    .HasColumnName("locale")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Logdateoverride)
                    .HasMaxLength(50)
                    .HasColumnName("logdateoverride")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PhrasegroupAccessmask)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_accessmask");

                entity.Property(e => e.PhrasegroupAdvPortal)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_adv_portal");

                entity.Property(e => e.PhrasegroupAdvPortalCp)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_adv_portal_cp");

                entity.Property(e => e.PhrasegroupAlbum)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_album");

                entity.Property(e => e.PhrasegroupAttachmentImage)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_attachment_image");

                entity.Property(e => e.PhrasegroupBanning)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_banning");

                entity.Property(e => e.PhrasegroupBbcode)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_bbcode");

                entity.Property(e => e.PhrasegroupCalendar)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_calendar");

                entity.Property(e => e.PhrasegroupCpglobal)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_cpglobal");

                entity.Property(e => e.PhrasegroupCphome)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_cphome");

                entity.Property(e => e.PhrasegroupCpoption)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_cpoption");

                entity.Property(e => e.PhrasegroupCppermission)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_cppermission");

                entity.Property(e => e.PhrasegroupCprank)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_cprank");

                entity.Property(e => e.PhrasegroupCprofilefield)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_cprofilefield");

                entity.Property(e => e.PhrasegroupCpuser)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_cpuser");

                entity.Property(e => e.PhrasegroupCpusergroup)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_cpusergroup");

                entity.Property(e => e.PhrasegroupCron)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_cron");

                entity.Property(e => e.PhrasegroupDiagnostic)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_diagnostic");

                entity.Property(e => e.PhrasegroupDtoGarage)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_dto_garage");

                entity.Property(e => e.PhrasegroupForum)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_forum");

                entity.Property(e => e.PhrasegroupForumdisplay)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_forumdisplay");

                entity.Property(e => e.PhrasegroupFronthelp)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_fronthelp");

                entity.Property(e => e.PhrasegroupGlobal)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_global");

                entity.Property(e => e.PhrasegroupHelpFaq)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_help_faq");

                entity.Property(e => e.PhrasegroupHoliday)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_holiday");

                entity.Property(e => e.PhrasegroupInfraction)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_infraction");

                entity.Property(e => e.PhrasegroupInfractionlevel)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_infractionlevel");

                entity.Property(e => e.PhrasegroupInlinemod)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_inlinemod");

                entity.Property(e => e.PhrasegroupLanguage)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_language");

                entity.Property(e => e.PhrasegroupLogging)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_logging");

                entity.Property(e => e.PhrasegroupMaintenance)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_maintenance");

                entity.Property(e => e.PhrasegroupMessaging)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_messaging");

                entity.Property(e => e.PhrasegroupModerator)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_moderator");

                entity.Property(e => e.PhrasegroupNotice)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_notice");

                entity.Property(e => e.PhrasegroupPlugins)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_plugins");

                entity.Property(e => e.PhrasegroupPm)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_pm");

                entity.Property(e => e.PhrasegroupPoll)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_poll");

                entity.Property(e => e.PhrasegroupPostbit)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_postbit");

                entity.Property(e => e.PhrasegroupPosting)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_posting");

                entity.Property(e => e.PhrasegroupPrefix)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_prefix");

                entity.Property(e => e.PhrasegroupPrefixadmin)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_prefixadmin");

                entity.Property(e => e.PhrasegroupProfilefield)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_profilefield");

                entity.Property(e => e.PhrasegroupPromotion)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_promotion");

                entity.Property(e => e.PhrasegroupRegister)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_register");

                entity.Property(e => e.PhrasegroupReputation)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_reputation");

                entity.Property(e => e.PhrasegroupReputationlevel)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_reputationlevel");

                entity.Property(e => e.PhrasegroupSearch)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_search");

                entity.Property(e => e.PhrasegroupShowthread)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_showthread");

                entity.Property(e => e.PhrasegroupSocialgroups)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_socialgroups");

                entity.Property(e => e.PhrasegroupSql)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_sql");

                entity.Property(e => e.PhrasegroupStats)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_stats");

                entity.Property(e => e.PhrasegroupStyle)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_style");

                entity.Property(e => e.PhrasegroupSubscription)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_subscription");

                entity.Property(e => e.PhrasegroupThread)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_thread");

                entity.Property(e => e.PhrasegroupThreadmanage)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_threadmanage");

                entity.Property(e => e.PhrasegroupTimezone)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_timezone");

                entity.Property(e => e.PhrasegroupUser)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_user");

                entity.Property(e => e.PhrasegroupWol)
                    .HasColumnType("mediumtext")
                    .HasColumnName("phrasegroup_wol");

                entity.Property(e => e.Registereddateoverride)
                    .HasMaxLength(50)
                    .HasColumnName("registereddateoverride")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Thousandsep)
                    .HasMaxLength(1)
                    .HasColumnName("thousandsep")
                    .HasDefaultValueSql("','")
                    .IsFixedLength();

                entity.Property(e => e.Timeoverride)
                    .HasMaxLength(50)
                    .HasColumnName("timeoverride")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userselect)
                    .HasColumnName("userselect")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ForumsMailqueue>(entity =>
            {
                entity.HasKey(e => e.Mailqueueid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_mailqueue");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Mailqueueid).HasColumnName("mailqueueid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Fromemail)
                    .HasColumnType("mediumtext")
                    .HasColumnName("fromemail");

                entity.Property(e => e.Header)
                    .HasColumnType("mediumtext")
                    .HasColumnName("header");

                entity.Property(e => e.Message)
                    .HasColumnType("mediumtext")
                    .HasColumnName("message");

                entity.Property(e => e.Subject)
                    .HasColumnType("mediumtext")
                    .HasColumnName("subject");

                entity.Property(e => e.Toemail)
                    .HasColumnType("mediumtext")
                    .HasColumnName("toemail");
            });

            modelBuilder.Entity<ForumsMatchReport>(entity =>
            {
                entity.HasKey(e => e.Matchid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_match_reports");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Matchid).HasColumnName("matchid");

                entity.Property(e => e.CookieHash)
                    .HasColumnType("text")
                    .HasColumnName("cookie_hash");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Ipaddress)
                    .HasColumnType("text")
                    .HasColumnName("ipaddress");

                entity.Property(e => e.MatchUserid).HasColumnName("match_userid");

                entity.Property(e => e.MatchUsername)
                    .HasColumnType("text")
                    .HasColumnName("match_username");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasColumnType("text")
                    .HasColumnName("username");
            });

            modelBuilder.Entity<ForumsModeration>(entity =>
            {
                entity.HasKey(e => new { e.Primaryid, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_moderation");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Type, e.Dateline }, "type");

                entity.Property(e => e.Primaryid).HasColumnName("primaryid");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('thread','reply','visitormessage','groupmessage','picturecomment')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'thread'");

                entity.Property(e => e.Dateline).HasColumnName("dateline");
            });

            modelBuilder.Entity<ForumsModerator>(entity =>
            {
                entity.HasKey(e => e.Moderatorid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_moderator");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Userid, e.Forumid }, "userid_forumid")
                    .IsUnique();

                entity.Property(e => e.Moderatorid).HasColumnName("moderatorid");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Importmoderatorid)
                    .HasMaxLength(255)
                    .HasColumnName("importmoderatorid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Permissions).HasColumnName("permissions");

                entity.Property(e => e.Permissions2).HasColumnName("permissions2");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsModeratorlog>(entity =>
            {
                entity.HasKey(e => e.Moderatorlogid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_moderatorlog");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Id1, "id1");

                entity.HasIndex(e => e.Id2, "id2");

                entity.HasIndex(e => e.Product, "product");

                entity.HasIndex(e => e.Threadid, "threadid");

                entity.Property(e => e.Moderatorlogid).HasColumnName("moderatorlogid");

                entity.Property(e => e.Action)
                    .HasMaxLength(250)
                    .HasColumnName("action")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Attachmentid).HasColumnName("attachmentid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Id1).HasColumnName("id1");

                entity.Property(e => e.Id2).HasColumnName("id2");

                entity.Property(e => e.Id3).HasColumnName("id3");

                entity.Property(e => e.Id4).HasColumnName("id4");

                entity.Property(e => e.Id5).HasColumnName("id5");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(45)
                    .HasColumnName("ipaddress")
                    .IsFixedLength();

                entity.Property(e => e.Pollid).HasColumnName("pollid");

                entity.Property(e => e.Postid).HasColumnName("postid");

                entity.Property(e => e.Product)
                    .HasMaxLength(25)
                    .HasColumnName("product")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Threadid).HasColumnName("threadid");

                entity.Property(e => e.Threadtitle)
                    .HasMaxLength(250)
                    .HasColumnName("threadtitle")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsNotice>(entity =>
            {
                entity.HasKey(e => e.Noticeid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_notice");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Active, "active");

                entity.Property(e => e.Noticeid).HasColumnName("noticeid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Dismissible).HasColumnName("dismissible");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Persistent).HasColumnName("persistent");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsNoticecriterion>(entity =>
            {
                entity.HasKey(e => new { e.Noticeid, e.Criteriaid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_noticecriteria");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Noticeid).HasColumnName("noticeid");

                entity.Property(e => e.Criteriaid)
                    .HasMaxLength(250)
                    .HasColumnName("criteriaid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Condition1)
                    .HasMaxLength(250)
                    .HasColumnName("condition1")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Condition2)
                    .HasMaxLength(250)
                    .HasColumnName("condition2")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Condition3)
                    .HasMaxLength(250)
                    .HasColumnName("condition3")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsNoticedismissed>(entity =>
            {
                entity.HasKey(e => new { e.Noticeid, e.Userid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_noticedismissed");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Userid, "userid");

                entity.Property(e => e.Noticeid).HasColumnName("noticeid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsPasswordhistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_passwordhistory");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Userid, "userid");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Passworddate)
                    .HasColumnName("passworddate")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsPaymentapi>(entity =>
            {
                entity.HasKey(e => e.Paymentapiid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_paymentapi");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Paymentapiid).HasColumnName("paymentapiid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Classname)
                    .HasMaxLength(250)
                    .HasColumnName("classname")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Currency)
                    .HasMaxLength(250)
                    .HasColumnName("currency")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Recurring).HasColumnName("recurring");

                entity.Property(e => e.Settings)
                    .HasColumnType("mediumtext")
                    .HasColumnName("settings");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsPaymentinfo>(entity =>
            {
                entity.HasKey(e => e.Paymentinfoid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_paymentinfo");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Hash, "hash");

                entity.Property(e => e.Paymentinfoid).HasColumnName("paymentinfoid");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Hash)
                    .HasMaxLength(32)
                    .HasColumnName("hash")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Subscriptionid).HasColumnName("subscriptionid");

                entity.Property(e => e.Subscriptionsubid).HasColumnName("subscriptionsubid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsPaymenttransaction>(entity =>
            {
                entity.HasKey(e => e.Paymenttransactionid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_paymenttransaction");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.HasIndex(e => e.Paymentapiid, "paymentapiid");

                entity.HasIndex(e => e.Transactionid, "transactionid");

                entity.Property(e => e.Paymenttransactionid).HasColumnName("paymenttransactionid");

                entity.Property(e => e.Amount)
                    .HasColumnType("double unsigned")
                    .HasColumnName("amount");

                entity.Property(e => e.Currency)
                    .HasMaxLength(5)
                    .HasColumnName("currency")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Paymentapiid).HasColumnName("paymentapiid");

                entity.Property(e => e.Paymentinfoid).HasColumnName("paymentinfoid");

                entity.Property(e => e.Request)
                    .HasColumnType("mediumtext")
                    .HasColumnName("request");

                entity.Property(e => e.Reversed).HasColumnName("reversed");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(250)
                    .HasColumnName("transactionid")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsPhrase>(entity =>
            {
                entity.HasKey(e => e.Phraseid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_phrase");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Languageid, e.Fieldname }, "languageid");

                entity.HasIndex(e => new { e.Varname, e.Languageid, e.Fieldname }, "name_lang_type")
                    .IsUnique();

                entity.Property(e => e.Phraseid).HasColumnName("phraseid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Fieldname)
                    .HasMaxLength(20)
                    .HasColumnName("fieldname")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Importphraseid).HasColumnName("importphraseid");

                entity.Property(e => e.Languageid).HasColumnName("languageid");

                entity.Property(e => e.Product)
                    .HasMaxLength(25)
                    .HasColumnName("product")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Text)
                    .HasColumnType("mediumtext")
                    .HasColumnName("text");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Varname)
                    .HasMaxLength(250)
                    .HasColumnName("varname")
                    .HasDefaultValueSql("''")
                    .UseCollation("latin1_bin");

                entity.Property(e => e.Version)
                    .HasMaxLength(30)
                    .HasColumnName("version")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsPhrasetype>(entity =>
            {
                entity.HasKey(e => e.Fieldname)
                    .HasName("PRIMARY");

                entity.ToTable("forums_phrasetype");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Fieldname)
                    .HasMaxLength(20)
                    .HasColumnName("fieldname")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Editrows).HasColumnName("editrows");

                entity.Property(e => e.Product)
                    .HasMaxLength(25)
                    .HasColumnName("product")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Special).HasColumnName("special");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ForumsPicture>(entity =>
            {
                entity.HasKey(e => e.Pictureid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_picture");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Userid, "userid");

                entity.Property(e => e.Pictureid).HasColumnName("pictureid");

                entity.Property(e => e.Caption)
                    .HasColumnType("text")
                    .HasColumnName("caption");

                entity.Property(e => e.Extension)
                    .HasMaxLength(20)
                    .HasColumnName("extension")
                    .HasDefaultValueSql("''")
                    .UseCollation("latin1_bin");

                entity.Property(e => e.Filedata)
                    .HasColumnType("mediumblob")
                    .HasColumnName("filedata");

                entity.Property(e => e.Filesize).HasColumnName("filesize");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Idhash)
                    .HasMaxLength(32)
                    .HasColumnName("idhash")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Reportthreadid).HasColumnName("reportthreadid");

                entity.Property(e => e.State)
                    .HasColumnType("enum('visible','moderation')")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'visible'");

                entity.Property(e => e.Thumbnail)
                    .HasColumnType("mediumblob")
                    .HasColumnName("thumbnail");

                entity.Property(e => e.ThumbnailDateline).HasColumnName("thumbnail_dateline");

                entity.Property(e => e.ThumbnailFilesize).HasColumnName("thumbnail_filesize");

                entity.Property(e => e.ThumbnailHeight).HasColumnName("thumbnail_height");

                entity.Property(e => e.ThumbnailWidth).HasColumnName("thumbnail_width");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<ForumsPicturecomment>(entity =>
            {
                entity.HasKey(e => e.Commentid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_picturecomment");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Pictureid, e.Dateline, e.State }, "pictureid");

                entity.HasIndex(e => new { e.Postuserid, e.Pictureid, e.State }, "postuserid");

                entity.Property(e => e.Commentid).HasColumnName("commentid");

                entity.Property(e => e.Allowsmilie)
                    .HasColumnName("allowsmilie")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Ipaddress).HasColumnName("ipaddress");

                entity.Property(e => e.Messageread).HasColumnName("messageread");

                entity.Property(e => e.Pagetext)
                    .HasColumnType("mediumtext")
                    .HasColumnName("pagetext");

                entity.Property(e => e.Pictureid).HasColumnName("pictureid");

                entity.Property(e => e.Postuserid).HasColumnName("postuserid");

                entity.Property(e => e.Postusername)
                    .HasMaxLength(100)
                    .HasColumnName("postusername")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Reportthreadid).HasColumnName("reportthreadid");

                entity.Property(e => e.State)
                    .HasColumnType("enum('visible','moderation','deleted')")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'visible'");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsPicturecommentHash>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_picturecomment_hash");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.HasIndex(e => new { e.Postuserid, e.Dupehash }, "postuserid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Dupehash)
                    .HasMaxLength(32)
                    .HasColumnName("dupehash")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pictureid).HasColumnName("pictureid");

                entity.Property(e => e.Postuserid).HasColumnName("postuserid");
            });

            modelBuilder.Entity<ForumsPlugin>(entity =>
            {
                entity.HasKey(e => e.Pluginid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_plugin");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Active, "active");

                entity.Property(e => e.Pluginid).HasColumnName("pluginid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Devkey)
                    .HasMaxLength(25)
                    .HasColumnName("devkey")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Executionorder)
                    .HasColumnName("executionorder")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.Hookname)
                    .HasMaxLength(250)
                    .HasColumnName("hookname")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Phpcode)
                    .HasColumnType("text")
                    .HasColumnName("phpcode");

                entity.Property(e => e.Product)
                    .HasMaxLength(25)
                    .HasColumnName("product")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsPm>(entity =>
            {
                entity.HasKey(e => e.Pmid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_pm");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Pmtextid, "pmtextid");

                entity.HasIndex(e => new { e.Userid, e.Folderid }, "userid");

                entity.Property(e => e.Pmid).HasColumnName("pmid");

                entity.Property(e => e.Folderid).HasColumnName("folderid");

                entity.Property(e => e.Importpmid)
                    .HasMaxLength(255)
                    .HasColumnName("importpmid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Messageread).HasColumnName("messageread");

                entity.Property(e => e.Parentpmid).HasColumnName("parentpmid");

                entity.Property(e => e.Pmtextid).HasColumnName("pmtextid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsPmreceipt>(entity =>
            {
                entity.HasKey(e => e.Pmid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_pmreceipt");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Touserid, "touserid");

                entity.HasIndex(e => new { e.Userid, e.Readtime }, "userid");

                entity.Property(e => e.Pmid)
                    .ValueGeneratedNever()
                    .HasColumnName("pmid");

                entity.Property(e => e.Denied).HasColumnName("denied");

                entity.Property(e => e.Readtime).HasColumnName("readtime");

                entity.Property(e => e.Sendtime).HasColumnName("sendtime");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Touserid).HasColumnName("touserid");

                entity.Property(e => e.Tousername)
                    .HasMaxLength(100)
                    .HasColumnName("tousername")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsPmtext>(entity =>
            {
                entity.HasKey(e => e.Pmtextid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_pmtext");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Fromuserid, e.Dateline }, "fromuserid");

                entity.Property(e => e.Pmtextid).HasColumnName("pmtextid");

                entity.Property(e => e.Allowsmilie)
                    .HasColumnName("allowsmilie")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Fromuserid).HasColumnName("fromuserid");

                entity.Property(e => e.Fromusername)
                    .HasMaxLength(100)
                    .HasColumnName("fromusername")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Iconid).HasColumnName("iconid");

                entity.Property(e => e.Importpmid)
                    .HasMaxLength(255)
                    .HasColumnName("importpmid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Message)
                    .HasColumnType("mediumtext")
                    .HasColumnName("message");

                entity.Property(e => e.Reportthreadid).HasColumnName("reportthreadid");

                entity.Property(e => e.Showsignature).HasColumnName("showsignature");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Touserarray)
                    .HasColumnType("mediumtext")
                    .HasColumnName("touserarray");
            });

            modelBuilder.Entity<ForumsPmthrottle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_pmthrottle");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Userid, "userid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsPodcast>(entity =>
            {
                entity.HasKey(e => e.Forumid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_podcast");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Forumid)
                    .ValueGeneratedNever()
                    .HasColumnName("forumid");

                entity.Property(e => e.Author)
                    .HasMaxLength(255)
                    .HasColumnName("author")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Category)
                    .HasMaxLength(255)
                    .HasColumnName("category")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Explicit).HasColumnName("explicit");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Keywords)
                    .HasMaxLength(255)
                    .HasColumnName("keywords")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Owneremail)
                    .HasMaxLength(255)
                    .HasColumnName("owneremail")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ownername)
                    .HasMaxLength(255)
                    .HasColumnName("ownername")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Subtitle)
                    .HasMaxLength(255)
                    .HasColumnName("subtitle")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Summary)
                    .HasColumnType("mediumtext")
                    .HasColumnName("summary");
            });

            modelBuilder.Entity<ForumsPodcastitem>(entity =>
            {
                entity.HasKey(e => e.Postid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_podcastitem");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Postid)
                    .ValueGeneratedNever()
                    .HasColumnName("postid");

                entity.Property(e => e.Author)
                    .HasMaxLength(255)
                    .HasColumnName("author")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Explicit).HasColumnName("explicit");

                entity.Property(e => e.Keywords)
                    .HasMaxLength(255)
                    .HasColumnName("keywords")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Subtitle)
                    .HasMaxLength(255)
                    .HasColumnName("subtitle")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsPoll>(entity =>
            {
                entity.HasKey(e => e.Pollid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_poll");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.Property(e => e.Pollid).HasColumnName("pollid");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Importpollid).HasColumnName("importpollid");

                entity.Property(e => e.Lastvote).HasColumnName("lastvote");

                entity.Property(e => e.Multiple).HasColumnName("multiple");

                entity.Property(e => e.Numberoptions).HasColumnName("numberoptions");

                entity.Property(e => e.Options)
                    .HasColumnType("text")
                    .HasColumnName("options");

                entity.Property(e => e.Public).HasColumnName("public");

                entity.Property(e => e.Question)
                    .HasMaxLength(100)
                    .HasColumnName("question")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Timeout).HasColumnName("timeout");

                entity.Property(e => e.Voters).HasColumnName("voters");

                entity.Property(e => e.Votes)
                    .HasColumnType("text")
                    .HasColumnName("votes");
            });

            modelBuilder.Entity<ForumsPollvote>(entity =>
            {
                entity.HasKey(e => e.Pollvoteid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_pollvote");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Pollid, e.Userid, e.Votetype }, "pollid")
                    .IsUnique();

                entity.HasIndex(e => e.Userid, "userid");

                entity.Property(e => e.Pollvoteid).HasColumnName("pollvoteid");

                entity.Property(e => e.Pollid).HasColumnName("pollid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Votedate).HasColumnName("votedate");

                entity.Property(e => e.Voteoption).HasColumnName("voteoption");

                entity.Property(e => e.Votetype).HasColumnName("votetype");
            });

            modelBuilder.Entity<ForumsPost>(entity =>
            {
                entity.HasKey(e => e.Postid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_post");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.HasIndex(e => e.Importpostid, "importpost_index");

                entity.HasIndex(e => new { e.Threadid, e.Userid }, "threadid");

                entity.HasIndex(e => new { e.Title, e.Pagetext }, "title")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => e.Userid, "userid");

                entity.Property(e => e.Postid).HasColumnName("postid");

                entity.Property(e => e.Allowsmilie).HasColumnName("allowsmilie");

                entity.Property(e => e.Attach).HasColumnName("attach");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Iconid).HasColumnName("iconid");

                entity.Property(e => e.Importpostid).HasColumnName("importpostid");

                entity.Property(e => e.Importthreadid).HasColumnName("importthreadid");

                entity.Property(e => e.Infraction).HasColumnName("infraction");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(45)
                    .HasColumnName("ipaddress")
                    .IsFixedLength();

                entity.Property(e => e.Pagetext)
                    .HasColumnType("mediumtext")
                    .HasColumnName("pagetext");

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Reportthreadid).HasColumnName("reportthreadid");

                entity.Property(e => e.Showsignature).HasColumnName("showsignature");

                entity.Property(e => e.Threadid).HasColumnName("threadid");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<ForumsPostedithistory>(entity =>
            {
                entity.HasKey(e => e.Postedithistoryid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_postedithistory");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Postid, e.Userid }, "postid");

                entity.Property(e => e.Postedithistoryid).HasColumnName("postedithistoryid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Iconid).HasColumnName("iconid");

                entity.Property(e => e.Original).HasColumnName("original");

                entity.Property(e => e.Pagetext)
                    .HasColumnType("mediumtext")
                    .HasColumnName("pagetext");

                entity.Property(e => e.Postid).HasColumnName("postid");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .HasColumnName("reason")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsPosthash>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_posthash");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.HasIndex(e => new { e.Userid, e.Dupehash }, "userid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Dupehash)
                    .HasMaxLength(32)
                    .HasColumnName("dupehash")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Postid).HasColumnName("postid");

                entity.Property(e => e.Threadid).HasColumnName("threadid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsPostindex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_postindex");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Wordid, e.Postid }, "wordid")
                    .IsUnique();

                entity.Property(e => e.Intitle).HasColumnName("intitle");

                entity.Property(e => e.Postid).HasColumnName("postid");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Wordid).HasColumnName("wordid");
            });

            modelBuilder.Entity<ForumsPostlog>(entity =>
            {
                entity.HasKey(e => e.Postid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_postlog");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.HasIndex(e => e.Ip, "ip");

                entity.Property(e => e.Postid)
                    .ValueGeneratedNever()
                    .HasColumnName("postid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Ip).HasColumnName("ip");

                entity.Property(e => e.Useragent)
                    .HasMaxLength(100)
                    .HasColumnName("useragent")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ForumsPostparsed>(entity =>
            {
                entity.HasKey(e => new { e.Postid, e.Styleid, e.Languageid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("forums_postparsed");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.Property(e => e.Postid).HasColumnName("postid");

                entity.Property(e => e.Styleid).HasColumnName("styleid");

                entity.Property(e => e.Languageid).HasColumnName("languageid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Hasimages).HasColumnName("hasimages");

                entity.Property(e => e.PagetextHtml)
                    .HasColumnType("mediumtext")
                    .HasColumnName("pagetext_html");
            });

            modelBuilder.Entity<ForumsPrefix>(entity =>
            {
                entity.HasKey(e => e.Prefixid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_prefix");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Prefixsetid, e.Displayorder }, "prefixsetid");

                entity.Property(e => e.Prefixid)
                    .HasMaxLength(25)
                    .HasColumnName("prefixid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Options).HasColumnName("options");

                entity.Property(e => e.Prefixsetid)
                    .HasMaxLength(25)
                    .HasColumnName("prefixsetid")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsPrefixpermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_prefixpermission");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Prefixid, e.Usergroupid }, "prefixsetid");

                entity.Property(e => e.Prefixid)
                    .HasMaxLength(25)
                    .HasColumnName("prefixid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");
            });

            modelBuilder.Entity<ForumsPrefixset>(entity =>
            {
                entity.HasKey(e => e.Prefixsetid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_prefixset");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Prefixsetid)
                    .HasMaxLength(25)
                    .HasColumnName("prefixsetid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            });

            modelBuilder.Entity<ForumsProduct>(entity =>
            {
                entity.HasKey(e => e.Productid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_product");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Productid)
                    .HasMaxLength(25)
                    .HasColumnName("productid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Version)
                    .HasMaxLength(25)
                    .HasColumnName("version")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Versioncheckurl)
                    .HasMaxLength(250)
                    .HasColumnName("versioncheckurl")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsProductcode>(entity =>
            {
                entity.HasKey(e => e.Productcodeid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_productcode");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Productid, "productid");

                entity.Property(e => e.Productcodeid).HasColumnName("productcodeid");

                entity.Property(e => e.Installcode)
                    .HasColumnType("mediumtext")
                    .HasColumnName("installcode");

                entity.Property(e => e.Productid)
                    .HasMaxLength(25)
                    .HasColumnName("productid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Uninstallcode)
                    .HasColumnType("mediumtext")
                    .HasColumnName("uninstallcode");

                entity.Property(e => e.Version)
                    .HasMaxLength(25)
                    .HasColumnName("version")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsProductdependency>(entity =>
            {
                entity.HasKey(e => e.Productdependencyid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_productdependency");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Productdependencyid).HasColumnName("productdependencyid");

                entity.Property(e => e.Dependencytype)
                    .HasMaxLength(25)
                    .HasColumnName("dependencytype")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Maxversion)
                    .HasMaxLength(50)
                    .HasColumnName("maxversion")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Minversion)
                    .HasMaxLength(50)
                    .HasColumnName("minversion")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Parentproductid)
                    .HasMaxLength(25)
                    .HasColumnName("parentproductid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Productid)
                    .HasMaxLength(25)
                    .HasColumnName("productid")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsProfileblockprivacy>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Blockid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_profileblockprivacy");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Blockid).HasColumnName("blockid");

                entity.Property(e => e.Requirement).HasColumnName("requirement");
            });

            modelBuilder.Entity<ForumsProfilefield>(entity =>
            {
                entity.HasKey(e => e.Profilefieldid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_profilefield");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Editable, "editable");

                entity.HasIndex(e => e.Profilefieldcategoryid, "profilefieldcategoryid");

                entity.Property(e => e.Profilefieldid).HasColumnName("profilefieldid");

                entity.Property(e => e.Data)
                    .HasColumnType("mediumtext")
                    .HasColumnName("data");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Editable)
                    .HasColumnName("editable")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Form).HasColumnName("form");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Hidden).HasColumnName("hidden");

                entity.Property(e => e.Html).HasColumnName("html");

                entity.Property(e => e.Maxlength)
                    .HasColumnName("maxlength")
                    .HasDefaultValueSql("'250'");

                entity.Property(e => e.Memberlist).HasColumnName("memberlist");

                entity.Property(e => e.Optional).HasColumnName("optional");

                entity.Property(e => e.Perline).HasColumnName("perline");

                entity.Property(e => e.Profilefieldcategoryid).HasColumnName("profilefieldcategoryid");

                entity.Property(e => e.Regex)
                    .HasMaxLength(255)
                    .HasColumnName("regex")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.Searchable).HasColumnName("searchable");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('input','select','radio','textarea','checkbox','select_multiple')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'input'");
            });

            modelBuilder.Entity<ForumsProfilefieldcategory>(entity =>
            {
                entity.HasKey(e => e.Profilefieldcategoryid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_profilefieldcategory");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Profilefieldcategoryid).HasColumnName("profilefieldcategoryid");

                entity.Property(e => e.Allowprivacy).HasColumnName("allowprivacy");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Location)
                    .HasMaxLength(25)
                    .HasColumnName("location")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsProfilevisitor>(entity =>
            {
                entity.HasKey(e => new { e.Visitorid, e.Userid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_profilevisitor");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Userid, e.Visible, e.Dateline }, "userid");

                entity.Property(e => e.Visitorid).HasColumnName("visitorid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ForumsRank>(entity =>
            {
                entity.HasKey(e => e.Rankid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_ranks");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Usergroupid, e.Minposts }, "grouprank");

                entity.Property(e => e.Rankid).HasColumnName("rankid");

                entity.Property(e => e.Display).HasColumnName("display");

                entity.Property(e => e.Importrankid).HasColumnName("importrankid");

                entity.Property(e => e.Minposts).HasColumnName("minposts");

                entity.Property(e => e.Rankimg)
                    .HasColumnType("mediumtext")
                    .HasColumnName("rankimg");

                entity.Property(e => e.Ranklevel).HasColumnName("ranklevel");

                entity.Property(e => e.Stack).HasColumnName("stack");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");
            });

            modelBuilder.Entity<ForumsReminder>(entity =>
            {
                entity.HasKey(e => e.Reminderid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_reminder");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Reminderid).HasColumnName("reminderid");

                entity.Property(e => e.Adminonly)
                    .HasColumnName("adminonly")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Completedby).HasColumnName("completedby");

                entity.Property(e => e.Completedtime).HasColumnName("completedtime");

                entity.Property(e => e.Duedate).HasColumnName("duedate");

                entity.Property(e => e.Text)
                    .HasColumnType("mediumtext")
                    .HasColumnName("text");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsReputation>(entity =>
            {
                entity.HasKey(e => e.Reputationid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_reputation");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.HasIndex(e => new { e.Postid, e.Userid }, "multi");

                entity.HasIndex(e => e.Userid, "userid");

                entity.HasIndex(e => new { e.Whoadded, e.Postid }, "whoadded_postid");

                entity.Property(e => e.Reputationid).HasColumnName("reputationid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Postid)
                    .HasColumnName("postid")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reason)
                    .HasMaxLength(250)
                    .HasColumnName("reason")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Reputation).HasColumnName("reputation");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Whoadded).HasColumnName("whoadded");
            });

            modelBuilder.Entity<ForumsReputationlevel>(entity =>
            {
                entity.HasKey(e => e.Reputationlevelid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_reputationlevel");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Minimumreputation, "reputationlevel");

                entity.Property(e => e.Reputationlevelid).HasColumnName("reputationlevelid");

                entity.Property(e => e.Minimumreputation).HasColumnName("minimumreputation");
            });

            modelBuilder.Entity<ForumsRssfeed>(entity =>
            {
                entity.HasKey(e => e.Rssfeedid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_rssfeed");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Lastrun, "lastrun");

                entity.Property(e => e.Rssfeedid).HasColumnName("rssfeedid");

                entity.Property(e => e.Bodytemplate)
                    .HasColumnType("mediumtext")
                    .HasColumnName("bodytemplate");

                entity.Property(e => e.Endannouncement).HasColumnName("endannouncement");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Iconid).HasColumnName("iconid");

                entity.Property(e => e.Itemtype)
                    .HasColumnType("enum('thread','announcement')")
                    .HasColumnName("itemtype")
                    .HasDefaultValueSql("'thread'");

                entity.Property(e => e.Lastrun).HasColumnName("lastrun");

                entity.Property(e => e.Maxresults).HasColumnName("maxresults");

                entity.Property(e => e.Options).HasColumnName("options");

                entity.Property(e => e.Port)
                    .HasColumnName("port")
                    .HasDefaultValueSql("'80'");

                entity.Property(e => e.Prefixid)
                    .HasMaxLength(25)
                    .HasColumnName("prefixid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Searchwords)
                    .HasColumnType("mediumtext")
                    .HasColumnName("searchwords");

                entity.Property(e => e.Threadactiondelay).HasColumnName("threadactiondelay");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Titletemplate)
                    .HasColumnType("mediumtext")
                    .HasColumnName("titletemplate");

                entity.Property(e => e.Ttl)
                    .HasColumnName("ttl")
                    .HasDefaultValueSql("'1500'");

                entity.Property(e => e.Url)
                    .HasColumnType("text")
                    .HasColumnName("url");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsRsslog>(entity =>
            {
                entity.HasKey(e => new { e.Rssfeedid, e.Itemid, e.Itemtype })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("forums_rsslog");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Uniquehash, "uniquehash")
                    .IsUnique();

                entity.Property(e => e.Rssfeedid).HasColumnName("rssfeedid");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemtype)
                    .HasColumnType("enum('thread','announcement')")
                    .HasColumnName("itemtype")
                    .HasDefaultValueSql("'thread'");

                entity.Property(e => e.Contenthash)
                    .HasMaxLength(32)
                    .HasColumnName("contenthash")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Threadactioncomplete).HasColumnName("threadactioncomplete");

                entity.Property(e => e.Threadactiontime).HasColumnName("threadactiontime");

                entity.Property(e => e.Uniquehash)
                    .HasMaxLength(32)
                    .HasColumnName("uniquehash")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ForumsSearch>(entity =>
            {
                entity.HasKey(e => e.Searchid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_search");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Searchhash, e.Sortby, e.Sortorder }, "searchunique")
                    .IsUnique();

                entity.Property(e => e.Searchid).HasColumnName("searchid");

                entity.Property(e => e.Announceids)
                    .HasColumnType("mediumtext")
                    .HasColumnName("announceids");

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Displayterms)
                    .HasColumnType("mediumtext")
                    .HasColumnName("displayterms");

                entity.Property(e => e.Forumchoice)
                    .HasColumnType("mediumtext")
                    .HasColumnName("forumchoice");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(45)
                    .HasColumnName("ipaddress")
                    .IsFixedLength();

                entity.Property(e => e.Orderedids)
                    .HasColumnType("mediumtext")
                    .HasColumnName("orderedids");

                entity.Property(e => e.Personal).HasColumnName("personal");

                entity.Property(e => e.Prefixchoice)
                    .HasColumnType("mediumtext")
                    .HasColumnName("prefixchoice");

                entity.Property(e => e.Query)
                    .HasMaxLength(200)
                    .HasColumnName("query")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Searchhash)
                    .HasMaxLength(32)
                    .HasColumnName("searchhash")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Searchterms)
                    .HasColumnType("mediumtext")
                    .HasColumnName("searchterms");

                entity.Property(e => e.Searchtime).HasColumnName("searchtime");

                entity.Property(e => e.Searchuser)
                    .HasMaxLength(200)
                    .HasColumnName("searchuser")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Showposts).HasColumnName("showposts");

                entity.Property(e => e.Sortby)
                    .HasMaxLength(200)
                    .HasColumnName("sortby")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Sortorder)
                    .HasMaxLength(4)
                    .HasColumnName("sortorder")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Titleonly).HasColumnName("titleonly");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsSession>(entity =>
            {
                entity.HasKey(e => e.Sessionhash)
                    .HasName("PRIMARY");

                entity.ToTable("forums_session");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Sessionhash)
                    .HasMaxLength(32)
                    .HasColumnName("sessionhash")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Badlocation).HasColumnName("badlocation");

                entity.Property(e => e.Bypass).HasColumnName("bypass");

                entity.Property(e => e.Host)
                    .HasMaxLength(45)
                    .HasColumnName("host")
                    .IsFixedLength();

                entity.Property(e => e.Idhash)
                    .HasMaxLength(32)
                    .HasColumnName("idhash")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Incalendar).HasColumnName("incalendar");

                entity.Property(e => e.Inforum).HasColumnName("inforum");

                entity.Property(e => e.Inthread).HasColumnName("inthread");

                entity.Property(e => e.Languageid).HasColumnName("languageid");

                entity.Property(e => e.Lastactivity).HasColumnName("lastactivity");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("location")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Loggedin).HasColumnName("loggedin");

                entity.Property(e => e.Newposts).HasColumnName("newposts");

                entity.Property(e => e.Profileupdate).HasColumnName("profileupdate");

                entity.Property(e => e.Styleid).HasColumnName("styleid");

                entity.Property(e => e.Useragent)
                    .HasMaxLength(100)
                    .HasColumnName("useragent")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsSetting>(entity =>
            {
                entity.HasKey(e => e.Varname)
                    .HasName("PRIMARY");

                entity.ToTable("forums_setting");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Varname)
                    .HasMaxLength(100)
                    .HasColumnName("varname")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Advanced).HasColumnName("advanced");

                entity.Property(e => e.Blacklist).HasColumnName("blacklist");

                entity.Property(e => e.Datatype)
                    .HasColumnType("enum('free','number','boolean','bitfield','username','integer','posint')")
                    .HasColumnName("datatype")
                    .HasDefaultValueSql("'free'");

                entity.Property(e => e.Defaultvalue)
                    .HasColumnType("mediumtext")
                    .HasColumnName("defaultvalue");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Grouptitle)
                    .HasMaxLength(50)
                    .HasColumnName("grouptitle")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Optioncode)
                    .HasColumnType("mediumtext")
                    .HasColumnName("optioncode");

                entity.Property(e => e.Product)
                    .HasMaxLength(25)
                    .HasColumnName("product")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Validationcode)
                    .HasColumnType("text")
                    .HasColumnName("validationcode");

                entity.Property(e => e.Value)
                    .HasColumnType("mediumtext")
                    .HasColumnName("value");

                entity.Property(e => e.Volatile).HasColumnName("volatile");
            });

            modelBuilder.Entity<ForumsSettinggroup>(entity =>
            {
                entity.HasKey(e => e.Grouptitle)
                    .HasName("PRIMARY");

                entity.ToTable("forums_settinggroup");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Grouptitle)
                    .HasMaxLength(50)
                    .HasColumnName("grouptitle")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Product)
                    .HasMaxLength(25)
                    .HasColumnName("product")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Volatile).HasColumnName("volatile");
            });

            modelBuilder.Entity<ForumsSigparsed>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Styleid, e.Languageid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("forums_sigparsed");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Styleid).HasColumnName("styleid");

                entity.Property(e => e.Languageid).HasColumnName("languageid");

                entity.Property(e => e.Hasimages).HasColumnName("hasimages");

                entity.Property(e => e.Signatureparsed)
                    .HasColumnType("mediumtext")
                    .HasColumnName("signatureparsed");
            });

            modelBuilder.Entity<ForumsSigpic>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_sigpic");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Filedata)
                    .HasColumnType("mediumblob")
                    .HasColumnName("filedata");

                entity.Property(e => e.Filename)
                    .HasMaxLength(100)
                    .HasColumnName("filename")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Filesize).HasColumnName("filesize");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<ForumsSkSpamlog>(entity =>
            {
                entity.ToTable("forums_sk_spamlog");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Evidence)
                    .HasColumnType("text")
                    .HasColumnName("evidence");

                entity.Property(e => e.Ip)
                    .HasColumnType("text")
                    .HasColumnName("ip");

                entity.Property(e => e.Type)
                    .HasColumnType("text")
                    .HasColumnName("type");

                entity.Property(e => e.Useragent)
                    .HasColumnType("text")
                    .HasColumnName("useragent");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsSmilie>(entity =>
            {
                entity.HasKey(e => e.Smilieid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_smilie");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Smilieid).HasColumnName("smilieid");

                entity.Property(e => e.Displayorder)
                    .HasColumnName("displayorder")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Imagecategoryid).HasColumnName("imagecategoryid");

                entity.Property(e => e.Importsmilieid).HasColumnName("importsmilieid");

                entity.Property(e => e.Smiliepath)
                    .HasMaxLength(100)
                    .HasColumnName("smiliepath")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Smilietext)
                    .HasMaxLength(20)
                    .HasColumnName("smilietext")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ForumsSocialgroup>(entity =>
            {
                entity.HasKey(e => e.Groupid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_socialgroup");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Creatoruserid, "creatoruserid");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.HasIndex(e => e.Lastpost, "lastpost");

                entity.HasIndex(e => e.Members, "members");

                entity.HasIndex(e => new { e.Name, e.Description }, "name")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => e.Picturecount, "picturecount");

                entity.HasIndex(e => e.Socialgroupcategoryid, "socialgroupcategoryid");

                entity.HasIndex(e => e.Visible, "visible");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Creatoruserid).HasColumnName("creatoruserid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Discussions)
                    .HasColumnName("discussions")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Lastdiscussion)
                    .HasMaxLength(255)
                    .HasColumnName("lastdiscussion")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lastdiscussionid).HasColumnName("lastdiscussionid");

                entity.Property(e => e.Lastgmid).HasColumnName("lastgmid");

                entity.Property(e => e.Lastpost).HasColumnName("lastpost");

                entity.Property(e => e.Lastposter)
                    .HasMaxLength(255)
                    .HasColumnName("lastposter")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lastposterid).HasColumnName("lastposterid");

                entity.Property(e => e.Lastupdate).HasColumnName("lastupdate");

                entity.Property(e => e.Members).HasColumnName("members");

                entity.Property(e => e.Moderatedmembers).HasColumnName("moderatedmembers");

                entity.Property(e => e.Moderation).HasColumnName("moderation");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Options).HasColumnName("options");

                entity.Property(e => e.Picturecount).HasColumnName("picturecount");

                entity.Property(e => e.Socialgroupcategoryid).HasColumnName("socialgroupcategoryid");

                entity.Property(e => e.Transferowner).HasColumnName("transferowner");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('public','moderated','inviteonly')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<ForumsSocialgroupcategory>(entity =>
            {
                entity.HasKey(e => e.Socialgroupcategoryid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_socialgroupcategory");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Displayorder, "displayorder");

                entity.Property(e => e.Socialgroupcategoryid).HasColumnName("socialgroupcategoryid");

                entity.Property(e => e.Creatoruserid).HasColumnName("creatoruserid");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Groups)
                    .HasColumnName("groups")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Lastupdate).HasColumnName("lastupdate");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<ForumsSocialgroupicon>(entity =>
            {
                entity.HasKey(e => e.Groupid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_socialgroupicon");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Groupid)
                    .ValueGeneratedNever()
                    .HasColumnName("groupid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Extension)
                    .HasMaxLength(20)
                    .HasColumnName("extension")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Filedata)
                    .HasColumnType("mediumblob")
                    .HasColumnName("filedata");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.ThumbnailFiledata)
                    .HasColumnType("mediumblob")
                    .HasColumnName("thumbnail_filedata");

                entity.Property(e => e.ThumbnailHeight).HasColumnName("thumbnail_height");

                entity.Property(e => e.ThumbnailWidth).HasColumnName("thumbnail_width");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<ForumsSocialgroupmember>(entity =>
            {
                entity.HasKey(e => new { e.Groupid, e.Userid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_socialgroupmember");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Groupid, e.Type }, "groupid");

                entity.HasIndex(e => new { e.Userid, e.Type }, "userid");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('member','moderated','invited')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'member'");
            });

            modelBuilder.Entity<ForumsSocialgrouppicture>(entity =>
            {
                entity.HasKey(e => new { e.Groupid, e.Pictureid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_socialgrouppicture");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Groupid, e.Dateline }, "groupid");

                entity.HasIndex(e => e.Pictureid, "pictureid");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Pictureid).HasColumnName("pictureid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");
            });

            modelBuilder.Entity<ForumsSpamlog>(entity =>
            {
                entity.HasKey(e => e.Postid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_spamlog");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Postid)
                    .ValueGeneratedNever()
                    .HasColumnName("postid");
            });

            modelBuilder.Entity<ForumsStat>(entity =>
            {
                entity.HasKey(e => e.Dateline)
                    .HasName("PRIMARY");

                entity.ToTable("forums_stats");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Dateline)
                    .ValueGeneratedNever()
                    .HasColumnName("dateline");

                entity.Property(e => e.Ausers)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("ausers")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Npost)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("npost")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Nthread)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("nthread")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Nuser)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("nuser")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ForumsStrike>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_strikes");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Strikeip, "strikeip");

                entity.HasIndex(e => e.Striketime, "striketime");

                entity.Property(e => e.Strikeip)
                    .HasMaxLength(15)
                    .HasColumnName("strikeip")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Striketime).HasColumnName("striketime");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsStyle>(entity =>
            {
                entity.HasKey(e => e.Styleid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_style");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Styleid).HasColumnName("styleid");

                entity.Property(e => e.Css)
                    .HasColumnType("mediumtext")
                    .HasColumnName("css");

                entity.Property(e => e.Csscolors)
                    .HasColumnType("mediumtext")
                    .HasColumnName("csscolors");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.Editorstyles)
                    .HasColumnType("mediumtext")
                    .HasColumnName("editorstyles");

                entity.Property(e => e.Importstyleid).HasColumnName("importstyleid");

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Parentlist)
                    .HasMaxLength(250)
                    .HasColumnName("parentlist")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Replacements)
                    .HasColumnType("mediumtext")
                    .HasColumnName("replacements");

                entity.Property(e => e.Stylevars)
                    .HasColumnType("mediumtext")
                    .HasColumnName("stylevars");

                entity.Property(e => e.Templatelist)
                    .HasColumnType("mediumtext")
                    .HasColumnName("templatelist");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userselect)
                    .HasColumnName("userselect")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ForumsSubscribediscussion>(entity =>
            {
                entity.HasKey(e => e.Subscribediscussionid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_subscribediscussion");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Discussionid, "discussionid");

                entity.HasIndex(e => new { e.Userid, e.Discussionid }, "userdiscussion")
                    .IsUnique();

                entity.Property(e => e.Subscribediscussionid).HasColumnName("subscribediscussionid");

                entity.Property(e => e.Discussionid).HasColumnName("discussionid");

                entity.Property(e => e.Emailupdate).HasColumnName("emailupdate");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsSubscribeevent>(entity =>
            {
                entity.HasKey(e => e.Subscribeeventid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_subscribeevent");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Eventid, "eventid");

                entity.HasIndex(e => new { e.Userid, e.Eventid }, "subindex")
                    .IsUnique();

                entity.Property(e => e.Subscribeeventid).HasColumnName("subscribeeventid");

                entity.Property(e => e.Eventid).HasColumnName("eventid");

                entity.Property(e => e.Lastreminder).HasColumnName("lastreminder");

                entity.Property(e => e.Reminder)
                    .HasColumnName("reminder")
                    .HasDefaultValueSql("'3600'");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsSubscribeforum>(entity =>
            {
                entity.HasKey(e => e.Subscribeforumid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_subscribeforum");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Forumid, "forumid");

                entity.HasIndex(e => new { e.Userid, e.Forumid }, "subindex")
                    .IsUnique();

                entity.Property(e => e.Subscribeforumid).HasColumnName("subscribeforumid");

                entity.Property(e => e.Emailupdate).HasColumnName("emailupdate");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsSubscribegroup>(entity =>
            {
                entity.HasKey(e => e.Subscribegroupid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_subscribegroup");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Groupid, "groupid");

                entity.HasIndex(e => new { e.Userid, e.Groupid }, "usergroup")
                    .IsUnique();

                entity.Property(e => e.Subscribegroupid).HasColumnName("subscribegroupid");

                entity.Property(e => e.Emailupdate)
                    .HasColumnType("enum('daily','weekly','none')")
                    .HasColumnName("emailupdate")
                    .HasDefaultValueSql("'none'");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsSubscribethread>(entity =>
            {
                entity.HasKey(e => e.Subscribethreadid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_subscribethread");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Threadid, e.Userid }, "threadid")
                    .IsUnique();

                entity.HasIndex(e => new { e.Userid, e.Folderid }, "userid");

                entity.Property(e => e.Subscribethreadid).HasColumnName("subscribethreadid");

                entity.Property(e => e.Canview)
                    .HasColumnName("canview")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Emailupdate).HasColumnName("emailupdate");

                entity.Property(e => e.Folderid).HasColumnName("folderid");

                entity.Property(e => e.Threadid).HasColumnName("threadid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsSubscription>(entity =>
            {
                entity.HasKey(e => e.Subscriptionid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_subscription");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Subscriptionid).HasColumnName("subscriptionid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Adminoptions).HasColumnName("adminoptions");

                entity.Property(e => e.Cost)
                    .HasColumnType("mediumtext")
                    .HasColumnName("cost");

                entity.Property(e => e.Displayorder)
                    .HasColumnName("displayorder")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Forums)
                    .HasColumnType("mediumtext")
                    .HasColumnName("forums");

                entity.Property(e => e.Importsubscriptionid).HasColumnName("importsubscriptionid");

                entity.Property(e => e.Membergroupids)
                    .HasMaxLength(255)
                    .HasColumnName("membergroupids")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Nusergroupid).HasColumnName("nusergroupid");

                entity.Property(e => e.Options).HasColumnName("options");

                entity.Property(e => e.Varname)
                    .HasMaxLength(100)
                    .HasColumnName("varname")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsSubscriptionlog>(entity =>
            {
                entity.HasKey(e => e.Subscriptionlogid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_subscriptionlog");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Subscriptionid, "subscriptionid");

                entity.HasIndex(e => new { e.Userid, e.Subscriptionid }, "userid");

                entity.Property(e => e.Subscriptionlogid)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("subscriptionlogid");

                entity.Property(e => e.Expirydate).HasColumnName("expirydate");

                entity.Property(e => e.Importsubscriptionlogid).HasColumnName("importsubscriptionlogid");

                entity.Property(e => e.Pusergroupid).HasColumnName("pusergroupid");

                entity.Property(e => e.Regdate).HasColumnName("regdate");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Subscriptionid).HasColumnName("subscriptionid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsSubscriptionpermission>(entity =>
            {
                entity.HasKey(e => e.Subscriptionpermissionid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_subscriptionpermission");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Subscriptionid, e.Usergroupid }, "subscriptionid")
                    .IsUnique();

                entity.HasIndex(e => e.Usergroupid, "usergroupid");

                entity.Property(e => e.Subscriptionpermissionid).HasColumnName("subscriptionpermissionid");

                entity.Property(e => e.Subscriptionid).HasColumnName("subscriptionid");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");
            });

            modelBuilder.Entity<ForumsTachyforumcounter>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Forumid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_tachyforumcounter");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Replycount).HasColumnName("replycount");

                entity.Property(e => e.Threadcount)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("threadcount")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ForumsTachyforumpost>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Forumid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_tachyforumpost");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Forumid, "forumid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Lasticonid).HasColumnName("lasticonid");

                entity.Property(e => e.Lastpost).HasColumnName("lastpost");

                entity.Property(e => e.Lastposter)
                    .HasMaxLength(100)
                    .HasColumnName("lastposter")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lastpostid).HasColumnName("lastpostid");

                entity.Property(e => e.Lastprefixid)
                    .HasMaxLength(25)
                    .HasColumnName("lastprefixid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lastthread)
                    .HasMaxLength(250)
                    .HasColumnName("lastthread")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lastthreadid).HasColumnName("lastthreadid");
            });

            modelBuilder.Entity<ForumsTachythreadcounter>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Threadid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_tachythreadcounter");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Threadid).HasColumnName("threadid");

                entity.Property(e => e.Replycount).HasColumnName("replycount");
            });

            modelBuilder.Entity<ForumsTachythreadpost>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Threadid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_tachythreadpost");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Threadid, "threadid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Threadid).HasColumnName("threadid");

                entity.Property(e => e.Lastpost).HasColumnName("lastpost");

                entity.Property(e => e.Lastposter)
                    .HasMaxLength(100)
                    .HasColumnName("lastposter")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lastpostid).HasColumnName("lastpostid");
            });

            modelBuilder.Entity<ForumsTag>(entity =>
            {
                entity.HasKey(e => e.Tagid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_tag");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Tagtext, "tagtext")
                    .IsUnique();

                entity.Property(e => e.Tagid).HasColumnName("tagid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Tagtext)
                    .HasMaxLength(100)
                    .HasColumnName("tagtext")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsTagsearch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_tagsearch");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Tagid, "tagid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Tagid).HasColumnName("tagid");
            });

            modelBuilder.Entity<ForumsTagthread>(entity =>
            {
                entity.HasKey(e => new { e.Tagid, e.Threadid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_tagthread");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.HasIndex(e => new { e.Threadid, e.Userid }, "threadid");

                entity.Property(e => e.Tagid).HasColumnName("tagid");

                entity.Property(e => e.Threadid).HasColumnName("threadid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsTemplate>(entity =>
            {
                entity.HasKey(e => e.Templateid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_template");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Title, e.Styleid, e.Templatetype }, "title")
                    .IsUnique();

                entity.Property(e => e.Templateid).HasColumnName("templateid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Product)
                    .HasMaxLength(25)
                    .HasColumnName("product")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Styleid).HasColumnName("styleid");

                entity.Property(e => e.Template)
                    .HasColumnType("mediumtext")
                    .HasColumnName("template");

                entity.Property(e => e.TemplateUn)
                    .HasColumnType("mediumtext")
                    .HasColumnName("template_un");

                entity.Property(e => e.Templatetype)
                    .HasColumnType("enum('template','stylevar','css','replacement')")
                    .HasColumnName("templatetype")
                    .HasDefaultValueSql("'template'");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Version)
                    .HasMaxLength(30)
                    .HasColumnName("version")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsTemplatehistory>(entity =>
            {
                entity.HasKey(e => e.Templatehistoryid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_templatehistory");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Title, e.Styleid }, "title");

                entity.Property(e => e.Templatehistoryid).HasColumnName("templatehistoryid");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Styleid).HasColumnName("styleid");

                entity.Property(e => e.Template)
                    .HasColumnType("mediumtext")
                    .HasColumnName("template");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Version)
                    .HasMaxLength(30)
                    .HasColumnName("version")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsThread>(entity =>
            {
                entity.HasKey(e => e.Threadid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_thread");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.HasIndex(e => new { e.Forumid, e.Visible, e.Sticky, e.Lastpost }, "forumid");

                entity.HasIndex(e => e.Importthreadid, "importthread_index");

                entity.HasIndex(e => new { e.Lastpost, e.Forumid }, "lastpost");

                entity.HasIndex(e => e.Pollid, "pollid");

                entity.HasIndex(e => e.Postuserid, "postuserid");

                entity.HasIndex(e => new { e.Prefixid, e.Forumid }, "prefixid");

                entity.HasIndex(e => e.Title, "title")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.Threadid).HasColumnName("threadid");

                entity.Property(e => e.Attach).HasColumnName("attach");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Deletedcount).HasColumnName("deletedcount");

                entity.Property(e => e.Firstpostid).HasColumnName("firstpostid");

                entity.Property(e => e.Forumid).HasColumnName("forumid");

                entity.Property(e => e.Hiddencount).HasColumnName("hiddencount");

                entity.Property(e => e.Iconid).HasColumnName("iconid");

                entity.Property(e => e.Importforumid).HasColumnName("importforumid");

                entity.Property(e => e.Importthreadid).HasColumnName("importthreadid");

                entity.Property(e => e.Lastpost).HasColumnName("lastpost");

                entity.Property(e => e.Lastposter)
                    .HasMaxLength(100)
                    .HasColumnName("lastposter")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lastpostid).HasColumnName("lastpostid");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasColumnName("notes")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Open).HasColumnName("open");

                entity.Property(e => e.Pollid).HasColumnName("pollid");

                entity.Property(e => e.Postuserid).HasColumnName("postuserid");

                entity.Property(e => e.Postusername)
                    .HasMaxLength(100)
                    .HasColumnName("postusername")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Prefixid)
                    .HasMaxLength(25)
                    .HasColumnName("prefixid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Replycount).HasColumnName("replycount");

                entity.Property(e => e.Similar)
                    .HasMaxLength(55)
                    .HasColumnName("similar")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Sticky).HasColumnName("sticky");

                entity.Property(e => e.Taglist)
                    .HasColumnType("mediumtext")
                    .HasColumnName("taglist");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Views).HasColumnName("views");

                entity.Property(e => e.Visible).HasColumnName("visible");

                entity.Property(e => e.Votenum).HasColumnName("votenum");

                entity.Property(e => e.Votetotal).HasColumnName("votetotal");
            });

            modelBuilder.Entity<ForumsThreadrate>(entity =>
            {
                entity.HasKey(e => e.Threadrateid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_threadrate");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Threadid, e.Userid }, "threadid");

                entity.Property(e => e.Threadrateid).HasColumnName("threadrateid");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(45)
                    .HasColumnName("ipaddress")
                    .IsFixedLength();

                entity.Property(e => e.Threadid).HasColumnName("threadid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Vote).HasColumnName("vote");
            });

            modelBuilder.Entity<ForumsThreadread>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Threadid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("forums_threadread");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Readtime, "readtime");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Threadid).HasColumnName("threadid");

                entity.Property(e => e.Readtime).HasColumnName("readtime");
            });

            modelBuilder.Entity<ForumsThreadredirect>(entity =>
            {
                entity.HasKey(e => e.Threadid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_threadredirect");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Expires, "expires");

                entity.Property(e => e.Threadid)
                    .ValueGeneratedNever()
                    .HasColumnName("threadid");

                entity.Property(e => e.Expires).HasColumnName("expires");
            });

            modelBuilder.Entity<ForumsThreadview>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_threadviews");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Threadid, "threadid");

                entity.Property(e => e.Threadid).HasColumnName("threadid");
            });

            modelBuilder.Entity<ForumsTrackWhitelist>(entity =>
            {
                entity.HasKey(e => e.Whitelistid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_track_whitelist");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Whitelistid).HasColumnName("whitelistid");

                entity.Property(e => e.Relationid).HasColumnName("relationid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsUpgradelog>(entity =>
            {
                entity.HasKey(e => e.Upgradelogid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_upgradelog");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Upgradelogid).HasColumnName("upgradelogid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Perpage).HasColumnName("perpage");

                entity.Property(e => e.Script)
                    .HasMaxLength(50)
                    .HasColumnName("script")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Startat).HasColumnName("startat");

                entity.Property(e => e.Step).HasColumnName("step");

                entity.Property(e => e.Steptitle)
                    .HasMaxLength(250)
                    .HasColumnName("steptitle")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsUser>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_user");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Birthday, e.Showbirthday }, "birthday");

                entity.HasIndex(e => e.BirthdaySearch, "birthday_search");

                entity.HasIndex(e => e.Importuserid, "importuser_index");

                entity.HasIndex(e => e.Posts, "posts");

                entity.HasIndex(e => e.Referrerid, "referrerid");

                entity.HasIndex(e => e.Usergroupid, "usergroupid");

                entity.HasIndex(e => e.Username, "username");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Adminoptions).HasColumnName("adminoptions");

                entity.Property(e => e.Aim)
                    .HasMaxLength(20)
                    .HasColumnName("aim")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Autosubscribe)
                    .HasColumnName("autosubscribe")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Avatarid).HasColumnName("avatarid");

                entity.Property(e => e.Avatarrevision).HasColumnName("avatarrevision");

                entity.Property(e => e.Birthday)
                    .HasMaxLength(10)
                    .HasColumnName("birthday")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.BirthdaySearch)
                    .HasColumnName("birthday_search")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.ChangedUsername).HasColumnName("changed_username");

                entity.Property(e => e.Customtitle).HasColumnName("customtitle");

                entity.Property(e => e.Daysprune).HasColumnName("daysprune");

                entity.Property(e => e.Displaygroupid).HasColumnName("displaygroupid");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Emailstamp).HasColumnName("emailstamp");

                entity.Property(e => e.Friendcount).HasColumnName("friendcount");

                entity.Property(e => e.Friendreqcount).HasColumnName("friendreqcount");

                entity.Property(e => e.Gmmoderatedcount).HasColumnName("gmmoderatedcount");

                entity.Property(e => e.Homepage)
                    .HasMaxLength(100)
                    .HasColumnName("homepage")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Icq)
                    .HasMaxLength(20)
                    .HasColumnName("icq")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Importuserid).HasColumnName("importuserid");

                entity.Property(e => e.Infractiongroupid).HasColumnName("infractiongroupid");

                entity.Property(e => e.Infractiongroupids)
                    .HasMaxLength(255)
                    .HasColumnName("infractiongroupids")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Infractions).HasColumnName("infractions");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(45)
                    .HasColumnName("ipaddress")
                    .IsFixedLength();

                entity.Property(e => e.Ipoints).HasColumnName("ipoints");

                entity.Property(e => e.Joindate).HasColumnName("joindate");

                entity.Property(e => e.Languageid).HasColumnName("languageid");

                entity.Property(e => e.Lastactivity).HasColumnName("lastactivity");

                entity.Property(e => e.Lastpost).HasColumnName("lastpost");

                entity.Property(e => e.Lastpostid).HasColumnName("lastpostid");

                entity.Property(e => e.Lastvisit).HasColumnName("lastvisit");

                entity.Property(e => e.Maxposts)
                    .HasColumnName("maxposts")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Membergroupids)
                    .HasMaxLength(250)
                    .HasColumnName("membergroupids")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Msn)
                    .HasMaxLength(100)
                    .HasColumnName("msn")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.NcodeImageresizerMaxheight).HasColumnName("ncode_imageresizer_maxheight");

                entity.Property(e => e.NcodeImageresizerMaxwidth).HasColumnName("ncode_imageresizer_maxwidth");

                entity.Property(e => e.NcodeImageresizerMode)
                    .HasColumnType("enum('none','enlarge','samewindow','newwindow')")
                    .HasColumnName("ncode_imageresizer_mode");

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasDefaultValueSql("'33554447'");

                entity.Property(e => e.Parentemail)
                    .HasMaxLength(50)
                    .HasColumnName("parentemail")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(32)
                    .HasColumnName("password")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Passworddate)
                    .HasColumnName("passworddate")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Pcmoderatedcount).HasColumnName("pcmoderatedcount");

                entity.Property(e => e.Pcunreadcount).HasColumnName("pcunreadcount");

                entity.Property(e => e.Pmpopup).HasColumnName("pmpopup");

                entity.Property(e => e.Pmtotal).HasColumnName("pmtotal");

                entity.Property(e => e.Pmunread).HasColumnName("pmunread");

                entity.Property(e => e.Posts).HasColumnName("posts");

                entity.Property(e => e.Profilepicrevision).HasColumnName("profilepicrevision");

                entity.Property(e => e.Profilevisits).HasColumnName("profilevisits");

                entity.Property(e => e.Referrerid).HasColumnName("referrerid");

                entity.Property(e => e.Reputation)
                    .HasColumnName("reputation")
                    .HasDefaultValueSql("'10'");

                entity.Property(e => e.Reputationlevelid)
                    .HasColumnName("reputationlevelid")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Salt)
                    .HasMaxLength(30)
                    .HasColumnName("salt")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Showbirthday)
                    .HasColumnName("showbirthday")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Showvbcode).HasColumnName("showvbcode");

                entity.Property(e => e.Sigpicrevision).HasColumnName("sigpicrevision");

                entity.Property(e => e.Skype)
                    .HasMaxLength(32)
                    .HasColumnName("skype")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Socgroupinvitecount).HasColumnName("socgroupinvitecount");

                entity.Property(e => e.Socgroupreqcount).HasColumnName("socgroupreqcount");

                entity.Property(e => e.Startofweek)
                    .HasColumnName("startofweek")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Styleid).HasColumnName("styleid");

                entity.Property(e => e.Threadedmode).HasColumnName("threadedmode");

                entity.Property(e => e.Timezoneoffset)
                    .HasMaxLength(4)
                    .HasColumnName("timezoneoffset")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Usertitle)
                    .HasMaxLength(250)
                    .HasColumnName("usertitle")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Vmmoderatedcount).HasColumnName("vmmoderatedcount");

                entity.Property(e => e.Vmunreadcount).HasColumnName("vmunreadcount");

                entity.Property(e => e.Warnings).HasColumnName("warnings");

                entity.Property(e => e.Yahoo)
                    .HasMaxLength(32)
                    .HasColumnName("yahoo")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ForumsUseractivation>(entity =>
            {
                entity.HasKey(e => e.Useractivationid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_useractivation");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Userid, e.Type }, "userid")
                    .IsUnique();

                entity.Property(e => e.Useractivationid).HasColumnName("useractivationid");

                entity.Property(e => e.Activationid)
                    .HasMaxLength(40)
                    .HasColumnName("activationid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Emailchange).HasColumnName("emailchange");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsUserban>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_userban");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Liftdate, "liftdate");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.Adminid).HasColumnName("adminid");

                entity.Property(e => e.Bandate).HasColumnName("bandate");

                entity.Property(e => e.Customtitle).HasColumnName("customtitle");

                entity.Property(e => e.Displaygroupid).HasColumnName("displaygroupid");

                entity.Property(e => e.Liftdate).HasColumnName("liftdate");

                entity.Property(e => e.Reason)
                    .HasMaxLength(250)
                    .HasColumnName("reason")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");

                entity.Property(e => e.Usertitle)
                    .HasMaxLength(250)
                    .HasColumnName("usertitle")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsUserchangelog>(entity =>
            {
                entity.HasKey(e => e.Changeid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_userchangelog");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Adminid, e.ChangeTime }, "adminid");

                entity.HasIndex(e => e.ChangeTime, "change_time");

                entity.HasIndex(e => e.ChangeUniq, "change_uniq");

                entity.HasIndex(e => new { e.Fieldname, e.ChangeTime }, "fieldname");

                entity.HasIndex(e => new { e.Userid, e.ChangeTime }, "userid");

                entity.Property(e => e.Changeid).HasColumnName("changeid");

                entity.Property(e => e.Adminid).HasColumnName("adminid");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.ChangeUniq)
                    .HasMaxLength(32)
                    .HasColumnName("change_uniq")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Fieldname)
                    .HasMaxLength(250)
                    .HasColumnName("fieldname")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Newvalue)
                    .HasMaxLength(250)
                    .HasColumnName("newvalue")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Oldvalue)
                    .HasMaxLength(250)
                    .HasColumnName("oldvalue")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsUsercss>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Selector, e.Property })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("forums_usercss");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Property, e.Userid, e.Value }, "property")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 20 });

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Selector)
                    .HasMaxLength(30)
                    .HasColumnName("selector")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Property)
                    .HasMaxLength(30)
                    .HasColumnName("property")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsUsercsscache>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_usercsscache");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.Buildpermissions).HasColumnName("buildpermissions");

                entity.Property(e => e.Cachedcss)
                    .HasColumnType("text")
                    .HasColumnName("cachedcss");
            });

            modelBuilder.Entity<ForumsUserfield>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_userfield");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.Field1)
                    .HasColumnType("mediumtext")
                    .HasColumnName("field1");

                entity.Property(e => e.Field2)
                    .HasColumnType("mediumtext")
                    .HasColumnName("field2");

                entity.Property(e => e.Field3)
                    .HasColumnType("mediumtext")
                    .HasColumnName("field3");

                entity.Property(e => e.Field4)
                    .HasColumnType("mediumtext")
                    .HasColumnName("field4");

                entity.Property(e => e.Field5)
                    .HasColumnType("mediumtext")
                    .HasColumnName("field5");

                entity.Property(e => e.Field7)
                    .HasColumnType("mediumtext")
                    .HasColumnName("field7");

                entity.Property(e => e.Field8)
                    .HasColumnType("mediumtext")
                    .HasColumnName("field8");

                entity.Property(e => e.Temp)
                    .HasColumnType("mediumtext")
                    .HasColumnName("temp");
            });

            modelBuilder.Entity<ForumsUsergroup>(entity =>
            {
                entity.HasKey(e => e.Usergroupid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_usergroup");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");

                entity.Property(e => e.Adminpermissions).HasColumnName("adminpermissions");

                entity.Property(e => e.Albummaxpics).HasColumnName("albummaxpics");

                entity.Property(e => e.Albummaxsize).HasColumnName("albummaxsize");

                entity.Property(e => e.Albumpermissions).HasColumnName("albumpermissions");

                entity.Property(e => e.Albumpicmaxheight).HasColumnName("albumpicmaxheight");

                entity.Property(e => e.Albumpicmaxsize).HasColumnName("albumpicmaxsize");

                entity.Property(e => e.Albumpicmaxwidth).HasColumnName("albumpicmaxwidth");

                entity.Property(e => e.Attachlimit).HasColumnName("attachlimit");

                entity.Property(e => e.Avatarmaxheight).HasColumnName("avatarmaxheight");

                entity.Property(e => e.Avatarmaxsize).HasColumnName("avatarmaxsize");

                entity.Property(e => e.Avatarmaxwidth).HasColumnName("avatarmaxwidth");

                entity.Property(e => e.Calendarpermissions).HasColumnName("calendarpermissions");

                entity.Property(e => e.Cannedreplies).HasColumnName("cannedreplies");

                entity.Property(e => e.Canoverride).HasColumnName("canoverride");

                entity.Property(e => e.Closetag)
                    .HasMaxLength(100)
                    .HasColumnName("closetag")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dtogaragepermissions).HasColumnName("dtogaragepermissions");

                entity.Property(e => e.Dtogaragesize)
                    .HasColumnName("dtogaragesize")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.Forumpermissions).HasColumnName("forumpermissions");

                entity.Property(e => e.Genericoptions).HasColumnName("genericoptions");

                entity.Property(e => e.Genericpermissions).HasColumnName("genericpermissions");

                entity.Property(e => e.Genericpermissions2).HasColumnName("genericpermissions2");

                entity.Property(e => e.Groupiconmaxsize).HasColumnName("groupiconmaxsize");

                entity.Property(e => e.Importusergroupid).HasColumnName("importusergroupid");

                entity.Property(e => e.Ispublicgroup).HasColumnName("ispublicgroup");

                entity.Property(e => e.Maxcr)
                    .HasColumnName("maxcr")
                    .HasDefaultValueSql("'8'");

                entity.Property(e => e.Maximumsocialgroups).HasColumnName("maximumsocialgroups");

                entity.Property(e => e.Opentag)
                    .HasMaxLength(100)
                    .HasColumnName("opentag")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Passwordexpires).HasColumnName("passwordexpires");

                entity.Property(e => e.Passwordhistory).HasColumnName("passwordhistory");

                entity.Property(e => e.Pmpermissions).HasColumnName("pmpermissions");

                entity.Property(e => e.Pmquota).HasColumnName("pmquota");

                entity.Property(e => e.Pmsendmax)
                    .HasColumnName("pmsendmax")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.Pmthrottlequantity).HasColumnName("pmthrottlequantity");

                entity.Property(e => e.Profilepicmaxheight).HasColumnName("profilepicmaxheight");

                entity.Property(e => e.Profilepicmaxsize).HasColumnName("profilepicmaxsize");

                entity.Property(e => e.Profilepicmaxwidth).HasColumnName("profilepicmaxwidth");

                entity.Property(e => e.Sigmaxchars).HasColumnName("sigmaxchars");

                entity.Property(e => e.Sigmaximages).HasColumnName("sigmaximages");

                entity.Property(e => e.Sigmaxlines).HasColumnName("sigmaxlines");

                entity.Property(e => e.Sigmaxrawchars).HasColumnName("sigmaxrawchars");

                entity.Property(e => e.Sigmaxsizebbcode).HasColumnName("sigmaxsizebbcode");

                entity.Property(e => e.Signaturepermissions).HasColumnName("signaturepermissions");

                entity.Property(e => e.Sigpicmaxheight).HasColumnName("sigpicmaxheight");

                entity.Property(e => e.Sigpicmaxsize).HasColumnName("sigpicmaxsize");

                entity.Property(e => e.Sigpicmaxwidth).HasColumnName("sigpicmaxwidth");

                entity.Property(e => e.Skhardmodpermissions).HasColumnName("skhardmodpermissions");

                entity.Property(e => e.Socialgrouppermissions).HasColumnName("socialgrouppermissions");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Usercsspermissions).HasColumnName("usercsspermissions");

                entity.Property(e => e.Usertitle)
                    .HasMaxLength(100)
                    .HasColumnName("usertitle")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Visitormessagepermissions).HasColumnName("visitormessagepermissions");

                entity.Property(e => e.Wolpermissions).HasColumnName("wolpermissions");
            });

            modelBuilder.Entity<ForumsUsergroupleader>(entity =>
            {
                entity.HasKey(e => e.Usergroupleaderid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_usergroupleader");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Userid, e.Usergroupid }, "ugl");

                entity.Property(e => e.Usergroupleaderid).HasColumnName("usergroupleaderid");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsUsergrouprequest>(entity =>
            {
                entity.HasKey(e => e.Usergrouprequestid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_usergrouprequest");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Usergroupid, "usergroupid");

                entity.HasIndex(e => new { e.Userid, e.Usergroupid }, "userid")
                    .IsUnique();

                entity.Property(e => e.Usergrouprequestid).HasColumnName("usergrouprequestid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Reason)
                    .HasMaxLength(250)
                    .HasColumnName("reason")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsUserlist>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Relationid, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("forums_userlist");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Relationid, e.Type, e.Friend }, "relationid");

                entity.HasIndex(e => new { e.Userid, e.Type, e.Friend }, "userid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Relationid).HasColumnName("relationid");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('buddy','ignore')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'buddy'");

                entity.Property(e => e.Friend)
                    .HasColumnType("enum('yes','no','pending','denied')")
                    .HasColumnName("friend")
                    .HasDefaultValueSql("'no'");
            });

            modelBuilder.Entity<ForumsUsernote>(entity =>
            {
                entity.HasKey(e => e.Usernoteid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_usernote");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Posterid, "posterid");

                entity.HasIndex(e => e.Userid, "userid");

                entity.Property(e => e.Usernoteid).HasColumnName("usernoteid");

                entity.Property(e => e.Allowsmilies).HasColumnName("allowsmilies");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Importusernoteid).HasColumnName("importusernoteid");

                entity.Property(e => e.Message)
                    .HasColumnType("mediumtext")
                    .HasColumnName("message");

                entity.Property(e => e.Posterid).HasColumnName("posterid");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ForumsUserpromotion>(entity =>
            {
                entity.HasKey(e => e.Userpromotionid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_userpromotion");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Usergroupid, "usergroupid");

                entity.Property(e => e.Userpromotionid).HasColumnName("userpromotionid");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Joinusergroupid).HasColumnName("joinusergroupid");

                entity.Property(e => e.Posts).HasColumnName("posts");

                entity.Property(e => e.Reputation).HasColumnName("reputation");

                entity.Property(e => e.Strategy).HasColumnName("strategy");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");
            });

            modelBuilder.Entity<ForumsUsertextfield>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_usertextfield");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.Buddylist)
                    .HasColumnType("mediumtext")
                    .HasColumnName("buddylist");

                entity.Property(e => e.Ignorelist)
                    .HasColumnType("mediumtext")
                    .HasColumnName("ignorelist");

                entity.Property(e => e.Pmfolders)
                    .HasColumnType("mediumtext")
                    .HasColumnName("pmfolders");

                entity.Property(e => e.Rank)
                    .HasColumnType("mediumtext")
                    .HasColumnName("rank");

                entity.Property(e => e.Searchprefs)
                    .HasColumnType("mediumtext")
                    .HasColumnName("searchprefs");

                entity.Property(e => e.Signature)
                    .HasColumnType("mediumtext")
                    .HasColumnName("signature");

                entity.Property(e => e.Subfolders)
                    .HasColumnType("mediumtext")
                    .HasColumnName("subfolders");
            });

            modelBuilder.Entity<ForumsUsertitle>(entity =>
            {
                entity.HasKey(e => e.Usertitleid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_usertitle");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Usertitleid).HasColumnName("usertitleid");

                entity.Property(e => e.Minposts).HasColumnName("minposts");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ForumsVbfield>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_vbfields");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Defaultvalue)
                    .HasMaxLength(200)
                    .HasColumnName("defaultvalue")
                    .HasDefaultValueSql("'!##NULL##!'");

                entity.Property(e => e.Dictionary)
                    .HasColumnType("mediumtext")
                    .HasColumnName("dictionary");

                entity.Property(e => e.Fieldname)
                    .HasMaxLength(50)
                    .HasColumnName("fieldname")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Product)
                    .HasMaxLength(25)
                    .HasColumnName("product")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tablename)
                    .HasMaxLength(20)
                    .HasColumnName("tablename")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Vbmandatory)
                    .HasColumnType("enum('Y','N','A')")
                    .HasColumnName("vbmandatory")
                    .HasDefaultValueSql("'N'");
            });

            modelBuilder.Entity<ForumsVisitormessage>(entity =>
            {
                entity.HasKey(e => e.Vmid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_visitormessage");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Postuserid, e.Userid, e.State }, "postuserid");

                entity.HasIndex(e => new { e.Userid, e.Dateline, e.State }, "userid");

                entity.Property(e => e.Vmid).HasColumnName("vmid");

                entity.Property(e => e.Allowsmilie).HasColumnName("allowsmilie");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Ipaddress).HasColumnName("ipaddress");

                entity.Property(e => e.Messageread).HasColumnName("messageread");

                entity.Property(e => e.Pagetext)
                    .HasColumnType("mediumtext")
                    .HasColumnName("pagetext");

                entity.Property(e => e.Postuserid).HasColumnName("postuserid");

                entity.Property(e => e.Postusername)
                    .HasMaxLength(100)
                    .HasColumnName("postusername")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Reportthreadid).HasColumnName("reportthreadid");

                entity.Property(e => e.State)
                    .HasColumnType("enum('visible','moderation','deleted')")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'visible'");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsVisitormessageHash>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forums_visitormessage_hash");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Dateline, "dateline");

                entity.HasIndex(e => new { e.Postuserid, e.Dupehash }, "postuserid");

                entity.Property(e => e.Dateline).HasColumnName("dateline");

                entity.Property(e => e.Dupehash)
                    .HasMaxLength(32)
                    .HasColumnName("dupehash")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Postuserid).HasColumnName("postuserid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ForumsWord>(entity =>
            {
                entity.HasKey(e => e.Wordid)
                    .HasName("PRIMARY");

                entity.ToTable("forums_word");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Title, "title")
                    .IsUnique();

                entity.Property(e => e.Wordid).HasColumnName("wordid");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Hit>(entity =>
            {
                entity.ToTable("hits");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Date, "date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Browser)
                    .HasColumnType("text")
                    .HasColumnName("browser");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<ImagesList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("images_list");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");
            });

            modelBuilder.Entity<IpbadminLog>(entity =>
            {
                entity.ToTable("ipbadmin_logs");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Ctime, "ctime");

                entity.HasIndex(e => e.IpAddress, "ip_address");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Appcomponent)
                    .HasMaxLength(255)
                    .HasColumnName("appcomponent")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ctime)
                    .HasColumnName("ctime")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Do)
                    .HasMaxLength(255)
                    .HasColumnName("do")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("ip_address");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Module)
                    .HasMaxLength(255)
                    .HasColumnName("module")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.Property(e => e.Section)
                    .HasMaxLength(255)
                    .HasColumnName("section")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbadminLoginLog>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbadmin_login_logs");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.AdminIpAddress, "admin_ip_address");

                entity.HasIndex(e => e.AdminTime, "admin_time");

                entity.Property(e => e.AdminId).HasColumnName("admin_id");

                entity.Property(e => e.AdminIpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("admin_ip_address")
                    .HasDefaultValueSql("'0.0.0.0'");

                entity.Property(e => e.AdminPostDetails)
                    .HasColumnType("text")
                    .HasColumnName("admin_post_details");

                entity.Property(e => e.AdminSuccess).HasColumnName("admin_success");

                entity.Property(e => e.AdminTime).HasColumnName("admin_time");

                entity.Property(e => e.AdminUsername)
                    .HasMaxLength(40)
                    .HasColumnName("admin_username")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbadminPermissionRow>(entity =>
            {
                entity.HasKey(e => new { e.RowId, e.RowIdType })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("ipbadmin_permission_rows");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.RowId).HasColumnName("row_id");

                entity.Property(e => e.RowIdType)
                    .HasMaxLength(13)
                    .HasColumnName("row_id_type")
                    .HasDefaultValueSql("'member'");

                entity.Property(e => e.RowPermCache)
                    .HasColumnType("mediumtext")
                    .HasColumnName("row_perm_cache");

                entity.Property(e => e.RowUpdated).HasColumnName("row_updated");
            });

            modelBuilder.Entity<Ipbannouncement>(entity =>
            {
                entity.HasKey(e => e.AnnounceId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbannouncements");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.AnnounceEnd, "announce_end");

                entity.Property(e => e.AnnounceId).HasColumnName("announce_id");

                entity.Property(e => e.AnnounceActive)
                    .IsRequired()
                    .HasColumnName("announce_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AnnounceEnd).HasColumnName("announce_end");

                entity.Property(e => e.AnnounceForum)
                    .HasColumnType("text")
                    .HasColumnName("announce_forum");

                entity.Property(e => e.AnnounceHtmlEnabled).HasColumnName("announce_html_enabled");

                entity.Property(e => e.AnnounceMemberId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("announce_member_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AnnounceNlbrEnabled).HasColumnName("announce_nlbr_enabled");

                entity.Property(e => e.AnnouncePost)
                    .HasColumnType("text")
                    .HasColumnName("announce_post");

                entity.Property(e => e.AnnounceStart).HasColumnName("announce_start");

                entity.Property(e => e.AnnounceTitle)
                    .HasMaxLength(255)
                    .HasColumnName("announce_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AnnounceViews).HasColumnName("announce_views");
            });

            modelBuilder.Entity<IpbapiLog>(entity =>
            {
                entity.HasKey(e => e.ApiLogId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbapi_log");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.ApiLogDate, "api_log_date");

                entity.Property(e => e.ApiLogId).HasColumnName("api_log_id");

                entity.Property(e => e.ApiLogAllowed).HasColumnName("api_log_allowed");

                entity.Property(e => e.ApiLogDate).HasColumnName("api_log_date");

                entity.Property(e => e.ApiLogIp)
                    .HasMaxLength(46)
                    .HasColumnName("api_log_ip");

                entity.Property(e => e.ApiLogKey)
                    .HasMaxLength(32)
                    .HasColumnName("api_log_key");

                entity.Property(e => e.ApiLogQuery)
                    .HasColumnType("text")
                    .HasColumnName("api_log_query");
            });

            modelBuilder.Entity<IpbapiUser>(entity =>
            {
                entity.HasKey(e => e.ApiUserId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbapi_users");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.ApiUserId).HasColumnName("api_user_id");

                entity.Property(e => e.ApiUserIp)
                    .HasMaxLength(46)
                    .HasColumnName("api_user_ip");

                entity.Property(e => e.ApiUserKey)
                    .HasMaxLength(32)
                    .HasColumnName("api_user_key")
                    .IsFixedLength();

                entity.Property(e => e.ApiUserName)
                    .HasMaxLength(32)
                    .HasColumnName("api_user_name");

                entity.Property(e => e.ApiUserPerms)
                    .HasColumnType("text")
                    .HasColumnName("api_user_perms");
            });

            modelBuilder.Entity<Ipbattachment>(entity =>
            {
                entity.HasKey(e => e.AttachId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbattachments");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.AttachMemberId, e.AttachRelModule, e.AttachFilesize }, "attach_mid_size");

                entity.HasIndex(e => new { e.AttachParentId, e.AttachRelModule }, "attach_parent_id");

                entity.HasIndex(e => e.AttachRelId, "attach_pid");

                entity.HasIndex(e => e.AttachPostKey, "attach_post_key");

                entity.Property(e => e.AttachId).HasColumnName("attach_id");

                entity.Property(e => e.AttachDate).HasColumnName("attach_date");

                entity.Property(e => e.AttachExt)
                    .HasMaxLength(10)
                    .HasColumnName("attach_ext")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AttachFile)
                    .HasMaxLength(250)
                    .HasColumnName("attach_file")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AttachFilesize).HasColumnName("attach_filesize");

                entity.Property(e => e.AttachHits).HasColumnName("attach_hits");

                entity.Property(e => e.AttachImgHeight).HasColumnName("attach_img_height");

                entity.Property(e => e.AttachImgWidth).HasColumnName("attach_img_width");

                entity.Property(e => e.AttachIsImage).HasColumnName("attach_is_image");

                entity.Property(e => e.AttachLocation)
                    .HasMaxLength(250)
                    .HasColumnName("attach_location")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AttachMemberId).HasColumnName("attach_member_id");

                entity.Property(e => e.AttachParentId).HasColumnName("attach_parent_id");

                entity.Property(e => e.AttachPostKey)
                    .HasMaxLength(32)
                    .HasColumnName("attach_post_key")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AttachRelId).HasColumnName("attach_rel_id");

                entity.Property(e => e.AttachRelModule)
                    .HasMaxLength(100)
                    .HasColumnName("attach_rel_module")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AttachThumbHeight).HasColumnName("attach_thumb_height");

                entity.Property(e => e.AttachThumbLocation)
                    .HasMaxLength(250)
                    .HasColumnName("attach_thumb_location")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AttachThumbWidth).HasColumnName("attach_thumb_width");
            });

            modelBuilder.Entity<IpbattachmentsType>(entity =>
            {
                entity.HasKey(e => e.AtypeId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbattachments_type");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.AtypePost, "atype");

                entity.HasIndex(e => e.AtypeExtension, "atype_extension");

                entity.Property(e => e.AtypeId).HasColumnName("atype_id");

                entity.Property(e => e.AtypeExtension)
                    .HasMaxLength(18)
                    .HasColumnName("atype_extension")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AtypeImg)
                    .HasColumnType("text")
                    .HasColumnName("atype_img");

                entity.Property(e => e.AtypeMimetype)
                    .HasMaxLength(255)
                    .HasColumnName("atype_mimetype")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AtypePost)
                    .IsRequired()
                    .HasColumnName("atype_post")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Ipbbadword>(entity =>
            {
                entity.HasKey(e => e.Wid)
                    .HasName("PRIMARY");

                entity.ToTable("ipbbadwords");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.Property(e => e.MExact)
                    .HasColumnName("m_exact")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Swop)
                    .HasMaxLength(250)
                    .HasColumnName("swop");

                entity.Property(e => e.Type)
                    .HasMaxLength(250)
                    .HasColumnName("type")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Ipbbanfilter>(entity =>
            {
                entity.HasKey(e => e.BanId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbbanfilters");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.BanContent, "ban_content")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 200 });

                entity.Property(e => e.BanId).HasColumnName("ban_id");

                entity.Property(e => e.BanContent)
                    .HasColumnType("text")
                    .HasColumnName("ban_content");

                entity.Property(e => e.BanDate).HasColumnName("ban_date");

                entity.Property(e => e.BanReason)
                    .HasMaxLength(255)
                    .HasColumnName("ban_reason");

                entity.Property(e => e.BanType)
                    .HasMaxLength(10)
                    .HasColumnName("ban_type")
                    .HasDefaultValueSql("'ip'");
            });

            modelBuilder.Entity<IpbbbcodeMediatag>(entity =>
            {
                entity.HasKey(e => e.MediatagId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbbbcode_mediatag");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.MediatagId).HasColumnName("mediatag_id");

                entity.Property(e => e.MediatagMatch)
                    .HasColumnType("text")
                    .HasColumnName("mediatag_match");

                entity.Property(e => e.MediatagName)
                    .HasMaxLength(255)
                    .HasColumnName("mediatag_name");

                entity.Property(e => e.MediatagPosition).HasColumnName("mediatag_position");

                entity.Property(e => e.MediatagReplace)
                    .HasColumnType("text")
                    .HasColumnName("mediatag_replace");
            });

            modelBuilder.Entity<IpbbulkMail>(entity =>
            {
                entity.HasKey(e => e.MailId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbbulk_mail");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.MailStart, "mail_start");

                entity.Property(e => e.MailId).HasColumnName("mail_id");

                entity.Property(e => e.MailActive).HasColumnName("mail_active");

                entity.Property(e => e.MailContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("mail_content");

                entity.Property(e => e.MailGroups)
                    .HasColumnType("mediumtext")
                    .HasColumnName("mail_groups");

                entity.Property(e => e.MailOpts)
                    .HasColumnType("mediumtext")
                    .HasColumnName("mail_opts");

                entity.Property(e => e.MailPergo).HasColumnName("mail_pergo");

                entity.Property(e => e.MailSentto).HasColumnName("mail_sentto");

                entity.Property(e => e.MailStart).HasColumnName("mail_start");

                entity.Property(e => e.MailSubject)
                    .HasMaxLength(255)
                    .HasColumnName("mail_subject")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MailUpdated).HasColumnName("mail_updated");
            });

            modelBuilder.Entity<IpbcacheSimple>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ipbcache_simple");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.CacheId, e.CachePermKey }, "lookup")
                    .IsUnique();

                entity.Property(e => e.CacheData)
                    .HasColumnType("mediumtext")
                    .HasColumnName("cache_data");

                entity.Property(e => e.CacheId)
                    .HasMaxLength(32)
                    .HasColumnName("cache_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CachePermKey)
                    .HasMaxLength(32)
                    .HasColumnName("cache_perm_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheTime).HasColumnName("cache_time");
            });

            modelBuilder.Entity<IpbcacheStore>(entity =>
            {
                entity.HasKey(e => e.CsKey)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcache_store");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.CsKey)
                    .HasColumnName("cs_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CsArray).HasColumnName("cs_array");

                entity.Property(e => e.CsRebuild).HasColumnName("cs_rebuild");

                entity.Property(e => e.CsUpdated).HasColumnName("cs_updated");

                entity.Property(e => e.CsValue)
                    .HasColumnType("mediumtext")
                    .HasColumnName("cs_value");
            });

            modelBuilder.Entity<Ipbcaptcha>(entity =>
            {
                entity.HasKey(e => e.CaptchaUniqueId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcaptcha");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.CaptchaDate, "captcha_date");

                entity.Property(e => e.CaptchaUniqueId)
                    .HasMaxLength(32)
                    .HasColumnName("captcha_unique_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaptchaDate).HasColumnName("captcha_date");

                entity.Property(e => e.CaptchaIpaddress)
                    .HasMaxLength(46)
                    .HasColumnName("captcha_ipaddress");

                entity.Property(e => e.CaptchaString)
                    .HasMaxLength(100)
                    .HasColumnName("captcha_string")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbcontentCachePost>(entity =>
            {
                entity.HasKey(e => e.CacheContentId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcontent_cache_posts");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.CacheUpdated, "date_index");

                entity.Property(e => e.CacheContentId)
                    .ValueGeneratedNever()
                    .HasColumnName("cache_content_id");

                entity.Property(e => e.CacheContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("cache_content");

                entity.Property(e => e.CacheUpdated).HasColumnName("cache_updated");
            });

            modelBuilder.Entity<IpbcontentCacheSig>(entity =>
            {
                entity.HasKey(e => e.CacheContentId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcontent_cache_sigs");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.CacheUpdated, "date_index");

                entity.Property(e => e.CacheContentId)
                    .ValueGeneratedNever()
                    .HasColumnName("cache_content_id");

                entity.Property(e => e.CacheContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("cache_content");

                entity.Property(e => e.CacheUpdated).HasColumnName("cache_updated");
            });

            modelBuilder.Entity<IpbconvApp>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbconv_apps");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.AppId)
                    .HasColumnType("mediumint")
                    .HasColumnName("app_id");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(32)
                    .HasColumnName("app_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DbCharset)
                    .HasMaxLength(32)
                    .HasColumnName("db_charset")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DbDb)
                    .HasMaxLength(128)
                    .HasColumnName("db_db")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DbDriver)
                    .HasMaxLength(32)
                    .HasColumnName("db_driver")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DbHost)
                    .HasMaxLength(128)
                    .HasColumnName("db_host")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DbPass)
                    .HasMaxLength(128)
                    .HasColumnName("db_pass")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DbPrefix)
                    .HasMaxLength(32)
                    .HasColumnName("db_prefix")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DbUser)
                    .HasMaxLength(128)
                    .HasColumnName("db_user")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Parent)
                    .HasColumnType("mediumint")
                    .HasColumnName("parent")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sw)
                    .HasMaxLength(32)
                    .HasColumnName("sw")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbconvLink>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbconv_link");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.ForeignId, e.Type }, "foreign_id");

                entity.Property(e => e.LinkId).HasColumnName("link_id");

                entity.Property(e => e.App)
                    .HasColumnType("mediumint")
                    .HasColumnName("app")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Duplicate).HasColumnName("duplicate");

                entity.Property(e => e.ForeignId)
                    .HasColumnName("foreign_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IpbId)
                    .HasColumnType("mediumint")
                    .HasColumnName("ipb_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasMaxLength(32)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<IpbconvergeLocal>(entity =>
            {
                entity.HasKey(e => e.ConvergeApiCode)
                    .HasName("PRIMARY");

                entity.ToTable("ipbconverge_local");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.ConvergeActive, "converge_active");

                entity.Property(e => e.ConvergeApiCode)
                    .HasMaxLength(32)
                    .HasColumnName("converge_api_code")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConvergeActive).HasColumnName("converge_active");

                entity.Property(e => e.ConvergeAdded).HasColumnName("converge_added");

                entity.Property(e => e.ConvergeHttpPass)
                    .HasMaxLength(255)
                    .HasColumnName("converge_http_pass")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConvergeHttpUser)
                    .HasMaxLength(255)
                    .HasColumnName("converge_http_user")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConvergeIpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("converge_ip_address");

                entity.Property(e => e.ConvergeProductId).HasColumnName("converge_product_id");

                entity.Property(e => e.ConvergeUrl)
                    .HasMaxLength(255)
                    .HasColumnName("converge_url")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbcoreApplication>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_applications");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.AppDirectory, "app_directory");

                entity.Property(e => e.AppId).HasColumnName("app_id");

                entity.Property(e => e.AppAdded).HasColumnName("app_added");

                entity.Property(e => e.AppAuthor)
                    .HasMaxLength(255)
                    .HasColumnName("app_author")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AppDescription)
                    .HasMaxLength(255)
                    .HasColumnName("app_description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AppDirectory)
                    .HasColumnName("app_directory")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AppEnabled).HasColumnName("app_enabled");

                entity.Property(e => e.AppGlobalCaches)
                    .HasMaxLength(255)
                    .HasColumnName("app_global_caches");

                entity.Property(e => e.AppHideTab).HasColumnName("app_hide_tab");

                entity.Property(e => e.AppLocation)
                    .HasMaxLength(32)
                    .HasColumnName("app_location")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AppLongVersion)
                    .HasColumnName("app_long_version")
                    .HasDefaultValueSql("'10000'");

                entity.Property(e => e.AppPosition).HasColumnName("app_position");

                entity.Property(e => e.AppProtected).HasColumnName("app_protected");

                entity.Property(e => e.AppPublicTitle)
                    .HasMaxLength(255)
                    .HasColumnName("app_public_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AppTabGroups)
                    .HasColumnType("text")
                    .HasColumnName("app_tab_groups");

                entity.Property(e => e.AppTitle)
                    .HasMaxLength(255)
                    .HasColumnName("app_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AppUpdateCheck)
                    .HasMaxLength(255)
                    .HasColumnName("app_update_check");

                entity.Property(e => e.AppVersion)
                    .HasMaxLength(255)
                    .HasColumnName("app_version")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AppWebsite)
                    .HasMaxLength(255)
                    .HasColumnName("app_website");
            });

            modelBuilder.Entity<IpbcoreEditorAutosave>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ipbcore_editor_autosave");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.EasKey, "eas_key")
                    .IsUnique();

                entity.HasIndex(e => new { e.EasMemberId, e.EasApp, e.EasSection }, "eas_member_lookup");

                entity.HasIndex(e => e.EasUpdated, "eas_updated");

                entity.Property(e => e.EasApp)
                    .HasMaxLength(50)
                    .HasColumnName("eas_app")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EasContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("eas_content");

                entity.Property(e => e.EasKey)
                    .HasMaxLength(32)
                    .HasColumnName("eas_key")
                    .IsFixedLength();

                entity.Property(e => e.EasMemberId).HasColumnName("eas_member_id");

                entity.Property(e => e.EasSection)
                    .HasMaxLength(100)
                    .HasColumnName("eas_section")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EasUpdated).HasColumnName("eas_updated");
            });

            modelBuilder.Entity<IpbcoreGeolocationCache>(entity =>
            {
                entity.HasKey(e => e.GeocacheKey)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_geolocation_cache");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.GeocacheLat, e.GeocacheLon }, "geo_lat_lon");

                entity.Property(e => e.GeocacheKey)
                    .HasMaxLength(32)
                    .HasColumnName("geocache_key");

                entity.Property(e => e.GeocacheAdded).HasColumnName("geocache_added");

                entity.Property(e => e.GeocacheCountry)
                    .HasMaxLength(255)
                    .HasColumnName("geocache_country")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GeocacheDistrict)
                    .HasMaxLength(255)
                    .HasColumnName("geocache_district")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GeocacheDistrict2)
                    .HasMaxLength(255)
                    .HasColumnName("geocache_district2")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GeocacheEngine)
                    .HasMaxLength(255)
                    .HasColumnName("geocache_engine")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GeocacheLat)
                    .HasMaxLength(100)
                    .HasColumnName("geocache_lat");

                entity.Property(e => e.GeocacheLocality)
                    .HasMaxLength(255)
                    .HasColumnName("geocache_locality")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GeocacheLon)
                    .HasMaxLength(100)
                    .HasColumnName("geocache_lon");

                entity.Property(e => e.GeocacheRaw)
                    .HasColumnType("text")
                    .HasColumnName("geocache_raw");

                entity.Property(e => e.GeocacheShort)
                    .HasColumnType("text")
                    .HasColumnName("geocache_short");

                entity.Property(e => e.GeocacheType)
                    .HasMaxLength(255)
                    .HasColumnName("geocache_type")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbcoreHook>(entity =>
            {
                entity.HasKey(e => e.HookId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_hooks");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.HookId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("hook_id");

                entity.Property(e => e.HookAuthor)
                    .HasMaxLength(255)
                    .HasColumnName("hook_author");

                entity.Property(e => e.HookDesc)
                    .HasColumnType("text")
                    .HasColumnName("hook_desc");

                entity.Property(e => e.HookEmail)
                    .HasMaxLength(255)
                    .HasColumnName("hook_email");

                entity.Property(e => e.HookEnabled).HasColumnName("hook_enabled");

                entity.Property(e => e.HookExtraData)
                    .HasColumnType("text")
                    .HasColumnName("hook_extra_data");

                entity.Property(e => e.HookGlobalCaches)
                    .HasMaxLength(255)
                    .HasColumnName("hook_global_caches");

                entity.Property(e => e.HookInstalled).HasColumnName("hook_installed");

                entity.Property(e => e.HookKey)
                    .HasMaxLength(32)
                    .HasColumnName("hook_key");

                entity.Property(e => e.HookName)
                    .HasMaxLength(255)
                    .HasColumnName("hook_name");

                entity.Property(e => e.HookPosition)
                    .HasColumnType("mediumint")
                    .HasColumnName("hook_position")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HookRequirements)
                    .HasColumnType("text")
                    .HasColumnName("hook_requirements");

                entity.Property(e => e.HookUpdateCheck)
                    .HasColumnType("text")
                    .HasColumnName("hook_update_check");

                entity.Property(e => e.HookUpdated).HasColumnName("hook_updated");

                entity.Property(e => e.HookVersionHuman)
                    .HasMaxLength(32)
                    .HasColumnName("hook_version_human");

                entity.Property(e => e.HookVersionLong)
                    .HasMaxLength(32)
                    .HasColumnName("hook_version_long")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HookWebsite)
                    .HasColumnType("text")
                    .HasColumnName("hook_website");
            });

            modelBuilder.Entity<IpbcoreHooksFile>(entity =>
            {
                entity.HasKey(e => e.HookFileId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_hooks_files");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.HookHookId, "hook_hook_id");

                entity.Property(e => e.HookFileId).HasColumnName("hook_file_id");

                entity.Property(e => e.HookClassname)
                    .HasMaxLength(255)
                    .HasColumnName("hook_classname");

                entity.Property(e => e.HookData)
                    .HasColumnType("text")
                    .HasColumnName("hook_data");

                entity.Property(e => e.HookFileReal)
                    .HasMaxLength(255)
                    .HasColumnName("hook_file_real");

                entity.Property(e => e.HookFileStored)
                    .HasMaxLength(255)
                    .HasColumnName("hook_file_stored");

                entity.Property(e => e.HookHookId).HasColumnName("hook_hook_id");

                entity.Property(e => e.HookType)
                    .HasMaxLength(32)
                    .HasColumnName("hook_type");

                entity.Property(e => e.HooksSource).HasColumnName("hooks_source");
            });

            modelBuilder.Entity<IpbcoreIncomingEmail>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_incoming_emails");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.RuleId).HasColumnName("rule_id");

                entity.Property(e => e.RuleAddedBy)
                    .HasColumnType("mediumint")
                    .HasColumnName("rule_added_by");

                entity.Property(e => e.RuleAddedDate).HasColumnName("rule_added_date");

                entity.Property(e => e.RuleApp)
                    .HasMaxLength(255)
                    .HasColumnName("rule_app");

                entity.Property(e => e.RuleCriteriaField)
                    .HasMaxLength(4)
                    .HasColumnName("rule_criteria_field");

                entity.Property(e => e.RuleCriteriaType)
                    .HasMaxLength(4)
                    .HasColumnName("rule_criteria_type");

                entity.Property(e => e.RuleCriteriaValue)
                    .HasColumnType("text")
                    .HasColumnName("rule_criteria_value");
            });

            modelBuilder.Entity<IpbcoreIncomingEmailLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_incoming_email_log");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.LogEmail)
                    .HasMaxLength(255)
                    .HasColumnName("log_email");

                entity.Property(e => e.LogTime).HasColumnName("log_time");
            });

            modelBuilder.Entity<IpbcoreInlineMessage>(entity =>
            {
                entity.HasKey(e => e.InlineMsgId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_inline_messages");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.InlineMsgDate, "inline_msg_date");

                entity.Property(e => e.InlineMsgId).HasColumnName("inline_msg_id");

                entity.Property(e => e.InlineMsgContent)
                    .HasColumnType("text")
                    .HasColumnName("inline_msg_content");

                entity.Property(e => e.InlineMsgDate).HasColumnName("inline_msg_date");
            });

            modelBuilder.Entity<IpbcoreItemMarker>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ipbcore_item_markers");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.ItemKey, e.ItemMemberId, e.ItemApp }, "combo_key")
                    .IsUnique();

                entity.HasIndex(e => e.ItemLastSaved, "item_last_saved");

                entity.HasIndex(e => new { e.ItemIsDeleted, e.ItemMemberId }, "item_member_id");

                entity.HasIndex(e => new { e.ItemMemberId, e.ItemApp }, "marker_index");

                entity.Property(e => e.ItemApp)
                    .HasColumnName("item_app")
                    .HasDefaultValueSql("'core'");

                entity.Property(e => e.ItemAppKey1).HasColumnName("item_app_key_1");

                entity.Property(e => e.ItemAppKey2).HasColumnName("item_app_key_2");

                entity.Property(e => e.ItemAppKey3).HasColumnName("item_app_key_3");

                entity.Property(e => e.ItemGlobalReset).HasColumnName("item_global_reset");

                entity.Property(e => e.ItemIsDeleted).HasColumnName("item_is_deleted");

                entity.Property(e => e.ItemKey)
                    .HasMaxLength(32)
                    .HasColumnName("item_key")
                    .IsFixedLength();

                entity.Property(e => e.ItemLastSaved).HasColumnName("item_last_saved");

                entity.Property(e => e.ItemLastUpdate).HasColumnName("item_last_update");

                entity.Property(e => e.ItemMemberId).HasColumnName("item_member_id");

                entity.Property(e => e.ItemReadArray)
                    .HasColumnType("mediumtext")
                    .HasColumnName("item_read_array");

                entity.Property(e => e.ItemUnreadCount).HasColumnName("item_unread_count");
            });

            modelBuilder.Entity<IpbcoreItemMarkersStorage>(entity =>
            {
                entity.HasKey(e => e.ItemMemberId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_item_markers_storage");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.ItemLastSaved, "item_last_saved");

                entity.Property(e => e.ItemMemberId)
                    .ValueGeneratedNever()
                    .HasColumnName("item_member_id");

                entity.Property(e => e.ItemLastSaved).HasColumnName("item_last_saved");

                entity.Property(e => e.ItemLastUpdated).HasColumnName("item_last_updated");

                entity.Property(e => e.ItemMarkers)
                    .HasColumnType("mediumtext")
                    .HasColumnName("item_markers");
            });

            modelBuilder.Entity<IpbcoreLike>(entity =>
            {
                entity.HasKey(e => e.LikeId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_like");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.LikeLookupId, e.LikeVisible, e.LikeIsAnon, e.LikeAdded }, "find_rel_likes");

                entity.HasIndex(e => new { e.LikeLookupArea, e.LikeVisible }, "like_lookup_area");

                entity.HasIndex(e => new { e.LikeMemberId, e.LikeVisible, e.LikeAdded }, "like_member_id");

                entity.HasIndex(e => new { e.LikeNotifyDo, e.LikeApp, e.LikeArea, e.LikeVisible, e.LikeNotifySent, e.LikeNotifyFreq }, "notification_task")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 50, 50, 0, 0, 50 });

                entity.Property(e => e.LikeId)
                    .HasMaxLength(32)
                    .HasColumnName("like_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LikeAdded).HasColumnName("like_added");

                entity.Property(e => e.LikeApp)
                    .HasMaxLength(150)
                    .HasColumnName("like_app")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LikeArea)
                    .HasMaxLength(200)
                    .HasColumnName("like_area")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LikeIsAnon).HasColumnName("like_is_anon");

                entity.Property(e => e.LikeLookupArea)
                    .HasMaxLength(32)
                    .HasColumnName("like_lookup_area")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.LikeLookupId)
                    .HasMaxLength(32)
                    .HasColumnName("like_lookup_id");

                entity.Property(e => e.LikeMemberId).HasColumnName("like_member_id");

                entity.Property(e => e.LikeNotifyDo).HasColumnName("like_notify_do");

                entity.Property(e => e.LikeNotifyFreq)
                    .HasMaxLength(200)
                    .HasColumnName("like_notify_freq")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LikeNotifyMeta)
                    .HasColumnType("text")
                    .HasColumnName("like_notify_meta");

                entity.Property(e => e.LikeNotifySent).HasColumnName("like_notify_sent");

                entity.Property(e => e.LikeRelId).HasColumnName("like_rel_id");

                entity.Property(e => e.LikeVisible)
                    .HasColumnName("like_visible")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<IpbcoreLikeCache>(entity =>
            {
                entity.HasKey(e => e.LikeCacheId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_like_cache");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.LikeCacheId)
                    .HasMaxLength(32)
                    .HasColumnName("like_cache_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LikeCacheApp)
                    .HasMaxLength(150)
                    .HasColumnName("like_cache_app")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LikeCacheArea)
                    .HasMaxLength(200)
                    .HasColumnName("like_cache_area")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LikeCacheData)
                    .HasColumnType("text")
                    .HasColumnName("like_cache_data");

                entity.Property(e => e.LikeCacheExpire).HasColumnName("like_cache_expire");

                entity.Property(e => e.LikeCacheRelId).HasColumnName("like_cache_rel_id");
            });

            modelBuilder.Entity<IpbcoreRssImported>(entity =>
            {
                entity.HasKey(e => e.RssGuid)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_rss_imported");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.RssGuid, e.RssForeignKey }, "rss_grabber");

                entity.Property(e => e.RssGuid)
                    .HasMaxLength(32)
                    .HasColumnName("rss_guid")
                    .IsFixedLength();

                entity.Property(e => e.RssForeignKey)
                    .HasMaxLength(100)
                    .HasColumnName("rss_foreign_key")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbcoreShareLink>(entity =>
            {
                entity.HasKey(e => e.ShareId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_share_links");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.ShareId).HasColumnName("share_id");

                entity.Property(e => e.ShareCanonical)
                    .HasColumnName("share_canonical")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ShareEnabled).HasColumnName("share_enabled");

                entity.Property(e => e.ShareKey)
                    .HasMaxLength(50)
                    .HasColumnName("share_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SharePosition).HasColumnName("share_position");

                entity.Property(e => e.ShareTitle)
                    .HasMaxLength(255)
                    .HasColumnName("share_title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbcoreShareLinksCache>(entity =>
            {
                entity.HasKey(e => e.CacheId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_share_links_caches");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.CacheId).HasColumnName("cache_id");

                entity.Property(e => e.CacheData)
                    .HasColumnType("mediumtext")
                    .HasColumnName("cache_data");

                entity.Property(e => e.CacheDate).HasColumnName("cache_date");

                entity.Property(e => e.CacheKey)
                    .HasMaxLength(255)
                    .HasColumnName("cache_key")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbcoreShareLinksLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_share_links_log");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.LogDataApp, e.LogDataType, e.LogDataPrimaryId }, "findstuff");

                entity.HasIndex(e => e.LogDate, "log_date");

                entity.HasIndex(e => e.LogIpAddress, "log_ip_address");

                entity.HasIndex(e => e.LogMemberId, "log_member_id");

                entity.HasIndex(e => e.LogShareKey, "log_share_key");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.LogDataApp)
                    .HasMaxLength(50)
                    .HasColumnName("log_data_app")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LogDataPrimaryId).HasColumnName("log_data_primary_id");

                entity.Property(e => e.LogDataSecondaryId).HasColumnName("log_data_secondary_id");

                entity.Property(e => e.LogDataType)
                    .HasMaxLength(50)
                    .HasColumnName("log_data_type")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LogDate).HasColumnName("log_date");

                entity.Property(e => e.LogIpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("log_ip_address");

                entity.Property(e => e.LogMemberId).HasColumnName("log_member_id");

                entity.Property(e => e.LogShareKey)
                    .HasMaxLength(50)
                    .HasColumnName("log_share_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LogTitle)
                    .HasColumnType("text")
                    .HasColumnName("log_title");

                entity.Property(e => e.LogUrl)
                    .HasColumnType("text")
                    .HasColumnName("log_url");
            });

            modelBuilder.Entity<IpbcoreSoftDeleteLog>(entity =>
            {
                entity.HasKey(e => e.SdlId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_soft_delete_log");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.SdlObjId, e.SdlObjKey }, "look_up");

                entity.Property(e => e.SdlId).HasColumnName("sdl_id");

                entity.Property(e => e.SdlLocked).HasColumnName("sdl_locked");

                entity.Property(e => e.SdlObjDate).HasColumnName("sdl_obj_date");

                entity.Property(e => e.SdlObjId).HasColumnName("sdl_obj_id");

                entity.Property(e => e.SdlObjKey)
                    .HasMaxLength(20)
                    .HasColumnName("sdl_obj_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SdlObjMemberId).HasColumnName("sdl_obj_member_id");

                entity.Property(e => e.SdlObjReason)
                    .HasColumnType("text")
                    .HasColumnName("sdl_obj_reason");
            });

            modelBuilder.Entity<IpbcoreSysConfSetting>(entity =>
            {
                entity.HasKey(e => e.ConfId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_sys_conf_settings");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.ConfAddCache, "conf_add_cache");

                entity.HasIndex(e => new { e.ConfGroup, e.ConfPosition, e.ConfTitle }, "conf_group");

                entity.HasIndex(e => e.ConfKey, "conf_key");

                entity.Property(e => e.ConfId).HasColumnName("conf_id");

                entity.Property(e => e.ConfAddCache)
                    .IsRequired()
                    .HasColumnName("conf_add_cache")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ConfDefault)
                    .HasColumnType("text")
                    .HasColumnName("conf_default");

                entity.Property(e => e.ConfDescription)
                    .HasColumnType("text")
                    .HasColumnName("conf_description");

                entity.Property(e => e.ConfEvalphp)
                    .HasColumnType("text")
                    .HasColumnName("conf_evalphp");

                entity.Property(e => e.ConfExtra)
                    .HasColumnType("text")
                    .HasColumnName("conf_extra");

                entity.Property(e => e.ConfGroup).HasColumnName("conf_group");

                entity.Property(e => e.ConfKey)
                    .HasColumnName("conf_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConfKeywords)
                    .HasColumnType("text")
                    .HasColumnName("conf_keywords");

                entity.Property(e => e.ConfPosition).HasColumnName("conf_position");

                entity.Property(e => e.ConfProtected).HasColumnName("conf_protected");

                entity.Property(e => e.ConfStartGroup)
                    .HasMaxLength(255)
                    .HasColumnName("conf_start_group")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConfTitle)
                    .HasColumnName("conf_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConfType)
                    .HasMaxLength(255)
                    .HasColumnName("conf_type")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConfValue)
                    .HasColumnType("text")
                    .HasColumnName("conf_value");
            });

            modelBuilder.Entity<IpbcoreSysCpSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_sys_cp_sessions");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.SessionMemberId, "session_member_id");

                entity.HasIndex(e => e.SessionRunningTime, "session_running_time");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(32)
                    .HasColumnName("session_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SessionAppData)
                    .HasColumnType("text")
                    .HasColumnName("session_app_data");

                entity.Property(e => e.SessionIpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("session_ip_address");

                entity.Property(e => e.SessionLocation)
                    .HasMaxLength(64)
                    .HasColumnName("session_location")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SessionLogInTime).HasColumnName("session_log_in_time");

                entity.Property(e => e.SessionMemberId)
                    .HasColumnType("mediumint")
                    .HasColumnName("session_member_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SessionMemberLoginKey)
                    .HasMaxLength(32)
                    .HasColumnName("session_member_login_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SessionMemberName)
                    .HasMaxLength(250)
                    .HasColumnName("session_member_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SessionRunningTime).HasColumnName("session_running_time");

                entity.Property(e => e.SessionUrl)
                    .HasColumnType("text")
                    .HasColumnName("session_url");
            });

            modelBuilder.Entity<IpbcoreSysLang>(entity =>
            {
                entity.HasKey(e => e.LangId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_sys_lang");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.LangDefault, "lang_default");

                entity.HasIndex(e => e.LangShort, "lang_short");

                entity.Property(e => e.LangId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("lang_id");

                entity.Property(e => e.LangDefault).HasColumnName("lang_default");

                entity.Property(e => e.LangIsrtl).HasColumnName("lang_isrtl");

                entity.Property(e => e.LangProtected).HasColumnName("lang_protected");

                entity.Property(e => e.LangShort)
                    .HasMaxLength(32)
                    .HasColumnName("lang_short");

                entity.Property(e => e.LangTitle)
                    .HasMaxLength(255)
                    .HasColumnName("lang_title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbcoreSysLangWord>(entity =>
            {
                entity.HasKey(e => e.WordId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_sys_lang_words");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.LangId, e.WordApp, e.WordPack }, "word_find")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 32, 100 });

                entity.HasIndex(e => e.WordJs, "word_js");

                entity.Property(e => e.WordId).HasColumnName("word_id");

                entity.Property(e => e.LangId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("lang_id");

                entity.Property(e => e.WordApp).HasColumnName("word_app");

                entity.Property(e => e.WordCustom)
                    .HasColumnType("text")
                    .HasColumnName("word_custom");

                entity.Property(e => e.WordCustomVersion)
                    .HasMaxLength(10)
                    .HasColumnName("word_custom_version");

                entity.Property(e => e.WordDefault)
                    .HasColumnType("text")
                    .HasColumnName("word_default");

                entity.Property(e => e.WordDefaultVersion)
                    .HasMaxLength(10)
                    .HasColumnName("word_default_version")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.WordJs).HasColumnName("word_js");

                entity.Property(e => e.WordKey)
                    .HasMaxLength(64)
                    .HasColumnName("word_key");

                entity.Property(e => e.WordPack).HasColumnName("word_pack");
            });

            modelBuilder.Entity<IpbcoreSysLogin>(entity =>
            {
                entity.HasKey(e => e.SysLoginId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_sys_login");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.SysLoginId)
                    .ValueGeneratedNever()
                    .HasColumnName("sys_login_id");

                entity.Property(e => e.SysCookie)
                    .HasColumnType("mediumtext")
                    .HasColumnName("sys_cookie");
            });

            modelBuilder.Entity<IpbcoreSysModule>(entity =>
            {
                entity.HasKey(e => e.SysModuleId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_sys_module");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.SysModuleApplication, "sys_module_application");

                entity.HasIndex(e => e.SysModuleKey, "sys_module_key");

                entity.HasIndex(e => e.SysModuleParent, "sys_module_parent");

                entity.HasIndex(e => e.SysModuleVisible, "sys_module_visible");

                entity.Property(e => e.SysModuleId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("sys_module_id");

                entity.Property(e => e.SysModuleAdmin).HasColumnName("sys_module_admin");

                entity.Property(e => e.SysModuleApplication)
                    .HasMaxLength(32)
                    .HasColumnName("sys_module_application")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SysModuleDescription)
                    .HasMaxLength(100)
                    .HasColumnName("sys_module_description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SysModuleHooks)
                    .HasMaxLength(255)
                    .HasColumnName("sys_module_hooks")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SysModuleKey)
                    .HasMaxLength(32)
                    .HasColumnName("sys_module_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SysModuleParent)
                    .HasMaxLength(32)
                    .HasColumnName("sys_module_parent")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SysModulePosition).HasColumnName("sys_module_position");

                entity.Property(e => e.SysModuleProtected).HasColumnName("sys_module_protected");

                entity.Property(e => e.SysModuleTables)
                    .HasMaxLength(255)
                    .HasColumnName("sys_module_tables")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SysModuleTitle)
                    .HasMaxLength(32)
                    .HasColumnName("sys_module_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SysModuleVersion)
                    .HasMaxLength(32)
                    .HasColumnName("sys_module_version")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SysModuleVisible)
                    .HasColumnName("sys_module_visible")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<IpbcoreSysSettingsTitle>(entity =>
            {
                entity.HasKey(e => e.ConfTitleId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_sys_settings_titles");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.ConfTitleKeyword, "conf_title_keyword");

                entity.Property(e => e.ConfTitleId).HasColumnName("conf_title_id");

                entity.Property(e => e.ConfTitleApp)
                    .HasMaxLength(200)
                    .HasColumnName("conf_title_app")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConfTitleCount).HasColumnName("conf_title_count");

                entity.Property(e => e.ConfTitleDesc)
                    .HasColumnType("text")
                    .HasColumnName("conf_title_desc");

                entity.Property(e => e.ConfTitleKeyword)
                    .HasMaxLength(200)
                    .HasColumnName("conf_title_keyword")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConfTitleNoshow).HasColumnName("conf_title_noshow");

                entity.Property(e => e.ConfTitleTab)
                    .HasMaxLength(32)
                    .HasColumnName("conf_title_tab");

                entity.Property(e => e.ConfTitleTitle)
                    .HasMaxLength(255)
                    .HasColumnName("conf_title_title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbcoreTag>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_tags");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.TagAaiLookup, "tag_aai_lookup");

                entity.HasIndex(e => new { e.TagAapLookup, e.TagText }, "tag_aap_lookup")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 200 });

                entity.HasIndex(e => e.TagAdded, "tag_added");

                entity.HasIndex(e => new { e.TagMetaApp, e.TagMetaArea }, "tag_app")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100, 100 });

                entity.HasIndex(e => e.TagMemberId, "tag_member_id");

                entity.Property(e => e.TagId).HasColumnName("tag_id");

                entity.Property(e => e.TagAaiLookup)
                    .HasMaxLength(32)
                    .HasColumnName("tag_aai_lookup")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.TagAapLookup)
                    .HasMaxLength(32)
                    .HasColumnName("tag_aap_lookup")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.TagAdded).HasColumnName("tag_added");

                entity.Property(e => e.TagMemberId).HasColumnName("tag_member_id");

                entity.Property(e => e.TagMetaApp)
                    .HasMaxLength(200)
                    .HasColumnName("tag_meta_app")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TagMetaArea)
                    .HasMaxLength(200)
                    .HasColumnName("tag_meta_area")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TagMetaId).HasColumnName("tag_meta_id");

                entity.Property(e => e.TagMetaParentId).HasColumnName("tag_meta_parent_id");

                entity.Property(e => e.TagPrefix).HasColumnName("tag_prefix");

                entity.Property(e => e.TagText).HasColumnName("tag_text");
            });

            modelBuilder.Entity<IpbcoreTagsCache>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ipbcore_tags_cache");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.TagCacheKey, "tag_cache_key")
                    .IsUnique();

                entity.Property(e => e.TagCacheDate).HasColumnName("tag_cache_date");

                entity.Property(e => e.TagCacheKey)
                    .HasMaxLength(32)
                    .HasColumnName("tag_cache_key")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.TagCacheText)
                    .HasColumnType("text")
                    .HasColumnName("tag_cache_text");
            });

            modelBuilder.Entity<IpbcoreTagsPerm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ipbcore_tags_perms");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.TagPermText, e.TagPermVisible }, "tag_lookup");

                entity.HasIndex(e => e.TagPermAaiLookup, "tag_perm_aai_lookup")
                    .IsUnique();

                entity.HasIndex(e => e.TagPermAapLookup, "tag_perm_aap_lookup");

                entity.Property(e => e.TagPermAaiLookup)
                    .HasMaxLength(32)
                    .HasColumnName("tag_perm_aai_lookup")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.TagPermAapLookup)
                    .HasMaxLength(32)
                    .HasColumnName("tag_perm_aap_lookup")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.TagPermText)
                    .HasColumnName("tag_perm_text")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TagPermVisible)
                    .HasColumnName("tag_perm_visible")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<IpbcoreUagent>(entity =>
            {
                entity.HasKey(e => e.UagentId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_uagents");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.UagentPosition, e.UagentKey }, "ordering");

                entity.HasIndex(e => e.UagentKey, "uagent_key");

                entity.Property(e => e.UagentId).HasColumnName("uagent_id");

                entity.Property(e => e.UagentKey)
                    .HasMaxLength(200)
                    .HasColumnName("uagent_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UagentName)
                    .HasMaxLength(200)
                    .HasColumnName("uagent_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UagentPosition).HasColumnName("uagent_position");

                entity.Property(e => e.UagentRegex)
                    .HasColumnType("text")
                    .HasColumnName("uagent_regex");

                entity.Property(e => e.UagentRegexCapture).HasColumnName("uagent_regex_capture");

                entity.Property(e => e.UagentType)
                    .HasMaxLength(200)
                    .HasColumnName("uagent_type")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbcoreUagentGroup>(entity =>
            {
                entity.HasKey(e => e.UgroupId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcore_uagent_groups");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.UgroupTitle, "ugroup_title");

                entity.Property(e => e.UgroupId).HasColumnName("ugroup_id");

                entity.Property(e => e.UgroupArray)
                    .HasColumnType("mediumtext")
                    .HasColumnName("ugroup_array");

                entity.Property(e => e.UgroupTitle)
                    .HasColumnName("ugroup_title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbcustomBbcode>(entity =>
            {
                entity.HasKey(e => e.BbcodeId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbcustom_bbcode");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.BbcodeId).HasColumnName("bbcode_id");

                entity.Property(e => e.BbcodeAliases)
                    .HasMaxLength(255)
                    .HasColumnName("bbcode_aliases");

                entity.Property(e => e.BbcodeApp)
                    .HasMaxLength(50)
                    .HasColumnName("bbcode_app")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BbcodeCustomRegex)
                    .HasColumnType("text")
                    .HasColumnName("bbcode_custom_regex");

                entity.Property(e => e.BbcodeDesc)
                    .HasColumnType("text")
                    .HasColumnName("bbcode_desc");

                entity.Property(e => e.BbcodeExample)
                    .HasColumnType("text")
                    .HasColumnName("bbcode_example");

                entity.Property(e => e.BbcodeGroups)
                    .HasMaxLength(255)
                    .HasColumnName("bbcode_groups");

                entity.Property(e => e.BbcodeImage)
                    .HasMaxLength(255)
                    .HasColumnName("bbcode_image");

                entity.Property(e => e.BbcodeMenuContentText)
                    .HasMaxLength(200)
                    .HasColumnName("bbcode_menu_content_text")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BbcodeMenuOptionText)
                    .HasMaxLength(200)
                    .HasColumnName("bbcode_menu_option_text")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BbcodeNoParsing).HasColumnName("bbcode_no_parsing");

                entity.Property(e => e.BbcodeOptionalOption).HasColumnName("bbcode_optional_option");

                entity.Property(e => e.BbcodePhpPlugin)
                    .HasMaxLength(255)
                    .HasColumnName("bbcode_php_plugin");

                entity.Property(e => e.BbcodeProtected).HasColumnName("bbcode_protected");

                entity.Property(e => e.BbcodeReplace)
                    .HasColumnType("text")
                    .HasColumnName("bbcode_replace");

                entity.Property(e => e.BbcodeSections)
                    .HasMaxLength(255)
                    .HasColumnName("bbcode_sections");

                entity.Property(e => e.BbcodeSingleTag).HasColumnName("bbcode_single_tag");

                entity.Property(e => e.BbcodeSwitchOption).HasColumnName("bbcode_switch_option");

                entity.Property(e => e.BbcodeTag)
                    .HasMaxLength(255)
                    .HasColumnName("bbcode_tag")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BbcodeTitle)
                    .HasMaxLength(255)
                    .HasColumnName("bbcode_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BbcodeUseoption).HasColumnName("bbcode_useoption");
            });

            modelBuilder.Entity<IpbdnamesChange>(entity =>
            {
                entity.HasKey(e => e.DnameId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbdnames_change");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.DnameMemberId, e.DnameDate }, "date_id");

                entity.HasIndex(e => e.DnameIpAddress, "dname_ip_address");

                entity.HasIndex(e => e.DnameMemberId, "dname_member_id");

                entity.Property(e => e.DnameId).HasColumnName("dname_id");

                entity.Property(e => e.DnameCurrent)
                    .HasMaxLength(255)
                    .HasColumnName("dname_current")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DnameDate).HasColumnName("dname_date");

                entity.Property(e => e.DnameIpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("dname_ip_address");

                entity.Property(e => e.DnameMemberId).HasColumnName("dname_member_id");

                entity.Property(e => e.DnamePrevious)
                    .HasMaxLength(255)
                    .HasColumnName("dname_previous")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Ipbemoticon>(entity =>
            {
                entity.ToTable("ipbemoticons");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.EmoSet, "emo_set");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Clickable)
                    .HasColumnName("clickable")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EmoPosition).HasColumnName("emo_position");

                entity.Property(e => e.EmoSet)
                    .HasMaxLength(64)
                    .HasColumnName("emo_set")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.Image)
                    .HasMaxLength(128)
                    .HasColumnName("image")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Typed)
                    .HasMaxLength(32)
                    .HasColumnName("typed")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpberrorLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("ipberror_logs");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.LogDate, "log_date");

                entity.HasIndex(e => e.LogIpAddress, "log_ip_address");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.LogDate).HasColumnName("log_date");

                entity.Property(e => e.LogError)
                    .HasColumnType("text")
                    .HasColumnName("log_error");

                entity.Property(e => e.LogErrorCode)
                    .HasMaxLength(24)
                    .HasColumnName("log_error_code")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LogIpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("log_ip_address");

                entity.Property(e => e.LogMember).HasColumnName("log_member");

                entity.Property(e => e.LogRequestUri)
                    .HasColumnType("text")
                    .HasColumnName("log_request_uri");
            });

            modelBuilder.Entity<Ipbfaq>(entity =>
            {
                entity.ToTable("ipbfaq");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint")
                    .HasColumnName("id");

                entity.Property(e => e.App)
                    .HasMaxLength(32)
                    .HasColumnName("app")
                    .HasDefaultValueSql("'core'");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.Title)
                    .HasMaxLength(128)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Ipbforum>(entity =>
            {
                entity.ToTable("ipbforums");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Position, e.ParentId }, "position");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowPoll)
                    .IsRequired()
                    .HasColumnName("allow_poll")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AllowPollbump).HasColumnName("allow_pollbump");

                entity.Property(e => e.CanViewOthers)
                    .IsRequired()
                    .HasColumnName("can_view_others")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ConvParent)
                    .HasMaxLength(5)
                    .HasColumnName("conv_parent");

                entity.Property(e => e.DeletedPosts).HasColumnName("deleted_posts");

                entity.Property(e => e.DeletedTopics).HasColumnName("deleted_topics");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.DisableSharelinks).HasColumnName("disable_sharelinks");

                entity.Property(e => e.ForumAllowRating).HasColumnName("forum_allow_rating");

                entity.Property(e => e.ForumLastDeletion).HasColumnName("forum_last_deletion");

                entity.Property(e => e.ForumsBitoptions).HasColumnName("forums_bitoptions");

                entity.Property(e => e.HideLastInfo).HasColumnName("hide_last_info");

                entity.Property(e => e.IncPostcount)
                    .IsRequired()
                    .HasColumnName("inc_postcount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LastId).HasColumnName("last_id");

                entity.Property(e => e.LastPost).HasColumnName("last_post");

                entity.Property(e => e.LastPosterId)
                    .HasColumnType("mediumint")
                    .HasColumnName("last_poster_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LastPosterName)
                    .HasMaxLength(255)
                    .HasColumnName("last_poster_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastTitle)
                    .HasMaxLength(250)
                    .HasColumnName("last_title");

                entity.Property(e => e.LastXTopicIds)
                    .HasColumnType("text")
                    .HasColumnName("last_x_topic_ids");

                entity.Property(e => e.MinPostsPost).HasColumnName("min_posts_post");

                entity.Property(e => e.MinPostsView).HasColumnName("min_posts_view");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameSeo)
                    .HasMaxLength(255)
                    .HasColumnName("name_seo");

                entity.Property(e => e.NewestId).HasColumnName("newest_id");

                entity.Property(e => e.NewestTitle)
                    .HasMaxLength(250)
                    .HasColumnName("newest_title");

                entity.Property(e => e.NotifyModqEmails)
                    .HasColumnType("text")
                    .HasColumnName("notify_modq_emails");

                entity.Property(e => e.ParentId)
                    .HasColumnType("mediumint")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Password)
                    .HasMaxLength(32)
                    .HasColumnName("password");

                entity.Property(e => e.PasswordOverride)
                    .HasMaxLength(255)
                    .HasColumnName("password_override");

                entity.Property(e => e.PermissionCustomError)
                    .HasColumnType("text")
                    .HasColumnName("permission_custom_error");

                entity.Property(e => e.PermissionShowtopic).HasColumnName("permission_showtopic");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Posts)
                    .HasColumnType("mediumint")
                    .HasColumnName("posts");

                entity.Property(e => e.PreviewPosts).HasColumnName("preview_posts");

                entity.Property(e => e.Prune).HasColumnName("prune");

                entity.Property(e => e.QueuedPosts)
                    .HasColumnType("mediumint")
                    .HasColumnName("queued_posts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QueuedTopics)
                    .HasColumnType("mediumint")
                    .HasColumnName("queued_topics")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RedirectHits).HasColumnName("redirect_hits");

                entity.Property(e => e.RedirectOn).HasColumnName("redirect_on");

                entity.Property(e => e.RedirectUrl)
                    .HasMaxLength(250)
                    .HasColumnName("redirect_url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RulesRawHtml).HasColumnName("rules_raw_html");

                entity.Property(e => e.RulesText)
                    .HasColumnType("text")
                    .HasColumnName("rules_text");

                entity.Property(e => e.RulesTitle)
                    .HasMaxLength(255)
                    .HasColumnName("rules_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SeoLastName)
                    .HasMaxLength(255)
                    .HasColumnName("seo_last_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SeoLastTitle)
                    .HasMaxLength(255)
                    .HasColumnName("seo_last_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ShowRules).HasColumnName("show_rules");

                entity.Property(e => e.SkinId).HasColumnName("skin_id");

                entity.Property(e => e.SortKey)
                    .HasMaxLength(32)
                    .HasColumnName("sort_key");

                entity.Property(e => e.SortOrder)
                    .HasMaxLength(32)
                    .HasColumnName("sort_order");

                entity.Property(e => e.SubCanPost)
                    .HasColumnName("sub_can_post")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TagPredefined)
                    .HasColumnType("text")
                    .HasColumnName("tag_predefined");

                entity.Property(e => e.Topicfilter)
                    .HasMaxLength(32)
                    .HasColumnName("topicfilter")
                    .HasDefaultValueSql("'all'");

                entity.Property(e => e.Topics)
                    .HasColumnType("mediumint")
                    .HasColumnName("topics");

                entity.Property(e => e.UseHtml).HasColumnName("use_html");

                entity.Property(e => e.UseIbc).HasColumnName("use_ibc");
            });

            modelBuilder.Entity<IpbforumPerm>(entity =>
            {
                entity.HasKey(e => e.PermId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbforum_perms");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.PermId).HasColumnName("perm_id");

                entity.Property(e => e.PermName)
                    .HasMaxLength(250)
                    .HasColumnName("perm_name")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Ipbgroup>(entity =>
            {
                entity.HasKey(e => e.GId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbgroups");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.GId).HasColumnName("g_id");

                entity.Property(e => e.GAccessCp).HasColumnName("g_access_cp");

                entity.Property(e => e.GAccessOffline).HasColumnName("g_access_offline");

                entity.Property(e => e.GAppendEdit).HasColumnName("g_append_edit");

                entity.Property(e => e.GAttachMax).HasColumnName("g_attach_max");

                entity.Property(e => e.GAttachPerPost).HasColumnName("g_attach_per_post");

                entity.Property(e => e.GAvoidFlood).HasColumnName("g_avoid_flood");

                entity.Property(e => e.GAvoidQ).HasColumnName("g_avoid_q");

                entity.Property(e => e.GBitoptions).HasColumnName("g_bitoptions");

                entity.Property(e => e.GBypassBadwords).HasColumnName("g_bypass_badwords");

                entity.Property(e => e.GCanAddFriends)
                    .IsRequired()
                    .HasColumnName("g_can_add_friends")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.GCanMsgAttach).HasColumnName("g_can_msg_attach");

                entity.Property(e => e.GDeleteOwnPosts).HasColumnName("g_delete_own_posts");

                entity.Property(e => e.GDeleteOwnTopics).HasColumnName("g_delete_own_topics");

                entity.Property(e => e.GDisplaynameUnit).HasColumnName("g_displayname_unit");

                entity.Property(e => e.GDnameChanges).HasColumnName("g_dname_changes");

                entity.Property(e => e.GDnameDate).HasColumnName("g_dname_date");

                entity.Property(e => e.GDohtml).HasColumnName("g_dohtml");

                entity.Property(e => e.GEditCutoff)
                    .HasColumnName("g_edit_cutoff")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GEditPosts).HasColumnName("g_edit_posts");

                entity.Property(e => e.GEditProfile).HasColumnName("g_edit_profile");

                entity.Property(e => e.GEditTopic).HasColumnName("g_edit_topic");

                entity.Property(e => e.GHideFromList)
                    .HasColumnName("g_hide_from_list")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GHideOnlineList).HasColumnName("g_hide_online_list");

                entity.Property(e => e.GIcon)
                    .HasColumnType("text")
                    .HasColumnName("g_icon");

                entity.Property(e => e.GIsSupmod).HasColumnName("g_is_supmod");

                entity.Property(e => e.GMaxBgimgUpload).HasColumnName("g_max_bgimg_upload");

                entity.Property(e => e.GMaxMassPm)
                    .HasColumnName("g_max_mass_pm")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GMaxMessages)
                    .HasColumnName("g_max_messages")
                    .HasDefaultValueSql("'50'");

                entity.Property(e => e.GMaxNotifications)
                    .HasColumnType("mediumint")
                    .HasColumnName("g_max_notifications")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GMemInfo).HasColumnName("g_mem_info");

                entity.Property(e => e.GModPostUnit).HasColumnName("g_mod_post_unit");

                entity.Property(e => e.GModPreview).HasColumnName("g_mod_preview");

                entity.Property(e => e.GOpenClosePosts).HasColumnName("g_open_close_posts");

                entity.Property(e => e.GOtherTopics).HasColumnName("g_other_topics");

                entity.Property(e => e.GPermId)
                    .HasMaxLength(255)
                    .HasColumnName("g_perm_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GPhotoMaxVars)
                    .HasMaxLength(200)
                    .HasColumnName("g_photo_max_vars")
                    .HasDefaultValueSql("'100:150:150'");

                entity.Property(e => e.GPmFloodMins).HasColumnName("g_pm_flood_mins");

                entity.Property(e => e.GPmPerday).HasColumnName("g_pm_perday");

                entity.Property(e => e.GPostClosed)
                    .HasColumnName("g_post_closed")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GPostNewTopics).HasColumnName("g_post_new_topics");

                entity.Property(e => e.GPostPolls).HasColumnName("g_post_polls");

                entity.Property(e => e.GPpdLimit).HasColumnName("g_ppd_limit");

                entity.Property(e => e.GPpdUnit).HasColumnName("g_ppd_unit");

                entity.Property(e => e.GPromotion)
                    .HasMaxLength(10)
                    .HasColumnName("g_promotion")
                    .HasDefaultValueSql("'-1&-1'");

                entity.Property(e => e.GRepMaxNegative)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("g_rep_max_negative")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GRepMaxPositive)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("g_rep_max_positive")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GReplyOtherTopics).HasColumnName("g_reply_other_topics");

                entity.Property(e => e.GReplyOwnTopics).HasColumnName("g_reply_own_topics");

                entity.Property(e => e.GSearchFlood)
                    .HasColumnType("mediumint")
                    .HasColumnName("g_search_flood")
                    .HasDefaultValueSql("'20'");

                entity.Property(e => e.GSigUnit).HasColumnName("g_sig_unit");

                entity.Property(e => e.GSignatureLimits)
                    .HasMaxLength(255)
                    .HasColumnName("g_signature_limits");

                entity.Property(e => e.GTitle)
                    .HasMaxLength(32)
                    .HasColumnName("g_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GTopicRateSetting).HasColumnName("g_topic_rate_setting");

                entity.Property(e => e.GUsePm)
                    .HasColumnName("g_use_pm")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GUseSearch).HasColumnName("g_use_search");

                entity.Property(e => e.GViewBoard).HasColumnName("g_view_board");

                entity.Property(e => e.GVotePolls).HasColumnName("g_vote_polls");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(250)
                    .HasColumnName("prefix");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(250)
                    .HasColumnName("suffix");
            });

            modelBuilder.Entity<IpbignoredUser>(entity =>
            {
                entity.HasKey(e => e.IgnoreId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbignored_users");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.IgnoreIgnoreId, "ignore_ignore_id");

                entity.HasIndex(e => e.IgnoreOwnerId, "ignore_owner_id");

                entity.Property(e => e.IgnoreId).HasColumnName("ignore_id");

                entity.Property(e => e.IgnoreChats).HasColumnName("ignore_chats");

                entity.Property(e => e.IgnoreIgnoreId).HasColumnName("ignore_ignore_id");

                entity.Property(e => e.IgnoreMessages).HasColumnName("ignore_messages");

                entity.Property(e => e.IgnoreOwnerId).HasColumnName("ignore_owner_id");

                entity.Property(e => e.IgnoreSignatures).HasColumnName("ignore_signatures");

                entity.Property(e => e.IgnoreTopics).HasColumnName("ignore_topics");
            });

            modelBuilder.Entity<IpbinlineNotification>(entity =>
            {
                entity.HasKey(e => e.NotifyId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbinline_notifications");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.NotifyToId, e.NotifyRead, e.NotifySent }, "grabber");

                entity.HasIndex(e => e.NotifyMetaKey, "notify_meta_key");

                entity.HasIndex(e => new { e.NotifyToId, e.NotifySent }, "notify_to_id");

                entity.Property(e => e.NotifyId).HasColumnName("notify_id");

                entity.Property(e => e.NotifyFromId).HasColumnName("notify_from_id");

                entity.Property(e => e.NotifyMetaApp)
                    .HasMaxLength(50)
                    .HasColumnName("notify_meta_app");

                entity.Property(e => e.NotifyMetaArea)
                    .HasMaxLength(100)
                    .HasColumnName("notify_meta_area");

                entity.Property(e => e.NotifyMetaId)
                    .HasColumnName("notify_meta_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NotifyMetaKey)
                    .HasMaxLength(32)
                    .HasColumnName("notify_meta_key");

                entity.Property(e => e.NotifyRead).HasColumnName("notify_read");

                entity.Property(e => e.NotifySent).HasColumnName("notify_sent");

                entity.Property(e => e.NotifyText)
                    .HasColumnType("text")
                    .HasColumnName("notify_text");

                entity.Property(e => e.NotifyTitle)
                    .HasColumnType("text")
                    .HasColumnName("notify_title");

                entity.Property(e => e.NotifyToId).HasColumnName("notify_to_id");

                entity.Property(e => e.NotifyTypeKey)
                    .HasMaxLength(255)
                    .HasColumnName("notify_type_key");

                entity.Property(e => e.NotifyUrl)
                    .HasColumnType("text")
                    .HasColumnName("notify_url");
            });

            modelBuilder.Entity<IpbloginMethod>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("PRIMARY");

                entity.ToTable("ipblogin_methods");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.LoginId).HasColumnName("login_id");

                entity.Property(e => e.LoginAltAcpHtml)
                    .HasColumnType("text")
                    .HasColumnName("login_alt_acp_html");

                entity.Property(e => e.LoginAltLoginHtml)
                    .HasColumnType("text")
                    .HasColumnName("login_alt_login_html");

                entity.Property(e => e.LoginCustomConfig)
                    .HasColumnType("text")
                    .HasColumnName("login_custom_config");

                entity.Property(e => e.LoginDescription)
                    .HasMaxLength(255)
                    .HasColumnName("login_description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LoginEnabled).HasColumnName("login_enabled");

                entity.Property(e => e.LoginFolderName)
                    .HasMaxLength(255)
                    .HasColumnName("login_folder_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LoginLoginUrl)
                    .HasMaxLength(255)
                    .HasColumnName("login_login_url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LoginLogoutUrl)
                    .HasMaxLength(255)
                    .HasColumnName("login_logout_url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LoginMaintainUrl)
                    .HasMaxLength(255)
                    .HasColumnName("login_maintain_url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LoginOrder).HasColumnName("login_order");

                entity.Property(e => e.LoginRegisterUrl)
                    .HasMaxLength(255)
                    .HasColumnName("login_register_url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LoginReplaceForm).HasColumnName("login_replace_form");

                entity.Property(e => e.LoginSafemode).HasColumnName("login_safemode");

                entity.Property(e => e.LoginSettings).HasColumnName("login_settings");

                entity.Property(e => e.LoginTitle)
                    .HasMaxLength(255)
                    .HasColumnName("login_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LoginUserId)
                    .HasMaxLength(255)
                    .HasColumnName("login_user_id")
                    .HasDefaultValueSql("'username'");
            });

            modelBuilder.Entity<IpbmailErrorLog>(entity =>
            {
                entity.HasKey(e => e.MlogId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbmail_error_logs");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.MlogId).HasColumnName("mlog_id");

                entity.Property(e => e.MlogCode)
                    .HasMaxLength(200)
                    .HasColumnName("mlog_code")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MlogContent)
                    .HasMaxLength(250)
                    .HasColumnName("mlog_content")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MlogDate).HasColumnName("mlog_date");

                entity.Property(e => e.MlogFrom)
                    .HasMaxLength(250)
                    .HasColumnName("mlog_from")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MlogMsg)
                    .HasColumnType("text")
                    .HasColumnName("mlog_msg");

                entity.Property(e => e.MlogSmtpMsg)
                    .HasColumnType("text")
                    .HasColumnName("mlog_smtp_msg");

                entity.Property(e => e.MlogSubject)
                    .HasMaxLength(250)
                    .HasColumnName("mlog_subject")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MlogTo)
                    .HasMaxLength(250)
                    .HasColumnName("mlog_to")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbmailQueue>(entity =>
            {
                entity.HasKey(e => e.MailId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbmail_queue");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.MailId).HasColumnName("mail_id");

                entity.Property(e => e.MailCc)
                    .HasColumnType("text")
                    .HasColumnName("mail_cc");

                entity.Property(e => e.MailContent)
                    .HasColumnType("text")
                    .HasColumnName("mail_content");

                entity.Property(e => e.MailDate).HasColumnName("mail_date");

                entity.Property(e => e.MailFrom)
                    .HasMaxLength(255)
                    .HasColumnName("mail_from")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MailHtmlOn).HasColumnName("mail_html_on");

                entity.Property(e => e.MailSubject)
                    .HasColumnType("text")
                    .HasColumnName("mail_subject");

                entity.Property(e => e.MailTo)
                    .HasMaxLength(255)
                    .HasColumnName("mail_to")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Ipbmember>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbmembers");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.BdayDay, "bday_day");

                entity.HasIndex(e => e.BdayMonth, "bday_month");

                entity.HasIndex(e => e.Email, "email");

                entity.HasIndex(e => e.FailedLoginCount, "failed_login_count");

                entity.HasIndex(e => e.FbUid, "fb_uid");

                entity.HasIndex(e => e.IpAddress, "ip_address");

                entity.HasIndex(e => e.Joined, "joined");

                entity.HasIndex(e => e.MemberBanned, "member_banned");

                entity.HasIndex(e => e.MembersBitoptions, "members_bitoptions");

                entity.HasIndex(e => e.MembersLDisplayName, "members_l_display_name");

                entity.HasIndex(e => e.MembersLUsername, "members_l_username");

                entity.HasIndex(e => new { e.MemberGroupId, e.MemberId }, "mgroup");

                entity.HasIndex(e => e.TwitterId, "twitter_id");

                entity.Property(e => e.MemberId)
                    .HasColumnType("mediumint")
                    .HasColumnName("member_id");

                entity.Property(e => e.AllowAdminMails).HasColumnName("allow_admin_mails");

                entity.Property(e => e.AutoTrack)
                    .HasMaxLength(50)
                    .HasColumnName("auto_track")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BdayDay).HasColumnName("bday_day");

                entity.Property(e => e.BdayMonth).HasColumnName("bday_month");

                entity.Property(e => e.BdayYear).HasColumnName("bday_year");

                entity.Property(e => e.ConvPassword)
                    .HasMaxLength(128)
                    .HasColumnName("conv_password");

                entity.Property(e => e.CoppaUser)
                    .HasColumnName("coppa_user")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DstInUse)
                    .HasColumnName("dst_in_use")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("email")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FailedLoginCount).HasColumnName("failed_login_count");

                entity.Property(e => e.FailedLogins)
                    .HasColumnType("text")
                    .HasColumnName("failed_logins");

                entity.Property(e => e.FbEmailhash)
                    .HasMaxLength(60)
                    .HasColumnName("fb_emailhash")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FbLastsync).HasColumnName("fb_lastsync");

                entity.Property(e => e.FbSession)
                    .HasMaxLength(200)
                    .HasColumnName("fb_session")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FbToken)
                    .HasColumnType("text")
                    .HasColumnName("fb_token");

                entity.Property(e => e.FbUid).HasColumnName("fb_uid");

                entity.Property(e => e.HasBlog)
                    .HasColumnType("text")
                    .HasColumnName("has_blog");

                entity.Property(e => e.HasGallery).HasColumnName("has_gallery");

                entity.Property(e => e.IdentityUrl)
                    .HasColumnType("text")
                    .HasColumnName("identity_url");

                entity.Property(e => e.IgnoredUsers)
                    .HasColumnType("text")
                    .HasColumnName("ignored_users");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("ip_address");

                entity.Property(e => e.IpsMobileToken)
                    .HasMaxLength(64)
                    .HasColumnName("ips_mobile_token");

                entity.Property(e => e.Joined).HasColumnName("joined");

                entity.Property(e => e.Language)
                    .HasColumnType("mediumint")
                    .HasColumnName("language");

                entity.Property(e => e.LastActivity)
                    .HasColumnName("last_activity")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LastPost).HasColumnName("last_post");

                entity.Property(e => e.LastVisit)
                    .HasColumnName("last_visit")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LiveId)
                    .HasMaxLength(32)
                    .HasColumnName("live_id");

                entity.Property(e => e.LoginAnonymous)
                    .HasMaxLength(3)
                    .HasColumnName("login_anonymous")
                    .HasDefaultValueSql("'0&0'")
                    .IsFixedLength();

                entity.Property(e => e.MemberBanned).HasColumnName("member_banned");

                entity.Property(e => e.MemberGroupId).HasColumnName("member_group_id");

                entity.Property(e => e.MemberLoginKey)
                    .HasMaxLength(32)
                    .HasColumnName("member_login_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MemberLoginKeyExpire).HasColumnName("member_login_key_expire");

                entity.Property(e => e.MemberUploader)
                    .HasMaxLength(32)
                    .HasColumnName("member_uploader")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.MembersAutoDst)
                    .IsRequired()
                    .HasColumnName("members_auto_dst")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MembersBitoptions).HasColumnName("members_bitoptions");

                entity.Property(e => e.MembersCache)
                    .HasColumnType("mediumtext")
                    .HasColumnName("members_cache");

                entity.Property(e => e.MembersCreatedRemote).HasColumnName("members_created_remote");

                entity.Property(e => e.MembersDayPosts)
                    .HasMaxLength(32)
                    .HasColumnName("members_day_posts")
                    .HasDefaultValueSql("'0,0'");

                entity.Property(e => e.MembersDisablePm).HasColumnName("members_disable_pm");

                entity.Property(e => e.MembersDisplayName)
                    .HasMaxLength(255)
                    .HasColumnName("members_display_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MembersEditorChoice)
                    .HasMaxLength(3)
                    .HasColumnName("members_editor_choice")
                    .HasDefaultValueSql("'std'")
                    .IsFixedLength();

                entity.Property(e => e.MembersLDisplayName)
                    .HasColumnName("members_l_display_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MembersLUsername)
                    .HasColumnName("members_l_username")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MembersPassHash)
                    .HasMaxLength(32)
                    .HasColumnName("members_pass_hash")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MembersPassSalt)
                    .HasMaxLength(5)
                    .HasColumnName("members_pass_salt")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MembersProfileViews).HasColumnName("members_profile_views");

                entity.Property(e => e.MembersSeoName)
                    .HasMaxLength(255)
                    .HasColumnName("members_seo_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MgroupOthers)
                    .HasMaxLength(255)
                    .HasColumnName("mgroup_others")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Misc)
                    .HasMaxLength(128)
                    .HasColumnName("misc");

                entity.Property(e => e.ModPosts)
                    .HasMaxLength(100)
                    .HasColumnName("mod_posts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MsgCountNew).HasColumnName("msg_count_new");

                entity.Property(e => e.MsgCountReset).HasColumnName("msg_count_reset");

                entity.Property(e => e.MsgCountTotal).HasColumnName("msg_count_total");

                entity.Property(e => e.MsgShowNotification).HasColumnName("msg_show_notification");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NotificationCnt)
                    .HasColumnType("mediumint")
                    .HasColumnName("notification_cnt")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrgPermId)
                    .HasMaxLength(255)
                    .HasColumnName("org_perm_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Posts)
                    .HasColumnType("mediumint")
                    .HasColumnName("posts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RestrictPost)
                    .HasMaxLength(100)
                    .HasColumnName("restrict_post")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Skin).HasColumnName("skin");

                entity.Property(e => e.SubEnd).HasColumnName("sub_end");

                entity.Property(e => e.SubsPkgChosen).HasColumnName("subs_pkg_chosen");

                entity.Property(e => e.TcLastsync).HasColumnName("tc_lastsync");

                entity.Property(e => e.TempBan)
                    .HasMaxLength(100)
                    .HasColumnName("temp_ban")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TimeOffset)
                    .HasMaxLength(10)
                    .HasColumnName("time_offset");

                entity.Property(e => e.Title)
                    .HasMaxLength(64)
                    .HasColumnName("title");

                entity.Property(e => e.TwitterId)
                    .HasColumnName("twitter_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TwitterSecret)
                    .HasMaxLength(255)
                    .HasColumnName("twitter_secret")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TwitterToken)
                    .HasMaxLength(255)
                    .HasColumnName("twitter_token")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ViewImg)
                    .HasColumnName("view_img")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ViewSigs)
                    .HasColumnName("view_sigs")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.WarnLastwarn).HasColumnName("warn_lastwarn");

                entity.Property(e => e.WarnLevel).HasColumnName("warn_level");
            });

            modelBuilder.Entity<IpbmemberStatusAction>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbmember_status_actions");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.ActionCustom, e.ActionDate }, "action_custom");

                entity.HasIndex(e => e.ActionDate, "action_date");

                entity.HasIndex(e => new { e.ActionMemberId, e.ActionDate }, "action_member_id");

                entity.HasIndex(e => e.ActionStatusId, "action_status_id");

                entity.Property(e => e.ActionId).HasColumnName("action_id");

                entity.Property(e => e.ActionApp)
                    .HasMaxLength(255)
                    .HasColumnName("action_app")
                    .HasDefaultValueSql("'members'");

                entity.Property(e => e.ActionCustom).HasColumnName("action_custom");

                entity.Property(e => e.ActionCustomText)
                    .HasColumnType("text")
                    .HasColumnName("action_custom_text");

                entity.Property(e => e.ActionCustomUrl)
                    .HasColumnType("text")
                    .HasColumnName("action_custom_url");

                entity.Property(e => e.ActionDate).HasColumnName("action_date");

                entity.Property(e => e.ActionKey)
                    .HasMaxLength(200)
                    .HasColumnName("action_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ActionMemberId).HasColumnName("action_member_id");

                entity.Property(e => e.ActionReplyId).HasColumnName("action_reply_id");

                entity.Property(e => e.ActionStatusId).HasColumnName("action_status_id");

                entity.Property(e => e.ActionStatusOwner).HasColumnName("action_status_owner");
            });

            modelBuilder.Entity<IpbmemberStatusReply>(entity =>
            {
                entity.HasKey(e => e.ReplyId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbmember_status_replies");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.ReplyDate, "reply_date");

                entity.HasIndex(e => e.ReplyMemberId, "reply_member_id");

                entity.HasIndex(e => new { e.ReplyStatusId, e.ReplyMemberId }, "reply_status_count");

                entity.HasIndex(e => e.ReplyStatusId, "reply_status_id");

                entity.Property(e => e.ReplyId).HasColumnName("reply_id");

                entity.Property(e => e.ReplyContent)
                    .HasColumnType("text")
                    .HasColumnName("reply_content");

                entity.Property(e => e.ReplyDate).HasColumnName("reply_date");

                entity.Property(e => e.ReplyMemberId).HasColumnName("reply_member_id");

                entity.Property(e => e.ReplyStatusId).HasColumnName("reply_status_id");
            });

            modelBuilder.Entity<IpbmemberStatusUpdate>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbmember_status_updates");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.StatusMemberId, e.StatusHash, e.StatusDate }, "s_hash");

                entity.HasIndex(e => new { e.StatusAuthorId, e.StatusMemberId, e.StatusDate }, "status_author_lookup");

                entity.HasIndex(e => e.StatusDate, "status_date");

                entity.HasIndex(e => new { e.StatusIsLatest, e.StatusDate }, "status_is_latest");

                entity.HasIndex(e => new { e.StatusMemberId, e.StatusApproved, e.StatusDate }, "status_member_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StatusApproved)
                    .HasColumnName("status_approved")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StatusAuthorId).HasColumnName("status_author_id");

                entity.Property(e => e.StatusAuthorIp)
                    .HasMaxLength(46)
                    .HasColumnName("status_author_ip")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StatusContent)
                    .HasColumnType("text")
                    .HasColumnName("status_content");

                entity.Property(e => e.StatusCreator)
                    .HasMaxLength(100)
                    .HasColumnName("status_creator")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StatusDate).HasColumnName("status_date");

                entity.Property(e => e.StatusHash)
                    .HasMaxLength(32)
                    .HasColumnName("status_hash")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StatusImported).HasColumnName("status_imported");

                entity.Property(e => e.StatusIsLatest).HasColumnName("status_is_latest");

                entity.Property(e => e.StatusIsLocked).HasColumnName("status_is_locked");

                entity.Property(e => e.StatusLastIds)
                    .HasColumnType("text")
                    .HasColumnName("status_last_ids");

                entity.Property(e => e.StatusMemberId).HasColumnName("status_member_id");

                entity.Property(e => e.StatusReplies).HasColumnName("status_replies");
            });

            modelBuilder.Entity<IpbmembersPartial>(entity =>
            {
                entity.HasKey(e => e.PartialId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbmembers_partial");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.PartialMemberId, "partial_member_id");

                entity.Property(e => e.PartialId).HasColumnName("partial_id");

                entity.Property(e => e.PartialDate).HasColumnName("partial_date");

                entity.Property(e => e.PartialEmailOk).HasColumnName("partial_email_ok");

                entity.Property(e => e.PartialMemberId).HasColumnName("partial_member_id");
            });

            modelBuilder.Entity<IpbmessagePost>(entity =>
            {
                entity.HasKey(e => e.MsgId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbmessage_posts");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.MsgDate, "msg_date");

                entity.HasIndex(e => e.MsgIpAddress, "msg_ip_address");

                entity.HasIndex(e => e.MsgPost, "msg_post")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => e.MsgTopicId, "msg_topic_id");

                entity.Property(e => e.MsgId).HasColumnName("msg_id");

                entity.Property(e => e.MsgAuthorId)
                    .HasColumnType("mediumint")
                    .HasColumnName("msg_author_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MsgDate).HasColumnName("msg_date");

                entity.Property(e => e.MsgIpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("msg_ip_address")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MsgIsFirstPost).HasColumnName("msg_is_first_post");

                entity.Property(e => e.MsgPost)
                    .HasColumnType("text")
                    .HasColumnName("msg_post");

                entity.Property(e => e.MsgPostKey)
                    .HasMaxLength(32)
                    .HasColumnName("msg_post_key")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MsgTopicId).HasColumnName("msg_topic_id");
            });

            modelBuilder.Entity<IpbmessageTopic>(entity =>
            {
                entity.HasKey(e => e.MtId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbmessage_topics");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.MtDate, "mt_date");

                entity.HasIndex(e => e.MtStarterId, "mt_starter_id");

                entity.HasIndex(e => e.MtTitle, "mt_title")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.MtId).HasColumnName("mt_id");

                entity.Property(e => e.MtDate).HasColumnName("mt_date");

                entity.Property(e => e.MtFirstMsgId).HasColumnName("mt_first_msg_id");

                entity.Property(e => e.MtHasattach).HasColumnName("mt_hasattach");

                entity.Property(e => e.MtInvitedMembers)
                    .HasColumnType("text")
                    .HasColumnName("mt_invited_members");

                entity.Property(e => e.MtIsDeleted).HasColumnName("mt_is_deleted");

                entity.Property(e => e.MtIsDraft).HasColumnName("mt_is_draft");

                entity.Property(e => e.MtIsSystem).HasColumnName("mt_is_system");

                entity.Property(e => e.MtLastMsgId).HasColumnName("mt_last_msg_id");

                entity.Property(e => e.MtLastPostTime).HasColumnName("mt_last_post_time");

                entity.Property(e => e.MtReplies).HasColumnName("mt_replies");

                entity.Property(e => e.MtStartTime).HasColumnName("mt_start_time");

                entity.Property(e => e.MtStarterId).HasColumnName("mt_starter_id");

                entity.Property(e => e.MtTitle)
                    .HasColumnName("mt_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MtToCount).HasColumnName("mt_to_count");

                entity.Property(e => e.MtToMemberId).HasColumnName("mt_to_member_id");
            });

            modelBuilder.Entity<IpbmessageTopicUserMap>(entity =>
            {
                entity.HasKey(e => e.MapId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbmessage_topic_user_map");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.MapUserId, e.MapTopicId }, "map_main")
                    .IsUnique();

                entity.HasIndex(e => e.MapTopicId, "map_topic_id");

                entity.HasIndex(e => new { e.MapUserId, e.MapFolderId, e.MapLastTopicReply }, "map_user");

                entity.Property(e => e.MapId).HasColumnName("map_id");

                entity.Property(e => e.MapFolderId)
                    .HasMaxLength(32)
                    .HasColumnName("map_folder_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MapHasUnread).HasColumnName("map_has_unread");

                entity.Property(e => e.MapIgnoreNotification).HasColumnName("map_ignore_notification");

                entity.Property(e => e.MapIsStarter).HasColumnName("map_is_starter");

                entity.Property(e => e.MapIsSystem).HasColumnName("map_is_system");

                entity.Property(e => e.MapLastTopicReply).HasColumnName("map_last_topic_reply");

                entity.Property(e => e.MapLeftTime).HasColumnName("map_left_time");

                entity.Property(e => e.MapReadTime).HasColumnName("map_read_time");

                entity.Property(e => e.MapTopicId).HasColumnName("map_topic_id");

                entity.Property(e => e.MapUserActive).HasColumnName("map_user_active");

                entity.Property(e => e.MapUserBanned).HasColumnName("map_user_banned");

                entity.Property(e => e.MapUserId).HasColumnName("map_user_id");
            });

            modelBuilder.Entity<IpbmobileNotification>(entity =>
            {
                entity.ToTable("ipbmobile_notifications");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MemberId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("member_id");

                entity.Property(e => e.NotifyDate).HasColumnName("notify_date");

                entity.Property(e => e.NotifySent).HasColumnName("notify_sent");

                entity.Property(e => e.NotifyTitle)
                    .HasColumnType("text")
                    .HasColumnName("notify_title");
            });

            modelBuilder.Entity<IpbmodQueuedItem>(entity =>
            {
                entity.ToTable("ipbmod_queued_items");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.TypeId, "type_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Type)
                    .HasMaxLength(32)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'post'");

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<Ipbmoderator>(entity =>
            {
                entity.HasKey(e => e.Mid)
                    .HasName("PRIMARY");

                entity.ToTable("ipbmoderators");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.GroupId, "group_id");

                entity.HasIndex(e => e.MemberId, "member_id");

                entity.Property(e => e.Mid)
                    .HasColumnType("mediumint")
                    .HasColumnName("mid");

                entity.Property(e => e.AllowWarn).HasColumnName("allow_warn");

                entity.Property(e => e.CanMm).HasColumnName("can_mm");

                entity.Property(e => e.CloseTopic).HasColumnName("close_topic");

                entity.Property(e => e.DeletePost).HasColumnName("delete_post");

                entity.Property(e => e.DeleteTopic).HasColumnName("delete_topic");

                entity.Property(e => e.EditPost).HasColumnName("edit_post");

                entity.Property(e => e.EditTopic).HasColumnName("edit_topic");

                entity.Property(e => e.ForumId)
                    .HasColumnType("text")
                    .HasColumnName("forum_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(200)
                    .HasColumnName("group_name");

                entity.Property(e => e.IsGroup)
                    .HasColumnName("is_group")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MassMove).HasColumnName("mass_move");

                entity.Property(e => e.MassPrune).HasColumnName("mass_prune");

                entity.Property(e => e.MemberId)
                    .HasColumnType("mediumint")
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MemberName)
                    .HasMaxLength(32)
                    .HasColumnName("member_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModBitoptions).HasColumnName("mod_bitoptions");

                entity.Property(e => e.ModCanSetCloseTime).HasColumnName("mod_can_set_close_time");

                entity.Property(e => e.ModCanSetOpenTime).HasColumnName("mod_can_set_open_time");

                entity.Property(e => e.MoveTopic).HasColumnName("move_topic");

                entity.Property(e => e.OpenTopic).HasColumnName("open_topic");

                entity.Property(e => e.PinTopic).HasColumnName("pin_topic");

                entity.Property(e => e.PostQ).HasColumnName("post_q");

                entity.Property(e => e.SplitMerge)
                    .HasColumnName("split_merge")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TopicQ).HasColumnName("topic_q");

                entity.Property(e => e.UnpinTopic).HasColumnName("unpin_topic");

                entity.Property(e => e.ViewIp).HasColumnName("view_ip");
            });

            modelBuilder.Entity<IpbmoderatorLog>(entity =>
            {
                entity.ToTable("ipbmoderator_logs");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Ctime, "ctime");

                entity.HasIndex(e => e.IpAddress, "ip_address");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnType("text")
                    .HasColumnName("action");

                entity.Property(e => e.Ctime).HasColumnName("ctime");

                entity.Property(e => e.ForumId)
                    .HasColumnName("forum_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HttpReferer)
                    .HasColumnType("text")
                    .HasColumnName("http_referer");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("ip_address")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MemberId)
                    .HasColumnType("mediumint")
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MemberName)
                    .HasMaxLength(255)
                    .HasColumnName("member_name");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.QueryString)
                    .HasColumnType("text")
                    .HasColumnName("query_string");

                entity.Property(e => e.TopicId).HasColumnName("topic_id");

                entity.Property(e => e.TopicTitle)
                    .HasColumnType("text")
                    .HasColumnName("topic_title");
            });

            modelBuilder.Entity<IpbopenidTemp>(entity =>
            {
                entity.ToTable("ipbopenid_temp");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("id");

                entity.Property(e => e.Cookiedate).HasColumnName("cookiedate");

                entity.Property(e => e.Fullurl)
                    .HasColumnType("text")
                    .HasColumnName("fullurl");

                entity.Property(e => e.Privacy).HasColumnName("privacy");

                entity.Property(e => e.Referrer)
                    .HasColumnType("text")
                    .HasColumnName("referrer");
            });

            modelBuilder.Entity<IpbpermissionIndex>(entity =>
            {
                entity.HasKey(e => e.PermId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbpermission_index");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.PermType, e.PermTypeId }, "perm_index");

                entity.HasIndex(e => new { e.App, e.PermType, e.PermTypeId }, "perm_type");

                entity.Property(e => e.PermId).HasColumnName("perm_id");

                entity.Property(e => e.App)
                    .HasMaxLength(32)
                    .HasColumnName("app");

                entity.Property(e => e.AuthorizedUsers)
                    .HasMaxLength(255)
                    .HasColumnName("authorized_users");

                entity.Property(e => e.FriendOnly).HasColumnName("friend_only");

                entity.Property(e => e.OwnerOnly).HasColumnName("owner_only");

                entity.Property(e => e.Perm2)
                    .HasColumnType("text")
                    .HasColumnName("perm_2");

                entity.Property(e => e.Perm3)
                    .HasColumnType("text")
                    .HasColumnName("perm_3");

                entity.Property(e => e.Perm4)
                    .HasColumnType("text")
                    .HasColumnName("perm_4");

                entity.Property(e => e.Perm5)
                    .HasColumnType("text")
                    .HasColumnName("perm_5");

                entity.Property(e => e.Perm6)
                    .HasColumnType("text")
                    .HasColumnName("perm_6");

                entity.Property(e => e.Perm7)
                    .HasColumnType("text")
                    .HasColumnName("perm_7");

                entity.Property(e => e.PermType)
                    .HasMaxLength(32)
                    .HasColumnName("perm_type");

                entity.Property(e => e.PermTypeId).HasColumnName("perm_type_id");

                entity.Property(e => e.PermView)
                    .HasColumnType("text")
                    .HasColumnName("perm_view");
            });

            modelBuilder.Entity<IpbpfieldsContent>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbpfields_content");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.MemberId)
                    .HasColumnType("mediumint")
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Field1)
                    .HasColumnType("text")
                    .HasColumnName("field_1");

                entity.Property(e => e.Field10)
                    .HasColumnType("text")
                    .HasColumnName("field_10");

                entity.Property(e => e.Field12)
                    .HasColumnType("text")
                    .HasColumnName("field_12");

                entity.Property(e => e.Field13)
                    .HasColumnType("text")
                    .HasColumnName("field_13");

                entity.Property(e => e.Field14)
                    .HasColumnType("text")
                    .HasColumnName("field_14");

                entity.Property(e => e.Field15)
                    .HasColumnType("text")
                    .HasColumnName("field_15");

                entity.Property(e => e.Field16)
                    .HasColumnType("text")
                    .HasColumnName("field_16");

                entity.Property(e => e.Field17)
                    .HasColumnType("text")
                    .HasColumnName("field_17");

                entity.Property(e => e.Field18)
                    .HasColumnType("text")
                    .HasColumnName("field_18");

                entity.Property(e => e.Field19)
                    .HasColumnType("text")
                    .HasColumnName("field_19");

                entity.Property(e => e.Field2)
                    .HasColumnType("text")
                    .HasColumnName("field_2");

                entity.Property(e => e.Field20)
                    .HasColumnType("text")
                    .HasColumnName("field_20");

                entity.Property(e => e.Field21)
                    .HasColumnType("text")
                    .HasColumnName("field_21");

                entity.Property(e => e.Field22)
                    .HasColumnType("text")
                    .HasColumnName("field_22");

                entity.Property(e => e.Field23)
                    .HasColumnType("text")
                    .HasColumnName("field_23");

                entity.Property(e => e.Field24)
                    .HasColumnType("text")
                    .HasColumnName("field_24");

                entity.Property(e => e.Field25)
                    .HasColumnType("text")
                    .HasColumnName("field_25");

                entity.Property(e => e.Field3)
                    .HasColumnType("text")
                    .HasColumnName("field_3");

                entity.Property(e => e.Field4)
                    .HasColumnType("text")
                    .HasColumnName("field_4");

                entity.Property(e => e.Field5)
                    .HasColumnType("text")
                    .HasColumnName("field_5");

                entity.Property(e => e.Field6)
                    .HasColumnType("text")
                    .HasColumnName("field_6");

                entity.Property(e => e.Field7)
                    .HasColumnType("text")
                    .HasColumnName("field_7");

                entity.Property(e => e.Field8)
                    .HasColumnType("text")
                    .HasColumnName("field_8");

                entity.Property(e => e.Field9)
                    .HasColumnType("text")
                    .HasColumnName("field_9");
            });

            modelBuilder.Entity<IpbpfieldsDatum>(entity =>
            {
                entity.HasKey(e => e.PfId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbpfields_data");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.PfId).HasColumnName("pf_id");

                entity.Property(e => e.PfAdminOnly).HasColumnName("pf_admin_only");

                entity.Property(e => e.PfContent)
                    .HasColumnType("text")
                    .HasColumnName("pf_content");

                entity.Property(e => e.PfDesc)
                    .HasMaxLength(250)
                    .HasColumnName("pf_desc")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PfFiltering).HasColumnName("pf_filtering");

                entity.Property(e => e.PfGroupId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("pf_group_id");

                entity.Property(e => e.PfIcon)
                    .HasMaxLength(255)
                    .HasColumnName("pf_icon");

                entity.Property(e => e.PfInputFormat)
                    .HasColumnType("text")
                    .HasColumnName("pf_input_format");

                entity.Property(e => e.PfKey)
                    .HasMaxLength(255)
                    .HasColumnName("pf_key");

                entity.Property(e => e.PfMaxInput).HasColumnName("pf_max_input");

                entity.Property(e => e.PfMemberEdit).HasColumnName("pf_member_edit");

                entity.Property(e => e.PfMemberHide).HasColumnName("pf_member_hide");

                entity.Property(e => e.PfNotNull).HasColumnName("pf_not_null");

                entity.Property(e => e.PfPosition).HasColumnName("pf_position");

                entity.Property(e => e.PfSearchType)
                    .HasMaxLength(5)
                    .HasColumnName("pf_search_type")
                    .HasDefaultValueSql("'loose'");

                entity.Property(e => e.PfShowOnReg).HasColumnName("pf_show_on_reg");

                entity.Property(e => e.PfTitle)
                    .HasMaxLength(250)
                    .HasColumnName("pf_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PfTopicFormat)
                    .HasColumnType("text")
                    .HasColumnName("pf_topic_format");

                entity.Property(e => e.PfType)
                    .HasMaxLength(250)
                    .HasColumnName("pf_type")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbpfieldsGroup>(entity =>
            {
                entity.HasKey(e => e.PfGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbpfields_groups");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.PfGroupId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("pf_group_id");

                entity.Property(e => e.PfGroupKey)
                    .HasMaxLength(255)
                    .HasColumnName("pf_group_key");

                entity.Property(e => e.PfGroupName)
                    .HasMaxLength(255)
                    .HasColumnName("pf_group_name");
            });

            modelBuilder.Entity<Ipbpoll>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PRIMARY");

                entity.ToTable("ipbpolls");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Tid, "tid");

                entity.Property(e => e.Pid)
                    .HasColumnType("mediumint")
                    .HasColumnName("pid");

                entity.Property(e => e.Choices)
                    .HasColumnType("text")
                    .HasColumnName("choices");

                entity.Property(e => e.ForumId).HasColumnName("forum_id");

                entity.Property(e => e.PollOnly).HasColumnName("poll_only");

                entity.Property(e => e.PollQuestion)
                    .HasMaxLength(255)
                    .HasColumnName("poll_question");

                entity.Property(e => e.PollViewVoters).HasColumnName("poll_view_voters");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StarterId)
                    .HasColumnType("mediumint")
                    .HasColumnName("starter_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.Votes).HasColumnName("votes");
            });

            modelBuilder.Entity<Ipbpost>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PRIMARY");

                entity.ToTable("ipbposts");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.AuthorId, e.PostDate, e.Queued }, "author_id");

                entity.HasIndex(e => e.IpAddress, "ip_address");

                entity.HasIndex(e => e.Post, "post")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => e.PostDate, "post_date");

                entity.HasIndex(e => e.PostKey, "post_key");

                entity.HasIndex(e => new { e.Queued, e.PdeleteTime }, "queued");

                entity.HasIndex(e => new { e.TopicId, e.Queued, e.Pid, e.PostDate }, "topic_id");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.AppendEdit)
                    .HasColumnName("append_edit")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AuthorId)
                    .HasColumnType("mediumint")
                    .HasColumnName("author_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AuthorName)
                    .HasMaxLength(255)
                    .HasColumnName("author_name");

                entity.Property(e => e.EditName)
                    .HasMaxLength(255)
                    .HasColumnName("edit_name");

                entity.Property(e => e.EditTime).HasColumnName("edit_time");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("ip_address");

                entity.Property(e => e.NewTopic)
                    .HasColumnName("new_topic")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PdeleteTime).HasColumnName("pdelete_time");

                entity.Property(e => e.Post)
                    .HasColumnType("mediumtext")
                    .HasColumnName("post");

                entity.Property(e => e.PostBwoptions).HasColumnName("post_bwoptions");

                entity.Property(e => e.PostDate).HasColumnName("post_date");

                entity.Property(e => e.PostEditReason)
                    .HasMaxLength(255)
                    .HasColumnName("post_edit_reason")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PostFieldInt).HasColumnName("post_field_int");

                entity.Property(e => e.PostFieldT1)
                    .HasColumnType("text")
                    .HasColumnName("post_field_t1");

                entity.Property(e => e.PostFieldT2)
                    .HasColumnType("text")
                    .HasColumnName("post_field_t2");

                entity.Property(e => e.PostHtmlstate).HasColumnName("post_htmlstate");

                entity.Property(e => e.PostKey)
                    .HasMaxLength(32)
                    .HasColumnName("post_key")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PostTitle)
                    .HasMaxLength(255)
                    .HasColumnName("post_title");

                entity.Property(e => e.Queued).HasColumnName("queued");

                entity.Property(e => e.TopicId).HasColumnName("topic_id");

                entity.Property(e => e.UseEmo).HasColumnName("use_emo");

                entity.Property(e => e.UseSig).HasColumnName("use_sig");
            });

            modelBuilder.Entity<IpbprofileFriend>(entity =>
            {
                entity.HasKey(e => e.FriendsId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbprofile_friends");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.FriendsMemberId, e.FriendsFriendId }, "my_friends");

                entity.Property(e => e.FriendsId).HasColumnName("friends_id");

                entity.Property(e => e.FriendsAdded).HasColumnName("friends_added");

                entity.Property(e => e.FriendsApproved).HasColumnName("friends_approved");

                entity.Property(e => e.FriendsFriendId).HasColumnName("friends_friend_id");

                entity.Property(e => e.FriendsMemberId).HasColumnName("friends_member_id");
            });

            modelBuilder.Entity<IpbprofileFriendsFlood>(entity =>
            {
                entity.HasKey(e => e.FriendsId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbprofile_friends_flood");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.FriendsMemberId, e.FriendsFriendId }, "my_friends");

                entity.Property(e => e.FriendsId).HasColumnName("friends_id");

                entity.Property(e => e.FriendsFriendId).HasColumnName("friends_friend_id");

                entity.Property(e => e.FriendsMemberId).HasColumnName("friends_member_id");

                entity.Property(e => e.FriendsRemoved).HasColumnName("friends_removed");
            });

            modelBuilder.Entity<IpbprofilePortal>(entity =>
            {
                entity.HasKey(e => e.PpMemberId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbprofile_portal");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.PpMemberId)
                    .ValueGeneratedNever()
                    .HasColumnName("pp_member_id");

                entity.Property(e => e.AvatarLocation)
                    .HasMaxLength(255)
                    .HasColumnName("avatar_location");

                entity.Property(e => e.AvatarSize)
                    .HasMaxLength(9)
                    .HasColumnName("avatar_size")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AvatarType)
                    .HasMaxLength(15)
                    .HasColumnName("avatar_type");

                entity.Property(e => e.FbBwoptions).HasColumnName("fb_bwoptions");

                entity.Property(e => e.FbPhoto)
                    .HasColumnType("text")
                    .HasColumnName("fb_photo");

                entity.Property(e => e.FbPhotoThumb)
                    .HasColumnType("text")
                    .HasColumnName("fb_photo_thumb");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasColumnName("notes");

                entity.Property(e => e.PconversationFilters)
                    .HasColumnType("text")
                    .HasColumnName("pconversation_filters");

                entity.Property(e => e.PpAboutMe)
                    .HasColumnType("mediumtext")
                    .HasColumnName("pp_about_me");

                entity.Property(e => e.PpCustomization)
                    .HasColumnType("mediumtext")
                    .HasColumnName("pp_customization");

                entity.Property(e => e.PpGravatar)
                    .HasMaxLength(255)
                    .HasColumnName("pp_gravatar")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PpLastVisitors)
                    .HasColumnType("text")
                    .HasColumnName("pp_last_visitors");

                entity.Property(e => e.PpMainHeight).HasColumnName("pp_main_height");

                entity.Property(e => e.PpMainPhoto)
                    .HasMaxLength(255)
                    .HasColumnName("pp_main_photo")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PpMainWidth).HasColumnName("pp_main_width");

                entity.Property(e => e.PpPhotoType)
                    .HasMaxLength(20)
                    .HasColumnName("pp_photo_type")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PpRatingHits).HasColumnName("pp_rating_hits");

                entity.Property(e => e.PpRatingReal).HasColumnName("pp_rating_real");

                entity.Property(e => e.PpRatingValue).HasColumnName("pp_rating_value");

                entity.Property(e => e.PpReputationPoints).HasColumnName("pp_reputation_points");

                entity.Property(e => e.PpSettingCountComments).HasColumnName("pp_setting_count_comments");

                entity.Property(e => e.PpSettingCountFriends).HasColumnName("pp_setting_count_friends");

                entity.Property(e => e.PpSettingCountVisitors).HasColumnName("pp_setting_count_visitors");

                entity.Property(e => e.PpSettingModerateComments).HasColumnName("pp_setting_moderate_comments");

                entity.Property(e => e.PpSettingModerateFriends).HasColumnName("pp_setting_moderate_friends");

                entity.Property(e => e.PpThumbHeight).HasColumnName("pp_thumb_height");

                entity.Property(e => e.PpThumbPhoto)
                    .HasMaxLength(255)
                    .HasColumnName("pp_thumb_photo")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PpThumbWidth).HasColumnName("pp_thumb_width");

                entity.Property(e => e.Signature)
                    .HasColumnType("text")
                    .HasColumnName("signature");

                entity.Property(e => e.TcBwoptions).HasColumnName("tc_bwoptions");

                entity.Property(e => e.TcLastSidImport)
                    .HasMaxLength(50)
                    .HasColumnName("tc_last_sid_import")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TcPhoto)
                    .HasColumnType("text")
                    .HasColumnName("tc_photo");
            });

            modelBuilder.Entity<IpbprofilePortalView>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ipbprofile_portal_views");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.ViewsMemberId, "views_member_id");

                entity.Property(e => e.ViewsMemberId).HasColumnName("views_member_id");
            });

            modelBuilder.Entity<IpbprofileRating>(entity =>
            {
                entity.HasKey(e => e.RatingId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbprofile_ratings");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.RatingForMemberId, "rating_for_member_id");

                entity.HasIndex(e => e.RatingIpAddress, "rating_ip_address");

                entity.Property(e => e.RatingId).HasColumnName("rating_id");

                entity.Property(e => e.RatingByMemberId).HasColumnName("rating_by_member_id");

                entity.Property(e => e.RatingForMemberId).HasColumnName("rating_for_member_id");

                entity.Property(e => e.RatingIpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("rating_ip_address");

                entity.Property(e => e.RatingValue).HasColumnName("rating_value");
            });

            modelBuilder.Entity<IpbquestionAndAnswer>(entity =>
            {
                entity.HasKey(e => e.QaId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbquestion_and_answer");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.QaId).HasColumnName("qa_id");

                entity.Property(e => e.QaAnswers)
                    .HasColumnType("text")
                    .HasColumnName("qa_answers");

                entity.Property(e => e.QaQuestion)
                    .HasColumnType("text")
                    .HasColumnName("qa_question");
            });

            modelBuilder.Entity<IpbrcClass>(entity =>
            {
                entity.HasKey(e => e.ComId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbrc_classes");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Onoff, e.ModGroupPerm }, "onoff")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 255 });

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.App)
                    .HasMaxLength(32)
                    .HasColumnName("app");

                entity.Property(e => e.Author)
                    .HasMaxLength(255)
                    .HasColumnName("author")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AuthorUrl)
                    .HasMaxLength(255)
                    .HasColumnName("author_url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ClassDesc)
                    .HasColumnType("text")
                    .HasColumnName("class_desc");

                entity.Property(e => e.ClassTitle)
                    .HasMaxLength(255)
                    .HasColumnName("class_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("text")
                    .HasColumnName("extra_data");

                entity.Property(e => e.GroupCanReport)
                    .HasColumnType("text")
                    .HasColumnName("group_can_report");

                entity.Property(e => e.Lockd).HasColumnName("lockd");

                entity.Property(e => e.ModGroupPerm)
                    .HasColumnType("text")
                    .HasColumnName("mod_group_perm");

                entity.Property(e => e.MyClass)
                    .HasMaxLength(100)
                    .HasColumnName("my_class")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Onoff).HasColumnName("onoff");

                entity.Property(e => e.Pversion)
                    .HasMaxLength(255)
                    .HasColumnName("pversion")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbrcComment>(entity =>
            {
                entity.ToTable("ipbrc_comments");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AuthorName)
                    .HasMaxLength(255)
                    .HasColumnName("author_name");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.CommentBy)
                    .HasColumnType("mediumint")
                    .HasColumnName("comment_by")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CommentDate).HasColumnName("comment_date");

                entity.Property(e => e.EditDate).HasColumnName("edit_date");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("ip_address");

                entity.Property(e => e.Rid).HasColumnName("rid");
            });

            modelBuilder.Entity<IpbrcModpref>(entity =>
            {
                entity.HasKey(e => e.MemId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbrc_modpref");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.MemId)
                    .HasColumnType("mediumint")
                    .HasColumnName("mem_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RssCache)
                    .HasColumnType("mediumtext")
                    .HasColumnName("rss_cache");

                entity.Property(e => e.RssKey)
                    .HasMaxLength(32)
                    .HasColumnName("rss_key")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbrcReport>(entity =>
            {
                entity.ToTable("ipbrc_reports");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateReported).HasColumnName("date_reported");

                entity.Property(e => e.Report)
                    .HasColumnType("mediumtext")
                    .HasColumnName("report");

                entity.Property(e => e.ReportBy)
                    .HasColumnType("mediumint")
                    .HasColumnName("report_by")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Rid).HasColumnName("rid");
            });

            modelBuilder.Entity<IpbrcReportsIndex>(entity =>
            {
                entity.ToTable("ipbrc_reports_index");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Status, "status");

                entity.HasIndex(e => e.Uid, "uid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated).HasColumnName("date_created");

                entity.Property(e => e.DateUpdated).HasColumnName("date_updated");

                entity.Property(e => e.Exdat1).HasColumnName("exdat1");

                entity.Property(e => e.Exdat2).HasColumnName("exdat2");

                entity.Property(e => e.Exdat3).HasColumnName("exdat3");

                entity.Property(e => e.ImgPreview)
                    .HasMaxLength(255)
                    .HasColumnName("img_preview")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NumComments).HasColumnName("num_comments");

                entity.Property(e => e.NumReports).HasColumnName("num_reports");

                entity.Property(e => e.RcClass).HasColumnName("rc_class");

                entity.Property(e => e.Seoname)
                    .HasMaxLength(255)
                    .HasColumnName("seoname");

                entity.Property(e => e.Seotemplate)
                    .HasMaxLength(255)
                    .HasColumnName("seotemplate");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Uid)
                    .HasMaxLength(32)
                    .HasColumnName("uid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnType("mediumint")
                    .HasColumnName("updated_by")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbrcStatus>(entity =>
            {
                entity.HasKey(e => e.Status)
                    .HasName("PRIMARY");

                entity.ToTable("ipbrc_status");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsComplete).HasColumnName("is_complete");

                entity.Property(e => e.IsNew).HasColumnName("is_new");

                entity.Property(e => e.MinutesToApoint)
                    .HasColumnName("minutes_to_apoint")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.PointsPerReport)
                    .HasColumnName("points_per_report")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Rorder).HasColumnName("rorder");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbrcStatusSev>(entity =>
            {
                entity.ToTable("ipbrc_status_sev");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Status, e.Points }, "status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasDefaultValueSql("'16'");

                entity.Property(e => e.Img)
                    .HasMaxLength(255)
                    .HasColumnName("img")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsPng).HasColumnName("is_png");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasDefaultValueSql("'16'");
            });

            modelBuilder.Entity<IpbreputationCache>(entity =>
            {
                entity.ToTable("ipbreputation_cache");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.App, e.Type, e.TypeId }, "app")
                    .IsUnique();

                entity.HasIndex(e => new { e.Type, e.TypeId }, "type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.App)
                    .HasMaxLength(32)
                    .HasColumnName("app");

                entity.Property(e => e.RepLikeCache)
                    .HasColumnType("mediumtext")
                    .HasColumnName("rep_like_cache");

                entity.Property(e => e.RepPoints).HasColumnName("rep_points");

                entity.Property(e => e.Type)
                    .HasMaxLength(32)
                    .HasColumnName("type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<IpbreputationIndex>(entity =>
            {
                entity.ToTable("ipbreputation_index");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.App, e.Type, e.TypeId, e.MemberId }, "app");

                entity.HasIndex(e => new { e.MemberId, e.RepRating, e.RepDate }, "member_rep");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.App)
                    .HasMaxLength(32)
                    .HasColumnName("app");

                entity.Property(e => e.MemberId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("member_id");

                entity.Property(e => e.RepDate).HasColumnName("rep_date");

                entity.Property(e => e.RepMsg)
                    .HasColumnType("text")
                    .HasColumnName("rep_msg");

                entity.Property(e => e.RepRating).HasColumnName("rep_rating");

                entity.Property(e => e.Type)
                    .HasMaxLength(32)
                    .HasColumnName("type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<IpbreputationLevel>(entity =>
            {
                entity.HasKey(e => e.LevelId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbreputation_levels");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.LevelId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("level_id");

                entity.Property(e => e.LevelImage)
                    .HasMaxLength(255)
                    .HasColumnName("level_image");

                entity.Property(e => e.LevelPoints).HasColumnName("level_points");

                entity.Property(e => e.LevelTitle)
                    .HasMaxLength(255)
                    .HasColumnName("level_title");
            });

            modelBuilder.Entity<IpbrssExport>(entity =>
            {
                entity.HasKey(e => e.RssExportId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbrss_export");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.RssExportId).HasColumnName("rss_export_id");

                entity.Property(e => e.RssExportCacheContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("rss_export_cache_content");

                entity.Property(e => e.RssExportCacheLast).HasColumnName("rss_export_cache_last");

                entity.Property(e => e.RssExportCacheTime)
                    .HasColumnName("rss_export_cache_time")
                    .HasDefaultValueSql("'30'");

                entity.Property(e => e.RssExportCount).HasColumnName("rss_export_count");

                entity.Property(e => e.RssExportDesc)
                    .HasMaxLength(255)
                    .HasColumnName("rss_export_desc")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RssExportEnabled).HasColumnName("rss_export_enabled");

                entity.Property(e => e.RssExportForums)
                    .HasColumnType("text")
                    .HasColumnName("rss_export_forums");

                entity.Property(e => e.RssExportImage)
                    .HasMaxLength(255)
                    .HasColumnName("rss_export_image")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RssExportIncludePost).HasColumnName("rss_export_include_post");

                entity.Property(e => e.RssExportOrder)
                    .HasMaxLength(20)
                    .HasColumnName("rss_export_order")
                    .HasDefaultValueSql("'start_date'");

                entity.Property(e => e.RssExportSort)
                    .HasMaxLength(4)
                    .HasColumnName("rss_export_sort")
                    .HasDefaultValueSql("'DESC'");

                entity.Property(e => e.RssExportTitle)
                    .HasMaxLength(255)
                    .HasColumnName("rss_export_title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbrssImport>(entity =>
            {
                entity.HasKey(e => e.RssImportId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbrss_import");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.RssImportEnabled, e.RssImportLastImport }, "rss_grab");

                entity.Property(e => e.RssImportId).HasColumnName("rss_import_id");

                entity.Property(e => e.RssImportAllowHtml).HasColumnName("rss_import_allow_html");

                entity.Property(e => e.RssImportAuth).HasColumnName("rss_import_auth");

                entity.Property(e => e.RssImportAuthPass)
                    .HasMaxLength(255)
                    .HasColumnName("rss_import_auth_pass")
                    .HasDefaultValueSql("'Not Needed'");

                entity.Property(e => e.RssImportAuthUser)
                    .HasMaxLength(255)
                    .HasColumnName("rss_import_auth_user")
                    .HasDefaultValueSql("'Not Needed'");

                entity.Property(e => e.RssImportEnabled).HasColumnName("rss_import_enabled");

                entity.Property(e => e.RssImportForumId).HasColumnName("rss_import_forum_id");

                entity.Property(e => e.RssImportIncPcount).HasColumnName("rss_import_inc_pcount");

                entity.Property(e => e.RssImportLastImport).HasColumnName("rss_import_last_import");

                entity.Property(e => e.RssImportMid)
                    .HasColumnType("mediumint")
                    .HasColumnName("rss_import_mid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RssImportPergo).HasColumnName("rss_import_pergo");

                entity.Property(e => e.RssImportShowlink)
                    .HasMaxLength(255)
                    .HasColumnName("rss_import_showlink")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RssImportTime).HasColumnName("rss_import_time");

                entity.Property(e => e.RssImportTitle)
                    .HasMaxLength(255)
                    .HasColumnName("rss_import_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RssImportTopicHide).HasColumnName("rss_import_topic_hide");

                entity.Property(e => e.RssImportTopicOpen).HasColumnName("rss_import_topic_open");

                entity.Property(e => e.RssImportTopicPre)
                    .HasMaxLength(50)
                    .HasColumnName("rss_import_topic_pre")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RssImportUrl)
                    .HasMaxLength(255)
                    .HasColumnName("rss_import_url")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbrssImported>(entity =>
            {
                entity.HasKey(e => e.RssImportedGuid)
                    .HasName("PRIMARY");

                entity.ToTable("ipbrss_imported");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.RssImportedImpid, "rss_imported_impid");

                entity.Property(e => e.RssImportedGuid)
                    .HasMaxLength(32)
                    .HasColumnName("rss_imported_guid")
                    .HasDefaultValueSql("'0'")
                    .IsFixedLength();

                entity.Property(e => e.RssImportedImpid).HasColumnName("rss_imported_impid");

                entity.Property(e => e.RssImportedTid).HasColumnName("rss_imported_tid");
            });

            modelBuilder.Entity<IpbsearchSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbsearch_sessions");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.SessionUpdated, "session_updated");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(32)
                    .HasColumnName("session_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SessionCreated).HasColumnName("session_created");

                entity.Property(e => e.SessionData)
                    .HasColumnType("mediumtext")
                    .HasColumnName("session_data");

                entity.Property(e => e.SessionMemberId).HasColumnName("session_member_id");

                entity.Property(e => e.SessionUpdated).HasColumnName("session_updated");
            });

            modelBuilder.Entity<Ipbsession>(entity =>
            {
                entity.ToTable("ipbsessions");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Location1Type, e.Location1Id }, "location1");

                entity.HasIndex(e => new { e.Location2Type, e.Location2Id }, "location2");

                entity.HasIndex(e => new { e.Location3Type, e.Location3Id }, "location3");

                entity.HasIndex(e => e.MemberId, "member_id");

                entity.HasIndex(e => e.RunningTime, "running_time");

                entity.Property(e => e.Id)
                    .HasMaxLength(60)
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Browser)
                    .HasMaxLength(200)
                    .HasColumnName("browser")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CurrentAppcomponent)
                    .HasMaxLength(100)
                    .HasColumnName("current_appcomponent")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CurrentModule)
                    .HasMaxLength(100)
                    .HasColumnName("current_module")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CurrentSection)
                    .HasMaxLength(100)
                    .HasColumnName("current_section")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.InError).HasColumnName("in_error");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("ip_address");

                entity.Property(e => e.Location1Id).HasColumnName("location_1_id");

                entity.Property(e => e.Location1Type)
                    .HasColumnName("location_1_type")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Location2Id).HasColumnName("location_2_id");

                entity.Property(e => e.Location2Type)
                    .HasColumnName("location_2_type")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Location3Id).HasColumnName("location_3_id");

                entity.Property(e => e.Location3Type)
                    .HasColumnName("location_3_type")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LoginType)
                    .HasColumnName("login_type")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MemberGroup).HasColumnName("member_group");

                entity.Property(e => e.MemberId)
                    .HasColumnType("mediumint")
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MemberName)
                    .HasMaxLength(255)
                    .HasColumnName("member_name");

                entity.Property(e => e.RunningTime).HasColumnName("running_time");

                entity.Property(e => e.SearchThreadId).HasColumnName("search_thread_id");

                entity.Property(e => e.SearchThreadTime).HasColumnName("search_thread_time");

                entity.Property(e => e.SeoName)
                    .HasMaxLength(255)
                    .HasColumnName("seo_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SessionMsgId).HasColumnName("session_msg_id");

                entity.Property(e => e.UagentBypass).HasColumnName("uagent_bypass");

                entity.Property(e => e.UagentKey)
                    .HasMaxLength(200)
                    .HasColumnName("uagent_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UagentType)
                    .HasMaxLength(200)
                    .HasColumnName("uagent_type")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UagentVersion)
                    .HasMaxLength(100)
                    .HasColumnName("uagent_version")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbskinCache>(entity =>
            {
                entity.HasKey(e => e.CacheId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbskin_cache");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.CacheSetId, "cache_set_id");

                entity.HasIndex(e => e.CacheType, "cache_type");

                entity.Property(e => e.CacheId).HasColumnName("cache_id");

                entity.Property(e => e.CacheContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("cache_content");

                entity.Property(e => e.CacheKey1)
                    .HasMaxLength(200)
                    .HasColumnName("cache_key_1")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheKey2)
                    .HasMaxLength(200)
                    .HasColumnName("cache_key_2")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheKey3)
                    .HasMaxLength(200)
                    .HasColumnName("cache_key_3")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheKey4)
                    .HasMaxLength(200)
                    .HasColumnName("cache_key_4")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheKey5)
                    .HasMaxLength(200)
                    .HasColumnName("cache_key_5")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheKey6)
                    .HasMaxLength(200)
                    .HasColumnName("cache_key_6")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheSetId).HasColumnName("cache_set_id");

                entity.Property(e => e.CacheType)
                    .HasMaxLength(200)
                    .HasColumnName("cache_type")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheUpdated).HasColumnName("cache_updated");

                entity.Property(e => e.CacheValue1)
                    .HasMaxLength(200)
                    .HasColumnName("cache_value_1")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheValue2)
                    .HasMaxLength(200)
                    .HasColumnName("cache_value_2")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheValue3)
                    .HasMaxLength(200)
                    .HasColumnName("cache_value_3")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheValue4)
                    .HasMaxLength(200)
                    .HasColumnName("cache_value_4")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheValue5)
                    .HasMaxLength(200)
                    .HasColumnName("cache_value_5")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CacheValue6)
                    .HasMaxLength(200)
                    .HasColumnName("cache_value_6")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbskinCollection>(entity =>
            {
                entity.HasKey(e => e.SetId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbskin_collections");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.SetParentId, e.SetId }, "parent_set_id");

                entity.HasIndex(e => e.SetIsDefault, "set_is_default");

                entity.HasIndex(e => e.SetOrder, "set_order");

                entity.Property(e => e.SetId).HasColumnName("set_id");

                entity.Property(e => e.SetAdded).HasColumnName("set_added");

                entity.Property(e => e.SetAuthorName)
                    .HasMaxLength(255)
                    .HasColumnName("set_author_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SetAuthorUrl)
                    .HasMaxLength(255)
                    .HasColumnName("set_author_url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SetBySkinGen).HasColumnName("set_by_skin_gen");

                entity.Property(e => e.SetChildArray)
                    .HasColumnType("mediumtext")
                    .HasColumnName("set_child_array");

                entity.Property(e => e.SetCssGroups)
                    .HasColumnType("text")
                    .HasColumnName("set_css_groups");

                entity.Property(e => e.SetCssInline).HasColumnName("set_css_inline");

                entity.Property(e => e.SetEmoDir)
                    .HasMaxLength(255)
                    .HasColumnName("set_emo_dir")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.SetHideFromList).HasColumnName("set_hide_from_list");

                entity.Property(e => e.SetImageDir)
                    .HasMaxLength(255)
                    .HasColumnName("set_image_dir")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.SetIsDefault).HasColumnName("set_is_default");

                entity.Property(e => e.SetKey)
                    .HasMaxLength(100)
                    .HasColumnName("set_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SetLockedUagent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("set_locked_uagent");

                entity.Property(e => e.SetMasterKey)
                    .HasMaxLength(100)
                    .HasColumnName("set_master_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SetMinify).HasColumnName("set_minify");

                entity.Property(e => e.SetName)
                    .HasMaxLength(200)
                    .HasColumnName("set_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SetOrder).HasColumnName("set_order");

                entity.Property(e => e.SetOutputFormat)
                    .HasMaxLength(200)
                    .HasColumnName("set_output_format")
                    .HasDefaultValueSql("'html'");

                entity.Property(e => e.SetParentArray)
                    .HasColumnType("mediumtext")
                    .HasColumnName("set_parent_array");

                entity.Property(e => e.SetParentId)
                    .HasColumnName("set_parent_id")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.SetPermissions)
                    .HasColumnType("text")
                    .HasColumnName("set_permissions");

                entity.Property(e => e.SetSkinGenData)
                    .HasColumnType("mediumtext")
                    .HasColumnName("set_skin_gen_data");

                entity.Property(e => e.SetUpdated).HasColumnName("set_updated");
            });

            modelBuilder.Entity<IpbskinCss>(entity =>
            {
                entity.HasKey(e => e.CssId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbskin_css");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.CssSetId, "css_set_id");

                entity.Property(e => e.CssId).HasColumnName("css_id");

                entity.Property(e => e.CssAddedTo).HasColumnName("css_added_to");

                entity.Property(e => e.CssApp)
                    .HasMaxLength(200)
                    .HasColumnName("css_app")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CssAppHide).HasColumnName("css_app_hide");

                entity.Property(e => e.CssAttributes)
                    .HasColumnType("text")
                    .HasColumnName("css_attributes");

                entity.Property(e => e.CssContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("css_content");

                entity.Property(e => e.CssGroup)
                    .HasMaxLength(255)
                    .HasColumnName("css_group")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CssMasterKey)
                    .HasMaxLength(100)
                    .HasColumnName("css_master_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CssModules)
                    .HasMaxLength(250)
                    .HasColumnName("css_modules")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CssPosition).HasColumnName("css_position");

                entity.Property(e => e.CssRemoved).HasColumnName("css_removed");

                entity.Property(e => e.CssSetId).HasColumnName("css_set_id");

                entity.Property(e => e.CssUpdated).HasColumnName("css_updated");
            });

            modelBuilder.Entity<IpbskinCssPreviou>(entity =>
            {
                entity.HasKey(e => e.PCssId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbskin_css_previous");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.PCssId).HasColumnName("p_css_id");

                entity.Property(e => e.PCssApp)
                    .HasMaxLength(200)
                    .HasColumnName("p_css_app")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PCssAttributes)
                    .HasColumnType("text")
                    .HasColumnName("p_css_attributes");

                entity.Property(e => e.PCssContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("p_css_content");

                entity.Property(e => e.PCssGroup)
                    .HasMaxLength(255)
                    .HasColumnName("p_css_group")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PCssHumanVersion)
                    .HasMaxLength(100)
                    .HasColumnName("p_css_human_version")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PCssLongVersion)
                    .HasMaxLength(100)
                    .HasColumnName("p_css_long_version")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PCssMasterKey)
                    .HasMaxLength(100)
                    .HasColumnName("p_css_master_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PCssModules)
                    .HasMaxLength(250)
                    .HasColumnName("p_css_modules")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbskinGeneratorSession>(entity =>
            {
                entity.HasKey(e => e.SgSessionId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbskin_generator_sessions");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.SgSessionId)
                    .HasMaxLength(32)
                    .HasColumnName("sg_session_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SgData)
                    .HasColumnType("mediumtext")
                    .HasColumnName("sg_data");

                entity.Property(e => e.SgDateStart).HasColumnName("sg_date_start");

                entity.Property(e => e.SgMemberId).HasColumnName("sg_member_id");

                entity.Property(e => e.SgSkinSetId).HasColumnName("sg_skin_set_id");
            });

            modelBuilder.Entity<IpbskinMergeChange>(entity =>
            {
                entity.HasKey(e => e.ChangeId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbskin_merge_changes");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.ChangeKey, e.ChangeDataType }, "change_key");

                entity.Property(e => e.ChangeId).HasColumnName("change_id");

                entity.Property(e => e.ChangeCanMerge).HasColumnName("change_can_merge");

                entity.Property(e => e.ChangeChangesApplied).HasColumnName("change_changes_applied");

                entity.Property(e => e.ChangeDataContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("change_data_content");

                entity.Property(e => e.ChangeDataGroup)
                    .HasMaxLength(255)
                    .HasColumnName("change_data_group")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChangeDataTitle)
                    .HasMaxLength(255)
                    .HasColumnName("change_data_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChangeDataType)
                    .HasMaxLength(10)
                    .HasColumnName("change_data_type")
                    .HasDefaultValueSql("'template'");

                entity.Property(e => e.ChangeFinalContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("change_final_content");

                entity.Property(e => e.ChangeIsConflict).HasColumnName("change_is_conflict");

                entity.Property(e => e.ChangeIsDiff).HasColumnName("change_is_diff");

                entity.Property(e => e.ChangeIsNew).HasColumnName("change_is_new");

                entity.Property(e => e.ChangeKey)
                    .HasColumnName("change_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChangeMergeContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("change_merge_content");

                entity.Property(e => e.ChangeOriginalContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("change_original_content");

                entity.Property(e => e.ChangeSessionId).HasColumnName("change_session_id");

                entity.Property(e => e.ChangeUpdated).HasColumnName("change_updated");
            });

            modelBuilder.Entity<IpbskinMergeSession>(entity =>
            {
                entity.HasKey(e => e.MergeId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbskin_merge_session");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.MergeId).HasColumnName("merge_id");

                entity.Property(e => e.MergeCssDone).HasColumnName("merge_css_done");

                entity.Property(e => e.MergeCssTogo).HasColumnName("merge_css_togo");

                entity.Property(e => e.MergeDate).HasColumnName("merge_date");

                entity.Property(e => e.MergeDiffDone).HasColumnName("merge_diff_done");

                entity.Property(e => e.MergeMCssDone).HasColumnName("merge_m_css_done");

                entity.Property(e => e.MergeMCssTogo).HasColumnName("merge_m_css_togo");

                entity.Property(e => e.MergeMTemplatesDone).HasColumnName("merge_m_templates_done");

                entity.Property(e => e.MergeMTemplatesTogo).HasColumnName("merge_m_templates_togo");

                entity.Property(e => e.MergeMasterKey)
                    .HasMaxLength(200)
                    .HasColumnName("merge_master_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MergeNewVersion)
                    .HasMaxLength(200)
                    .HasColumnName("merge_new_version")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MergeOldVersion)
                    .HasMaxLength(200)
                    .HasColumnName("merge_old_version")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MergeSetId).HasColumnName("merge_set_id");

                entity.Property(e => e.MergeTemplatesDone).HasColumnName("merge_templates_done");

                entity.Property(e => e.MergeTemplatesTogo).HasColumnName("merge_templates_togo");
            });

            modelBuilder.Entity<IpbskinReplacement>(entity =>
            {
                entity.HasKey(e => e.ReplacementId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbskin_replacements");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.ReplacementSetId, "replacement_set_id");

                entity.Property(e => e.ReplacementId).HasColumnName("replacement_id");

                entity.Property(e => e.ReplacementAddedTo).HasColumnName("replacement_added_to");

                entity.Property(e => e.ReplacementContent)
                    .HasColumnType("text")
                    .HasColumnName("replacement_content");

                entity.Property(e => e.ReplacementKey)
                    .HasMaxLength(255)
                    .HasColumnName("replacement_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReplacementMasterKey)
                    .HasMaxLength(100)
                    .HasColumnName("replacement_master_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReplacementSetId).HasColumnName("replacement_set_id");
            });

            modelBuilder.Entity<IpbskinTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbskin_templates");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.TemplateMasterKey, "template_master_key");

                entity.HasIndex(e => new { e.TemplateName, e.TemplateGroup }, "template_name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100, 100 });

                entity.HasIndex(e => e.TemplateSetId, "template_set_id");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.TemplateAddedTo).HasColumnName("template_added_to");

                entity.Property(e => e.TemplateContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("template_content");

                entity.Property(e => e.TemplateData)
                    .HasColumnType("text")
                    .HasColumnName("template_data");

                entity.Property(e => e.TemplateGroup)
                    .HasColumnName("template_group")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TemplateMasterKey)
                    .HasMaxLength(100)
                    .HasColumnName("template_master_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TemplateName).HasColumnName("template_name");

                entity.Property(e => e.TemplateRemovable).HasColumnName("template_removable");

                entity.Property(e => e.TemplateSetId).HasColumnName("template_set_id");

                entity.Property(e => e.TemplateUpdated).HasColumnName("template_updated");

                entity.Property(e => e.TemplateUserAdded).HasColumnName("template_user_added");

                entity.Property(e => e.TemplateUserEdited).HasColumnName("template_user_edited");
            });

            modelBuilder.Entity<IpbskinTemplatesCache>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbskin_templates_cache");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.TemplateGroupName, "template_group_name");

                entity.HasIndex(e => e.TemplateSetId, "template_set_id");

                entity.Property(e => e.TemplateId)
                    .HasMaxLength(32)
                    .HasColumnName("template_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TemplateGroupContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("template_group_content");

                entity.Property(e => e.TemplateGroupName)
                    .HasColumnName("template_group_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TemplateSetId).HasColumnName("template_set_id");
            });

            modelBuilder.Entity<IpbskinTemplatesPreviou>(entity =>
            {
                entity.HasKey(e => e.PTemplateId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbskin_templates_previous");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.PTemplateId).HasColumnName("p_template_id");

                entity.Property(e => e.PTemplateContent)
                    .HasColumnType("mediumtext")
                    .HasColumnName("p_template_content");

                entity.Property(e => e.PTemplateData)
                    .HasColumnType("text")
                    .HasColumnName("p_template_data");

                entity.Property(e => e.PTemplateGroup)
                    .HasMaxLength(255)
                    .HasColumnName("p_template_group")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PTemplateHumanVersion)
                    .HasMaxLength(100)
                    .HasColumnName("p_template_human_version")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PTemplateLongVersion)
                    .HasMaxLength(100)
                    .HasColumnName("p_template_long_version")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PTemplateMasterKey)
                    .HasMaxLength(100)
                    .HasColumnName("p_template_master_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PTemplateName)
                    .HasMaxLength(255)
                    .HasColumnName("p_template_name");
            });

            modelBuilder.Entity<IpbskinUrlMapping>(entity =>
            {
                entity.HasKey(e => e.MapId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbskin_url_mapping");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.MapId).HasColumnName("map_id");

                entity.Property(e => e.MapDateAdded).HasColumnName("map_date_added");

                entity.Property(e => e.MapMatchType)
                    .HasMaxLength(10)
                    .HasColumnName("map_match_type")
                    .HasDefaultValueSql("'contains'");

                entity.Property(e => e.MapSkinSetId).HasColumnName("map_skin_set_id");

                entity.Property(e => e.MapTitle)
                    .HasMaxLength(200)
                    .HasColumnName("map_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MapUrl)
                    .HasMaxLength(200)
                    .HasColumnName("map_url")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbspamServiceLog>(entity =>
            {
                entity.ToTable("ipbspam_service_log");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(255)
                    .HasColumnName("email_address");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LogCode).HasColumnName("log_code");

                entity.Property(e => e.LogDate).HasColumnName("log_date");

                entity.Property(e => e.LogMsg)
                    .HasMaxLength(32)
                    .HasColumnName("log_msg");
            });

            modelBuilder.Entity<IpbspiderLog>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PRIMARY");

                entity.ToTable("ipbspider_logs");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.EntryDate, "entry_date");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Bot)
                    .HasMaxLength(255)
                    .HasColumnName("bot")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EntryDate).HasColumnName("entry_date");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("ip_address");

                entity.Property(e => e.QueryString)
                    .HasColumnType("text")
                    .HasColumnName("query_string");

                entity.Property(e => e.RequestAddr)
                    .HasColumnType("text")
                    .HasColumnName("request_addr");
            });

            modelBuilder.Entity<IpbtagsIndex>(entity =>
            {
                entity.ToTable("ipbtags_index");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.App, "app");

                entity.HasIndex(e => new { e.App, e.Type, e.TypeId, e.Type2, e.TypeId2, e.TagHidden }, "tag_grab");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.App).HasColumnName("app");

                entity.Property(e => e.MemberId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("member_id");

                entity.Property(e => e.Tag)
                    .HasMaxLength(255)
                    .HasColumnName("tag");

                entity.Property(e => e.TagHidden).HasColumnName("tag_hidden");

                entity.Property(e => e.Type)
                    .HasMaxLength(32)
                    .HasColumnName("type");

                entity.Property(e => e.Type2)
                    .HasMaxLength(32)
                    .HasColumnName("type_2");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.TypeId2).HasColumnName("type_id_2");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<IpbtaskLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbtask_logs");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.LogDate, "log_date");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.LogDate).HasColumnName("log_date");

                entity.Property(e => e.LogDesc)
                    .HasColumnType("text")
                    .HasColumnName("log_desc");

                entity.Property(e => e.LogIp)
                    .HasMaxLength(46)
                    .HasColumnName("log_ip")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LogTitle)
                    .HasMaxLength(255)
                    .HasColumnName("log_title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbtaskManager>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbtask_manager");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.TaskApplication, e.TaskKey }, "task_key")
                    .IsUnique();

                entity.HasIndex(e => new { e.TaskEnabled, e.TaskNextRun }, "task_next_run");

                entity.Property(e => e.TaskId).HasColumnName("task_id");

                entity.Property(e => e.TaskApplication)
                    .HasMaxLength(100)
                    .HasColumnName("task_application");

                entity.Property(e => e.TaskCronkey)
                    .HasMaxLength(32)
                    .HasColumnName("task_cronkey")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaskDescription)
                    .HasColumnType("text")
                    .HasColumnName("task_description");

                entity.Property(e => e.TaskEnabled)
                    .IsRequired()
                    .HasColumnName("task_enabled")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TaskFile)
                    .HasMaxLength(255)
                    .HasColumnName("task_file")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaskHour)
                    .HasColumnName("task_hour")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.TaskKey)
                    .HasMaxLength(30)
                    .HasColumnName("task_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaskLocked).HasColumnName("task_locked");

                entity.Property(e => e.TaskLog).HasColumnName("task_log");

                entity.Property(e => e.TaskMinute)
                    .HasColumnName("task_minute")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.TaskMonthDay)
                    .HasColumnName("task_month_day")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.TaskNextRun).HasColumnName("task_next_run");

                entity.Property(e => e.TaskSafemode).HasColumnName("task_safemode");

                entity.Property(e => e.TaskTitle)
                    .HasMaxLength(255)
                    .HasColumnName("task_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaskWeekDay)
                    .HasColumnName("task_week_day")
                    .HasDefaultValueSql("'-1'");
            });

            modelBuilder.Entity<IpbtemplateSandr>(entity =>
            {
                entity.HasKey(e => e.SandrSessionId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbtemplate_sandr");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.SandrSessionId).HasColumnName("sandr_session_id");

                entity.Property(e => e.SandrIsRegex).HasColumnName("sandr_is_regex");

                entity.Property(e => e.SandrReplaceWith)
                    .HasColumnType("text")
                    .HasColumnName("sandr_replace_with");

                entity.Property(e => e.SandrResults)
                    .HasColumnType("mediumtext")
                    .HasColumnName("sandr_results");

                entity.Property(e => e.SandrSearchAll).HasColumnName("sandr_search_all");

                entity.Property(e => e.SandrSearchFor)
                    .HasColumnType("text")
                    .HasColumnName("sandr_search_for");

                entity.Property(e => e.SandrSearchOnly).HasColumnName("sandr_search_only");

                entity.Property(e => e.SandrSetId).HasColumnName("sandr_set_id");

                entity.Property(e => e.SandrTemplateCount).HasColumnName("sandr_template_count");

                entity.Property(e => e.SandrTemplateProcessed).HasColumnName("sandr_template_processed");

                entity.Property(e => e.SandrUpdated).HasColumnName("sandr_updated");
            });

            modelBuilder.Entity<Ipbtitle>(entity =>
            {
                entity.ToTable("ipbtitles");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Posts, "posts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Pips)
                    .HasMaxLength(128)
                    .HasColumnName("pips");

                entity.Property(e => e.Posts).HasColumnName("posts");

                entity.Property(e => e.Title)
                    .HasMaxLength(128)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Ipbtopic>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PRIMARY");

                entity.ToTable("ipbtopics");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Approved, e.TdeleteTime }, "approved");

                entity.HasIndex(e => new { e.ForumId, e.Pinned, e.Approved }, "forum_id");

                entity.HasIndex(e => new { e.ForumId, e.Pinned, e.LastPost, e.State }, "last_post");

                entity.HasIndex(e => new { e.LastPost, e.ForumId }, "last_post_sorting");

                entity.HasIndex(e => new { e.ForumId, e.Approved, e.StartDate }, "last_x_topics");

                entity.HasIndex(e => new { e.MovedOn, e.MovedTo, e.Pinned }, "moved_redirects");

                entity.HasIndex(e => e.StartDate, "start_date");

                entity.HasIndex(e => new { e.StarterId, e.ForumId, e.Approved, e.StartDate }, "starter_id");

                entity.HasIndex(e => e.Title, "title")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => e.TopicFirstpost, "topic_firstpost");

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.AuthorMode).HasColumnName("author_mode");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("description");

                entity.Property(e => e.ForumId).HasColumnName("forum_id");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.LastPost).HasColumnName("last_post");

                entity.Property(e => e.LastPosterId)
                    .HasColumnType("mediumint")
                    .HasColumnName("last_poster_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LastPosterName)
                    .HasMaxLength(255)
                    .HasColumnName("last_poster_name");

                entity.Property(e => e.LastVote).HasColumnName("last_vote");

                entity.Property(e => e.MovedOn).HasColumnName("moved_on");

                entity.Property(e => e.MovedTo)
                    .HasMaxLength(64)
                    .HasColumnName("moved_to");

                entity.Property(e => e.Pinned).HasColumnName("pinned");

                entity.Property(e => e.PollState)
                    .HasMaxLength(8)
                    .HasColumnName("poll_state");

                entity.Property(e => e.Posts).HasColumnName("posts");

                entity.Property(e => e.SeoFirstName)
                    .HasMaxLength(255)
                    .HasColumnName("seo_first_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SeoLastName)
                    .HasMaxLength(255)
                    .HasColumnName("seo_last_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StarterId)
                    .HasColumnType("mediumint")
                    .HasColumnName("starter_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StarterName)
                    .HasMaxLength(255)
                    .HasColumnName("starter_name");

                entity.Property(e => e.State)
                    .HasMaxLength(8)
                    .HasColumnName("state");

                entity.Property(e => e.TdeleteTime).HasColumnName("tdelete_time");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TitleSeo)
                    .HasMaxLength(250)
                    .HasColumnName("title_seo")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TopicCloseTime).HasColumnName("topic_close_time");

                entity.Property(e => e.TopicDeletedPosts).HasColumnName("topic_deleted_posts");

                entity.Property(e => e.TopicFirstpost).HasColumnName("topic_firstpost");

                entity.Property(e => e.TopicHasattach).HasColumnName("topic_hasattach");

                entity.Property(e => e.TopicOpenTime).HasColumnName("topic_open_time");

                entity.Property(e => e.TopicQueuedposts).HasColumnName("topic_queuedposts");

                entity.Property(e => e.TopicRatingHits).HasColumnName("topic_rating_hits");

                entity.Property(e => e.TopicRatingTotal).HasColumnName("topic_rating_total");

                entity.Property(e => e.Views).HasColumnName("views");
            });

            modelBuilder.Entity<IpbtopicMmod>(entity =>
            {
                entity.HasKey(e => e.MmId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbtopic_mmod");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.MmId).HasColumnName("mm_id");

                entity.Property(e => e.MmEnabled).HasColumnName("mm_enabled");

                entity.Property(e => e.MmForums)
                    .HasColumnType("text")
                    .HasColumnName("mm_forums");

                entity.Property(e => e.MmTitle)
                    .HasMaxLength(250)
                    .HasColumnName("mm_title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TopicApprove).HasColumnName("topic_approve");

                entity.Property(e => e.TopicMove).HasColumnName("topic_move");

                entity.Property(e => e.TopicMoveLink).HasColumnName("topic_move_link");

                entity.Property(e => e.TopicPin)
                    .HasMaxLength(10)
                    .HasColumnName("topic_pin")
                    .HasDefaultValueSql("'leave'");

                entity.Property(e => e.TopicReply).HasColumnName("topic_reply");

                entity.Property(e => e.TopicReplyContent)
                    .HasColumnType("text")
                    .HasColumnName("topic_reply_content");

                entity.Property(e => e.TopicReplyPostcount).HasColumnName("topic_reply_postcount");

                entity.Property(e => e.TopicState)
                    .HasMaxLength(10)
                    .HasColumnName("topic_state")
                    .HasDefaultValueSql("'leave'");

                entity.Property(e => e.TopicTitleEnd)
                    .HasMaxLength(250)
                    .HasColumnName("topic_title_end")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TopicTitleSt)
                    .HasMaxLength(250)
                    .HasColumnName("topic_title_st")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbtopicRating>(entity =>
            {
                entity.HasKey(e => e.RatingId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbtopic_ratings");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.RatingIpAddress, "rating_ip_address");

                entity.HasIndex(e => new { e.RatingTid, e.RatingMemberId }, "rating_tid");

                entity.Property(e => e.RatingId).HasColumnName("rating_id");

                entity.Property(e => e.RatingIpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("rating_ip_address");

                entity.Property(e => e.RatingMemberId)
                    .HasColumnType("mediumint")
                    .HasColumnName("rating_member_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RatingTid).HasColumnName("rating_tid");

                entity.Property(e => e.RatingValue).HasColumnName("rating_value");
            });

            modelBuilder.Entity<IpbtopicView>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ipbtopic_views");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.ViewsTid, "views_tid");

                entity.Property(e => e.ViewsTid).HasColumnName("views_tid");
            });

            modelBuilder.Entity<IpbtwitterConnect>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ipbtwitter_connect");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.TKey)
                    .HasMaxLength(32)
                    .HasColumnName("t_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TSecret)
                    .HasMaxLength(255)
                    .HasColumnName("t_secret")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TTime).HasColumnName("t_time");

                entity.Property(e => e.TToken)
                    .HasMaxLength(255)
                    .HasColumnName("t_token")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IpbupgradeHistory>(entity =>
            {
                entity.HasKey(e => e.UpgradeId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbupgrade_history");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.UpgradeApp, e.UpgradeVersionId }, "upgrades");

                entity.Property(e => e.UpgradeId).HasColumnName("upgrade_id");

                entity.Property(e => e.UpgradeApp)
                    .HasMaxLength(32)
                    .HasColumnName("upgrade_app")
                    .HasDefaultValueSql("'core'");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeMid).HasColumnName("upgrade_mid");

                entity.Property(e => e.UpgradeNotes)
                    .HasColumnType("text")
                    .HasColumnName("upgrade_notes");

                entity.Property(e => e.UpgradeVersionHuman)
                    .HasMaxLength(200)
                    .HasColumnName("upgrade_version_human")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UpgradeVersionId).HasColumnName("upgrade_version_id");
            });

            modelBuilder.Entity<IpbupgradeSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbupgrade_sessions");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(32)
                    .HasColumnName("session_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SessionCurrentTime).HasColumnName("session_current_time");

                entity.Property(e => e.SessionData)
                    .HasColumnType("text")
                    .HasColumnName("session_data");

                entity.Property(e => e.SessionExtra)
                    .HasColumnType("text")
                    .HasColumnName("session_extra");

                entity.Property(e => e.SessionGet)
                    .HasColumnType("text")
                    .HasColumnName("session_get");

                entity.Property(e => e.SessionIpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("session_ip_address");

                entity.Property(e => e.SessionMemberId).HasColumnName("session_member_id");

                entity.Property(e => e.SessionMemberKey)
                    .HasMaxLength(32)
                    .HasColumnName("session_member_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SessionPost)
                    .HasColumnType("text")
                    .HasColumnName("session_post");

                entity.Property(e => e.SessionSection)
                    .HasMaxLength(32)
                    .HasColumnName("session_section")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SessionStartTime).HasColumnName("session_start_time");
            });

            modelBuilder.Entity<Ipbvalidating>(entity =>
            {
                entity.HasKey(e => e.Vid)
                    .HasName("PRIMARY");

                entity.ToTable("ipbvalidating");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.CoppaUser, "coppa_user");

                entity.HasIndex(e => e.IpAddress, "ip_address");

                entity.HasIndex(e => e.LostPass, "lost_pass");

                entity.HasIndex(e => e.MemberId, "member_id");

                entity.HasIndex(e => e.NewReg, "new_reg");

                entity.HasIndex(e => e.SpamFlag, "spam_flag");

                entity.Property(e => e.Vid)
                    .HasMaxLength(32)
                    .HasColumnName("vid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CoppaUser).HasColumnName("coppa_user");

                entity.Property(e => e.EmailChg).HasColumnName("email_chg");

                entity.Property(e => e.EntryDate).HasColumnName("entry_date");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("ip_address")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LostPass).HasColumnName("lost_pass");

                entity.Property(e => e.MemberId)
                    .HasColumnType("mediumint")
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NewReg).HasColumnName("new_reg");

                entity.Property(e => e.PrevEmail)
                    .HasMaxLength(150)
                    .HasColumnName("prev_email")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RealGroup).HasColumnName("real_group");

                entity.Property(e => e.SpamFlag).HasColumnName("spam_flag");

                entity.Property(e => e.TempGroup).HasColumnName("temp_group");

                entity.Property(e => e.UserVerified).HasColumnName("user_verified");
            });

            modelBuilder.Entity<Ipbvoter>(entity =>
            {
                entity.HasKey(e => e.Vid)
                    .HasName("PRIMARY");

                entity.ToTable("ipbvoters");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.IpAddress, "ip_address");

                entity.HasIndex(e => e.Tid, "tid");

                entity.Property(e => e.Vid).HasColumnName("vid");

                entity.Property(e => e.ForumId).HasColumnName("forum_id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(46)
                    .HasColumnName("ip_address");

                entity.Property(e => e.MemberChoices)
                    .HasColumnType("text")
                    .HasColumnName("member_choices");

                entity.Property(e => e.MemberId).HasColumnName("member_id");

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.VoteDate).HasColumnName("vote_date");
            });

            modelBuilder.Entity<IpbwarnLog>(entity =>
            {
                entity.HasKey(e => e.WlogId)
                    .HasName("PRIMARY");

                entity.ToTable("ipbwarn_logs");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.WlogMid, e.WlogDate }, "wlog_mid");

                entity.Property(e => e.WlogId).HasColumnName("wlog_id");

                entity.Property(e => e.WlogAddedby)
                    .HasColumnType("mediumint")
                    .HasColumnName("wlog_addedby")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WlogContact)
                    .HasMaxLength(250)
                    .HasColumnName("wlog_contact")
                    .HasDefaultValueSql("'none'");

                entity.Property(e => e.WlogContactContent)
                    .HasColumnType("text")
                    .HasColumnName("wlog_contact_content");

                entity.Property(e => e.WlogDate).HasColumnName("wlog_date");

                entity.Property(e => e.WlogMid)
                    .HasColumnType("mediumint")
                    .HasColumnName("wlog_mid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WlogNotes)
                    .HasColumnType("text")
                    .HasColumnName("wlog_notes");

                entity.Property(e => e.WlogType)
                    .HasMaxLength(6)
                    .HasColumnName("wlog_type")
                    .HasDefaultValueSql("'pos'");
            });

            modelBuilder.Entity<Link>(entity =>
            {
                entity.ToTable("links");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.Hash, e.Hits }, "hash");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Hash)
                    .HasMaxLength(32)
                    .HasColumnName("hash");

                entity.Property(e => e.Hits).HasColumnName("hits");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .HasColumnName("ip");

                entity.Property(e => e.Lastupd)
                    .HasColumnType("datetime")
                    .HasColumnName("lastupd");

                entity.Property(e => e.Title)
                    .HasColumnType("text")
                    .HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uiq).HasColumnName("uiq");

                entity.Property(e => e.Url)
                    .HasColumnType("mediumtext")
                    .HasColumnName("url");
            });

            modelBuilder.Entity<Tblcomp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblcomp");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Address)
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.Answer).HasColumnName("answer");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Ip)
                    .HasColumnType("text")
                    .HasColumnName("ip");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasColumnName("name");

                entity.Property(e => e.Optin)
                    .HasColumnType("text")
                    .HasColumnName("optin");

                entity.Property(e => e.Tel)
                    .HasColumnType("text")
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<TblcompDell>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblcomp_dell");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Address)
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.Answer).HasColumnName("answer");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Ip)
                    .HasColumnType("text")
                    .HasColumnName("ip");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasColumnName("name");

                entity.Property(e => e.Optin)
                    .HasColumnType("text")
                    .HasColumnName("optin");

                entity.Property(e => e.Tel)
                    .HasColumnType("text")
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<Tblcontent>(entity =>
            {
                entity.ToTable("tblcontent");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Name, "name")
                    .IsUnique()
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => new { e.Title, e.Text }, "text")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => e.Title, "title")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Featured).HasColumnName("featured");

                entity.Property(e => e.Featuredimg)
                    .HasColumnType("tinytext")
                    .HasColumnName("featuredimg")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Hits)
                    .HasColumnName("hits")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Image)
                    .HasColumnType("tinytext")
                    .HasColumnName("image")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Lastview)
                    .HasColumnType("datetime")
                    .HasColumnName("lastview");

                entity.Property(e => e.MainCat)
                    .HasColumnType("tinytext")
                    .HasColumnName("main_cat")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.MidCat)
                    .HasColumnType("tinytext")
                    .HasColumnName("mid_cat")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .HasColumnType("tinytext")
                    .HasColumnName("name")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Oldid).HasColumnName("oldid");

                entity.Property(e => e.Posterid).HasColumnName("posterid");

                entity.Property(e => e.Postername)
                    .HasColumnType("tinytext")
                    .HasColumnName("postername")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Prevkey)
                    .HasMaxLength(32)
                    .HasColumnName("prevkey")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Price)
                    .HasColumnType("tinytext")
                    .HasColumnName("price")
                    .UseCollation("utf8mb3_unicode_ci");

                entity.Property(e => e.Pricecomp)
                    .HasColumnType("text")
                    .HasColumnName("pricecomp")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Pricesku)
                    .HasColumnType("tinytext")
                    .HasColumnName("pricesku")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Priceurl)
                    .HasColumnType("tinytext")
                    .HasColumnName("priceurl")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Scrollimg)
                    .HasColumnType("text")
                    .HasColumnName("scrollimg")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Source)
                    .HasColumnType("tinytext")
                    .HasColumnName("source")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Sourceurl)
                    .HasColumnType("text")
                    .HasColumnName("sourceurl")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SubCat)
                    .HasColumnType("tinytext")
                    .HasColumnName("sub_cat")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Threadid)
                    .HasColumnName("threadid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Title)
                    .HasColumnType("tinytext")
                    .HasColumnName("title")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Video)
                    .HasColumnType("text")
                    .HasColumnName("video")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.HasMany<Tblcontentdatum>(c => c.TableContentData)
                    .WithOne()
                    .HasForeignKey(c => c.Contid);
            });

            modelBuilder.Entity<TblcontentBak>(entity =>
            {
                entity.ToTable("tblcontent_bak");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Name, "name")
                    .IsUnique()
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => new { e.Title, e.Text }, "text")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => e.Title, "title")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Featured).HasColumnName("featured");

                entity.Property(e => e.Featuredimg)
                    .HasColumnType("tinytext")
                    .HasColumnName("featuredimg");

                entity.Property(e => e.Hits)
                    .HasColumnName("hits")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Image)
                    .HasColumnType("tinytext")
                    .HasColumnName("image");

                entity.Property(e => e.Lastview)
                    .HasColumnType("datetime")
                    .HasColumnName("lastview");

                entity.Property(e => e.MainCat)
                    .HasColumnType("tinytext")
                    .HasColumnName("main_cat");

                entity.Property(e => e.MidCat)
                    .HasColumnType("tinytext")
                    .HasColumnName("mid_cat");

                entity.Property(e => e.Name)
                    .HasColumnType("tinytext")
                    .HasColumnName("name");

                entity.Property(e => e.Oldid).HasColumnName("oldid");

                entity.Property(e => e.Posterid).HasColumnName("posterid");

                entity.Property(e => e.Postername)
                    .HasColumnType("tinytext")
                    .HasColumnName("postername");

                entity.Property(e => e.Prevkey)
                    .HasMaxLength(32)
                    .HasColumnName("prevkey");

                entity.Property(e => e.Price)
                    .HasColumnType("tinytext")
                    .HasColumnName("price");

                entity.Property(e => e.Pricecomp)
                    .HasColumnType("text")
                    .HasColumnName("pricecomp");

                entity.Property(e => e.Pricesku)
                    .HasColumnType("tinytext")
                    .HasColumnName("pricesku");

                entity.Property(e => e.Priceurl)
                    .HasColumnType("tinytext")
                    .HasColumnName("priceurl");

                entity.Property(e => e.Scrollimg)
                    .HasColumnType("text")
                    .HasColumnName("scrollimg");

                entity.Property(e => e.Source)
                    .HasColumnType("tinytext")
                    .HasColumnName("source");

                entity.Property(e => e.Sourceurl)
                    .HasColumnType("text")
                    .HasColumnName("sourceurl");

                entity.Property(e => e.SubCat)
                    .HasColumnType("tinytext")
                    .HasColumnName("sub_cat");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.Threadid)
                    .HasColumnName("threadid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Title)
                    .HasColumnType("tinytext")
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TblcontentBak2>(entity =>
            {
                entity.ToTable("tblcontent_bak2");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Name, "name")
                    .IsUnique()
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => new { e.Title, e.Text }, "text")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => e.Title, "title")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Featured).HasColumnName("featured");

                entity.Property(e => e.Featuredimg)
                    .HasColumnType("tinytext")
                    .HasColumnName("featuredimg");

                entity.Property(e => e.Hits)
                    .HasColumnName("hits")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Image)
                    .HasColumnType("tinytext")
                    .HasColumnName("image");

                entity.Property(e => e.Lastview)
                    .HasColumnType("datetime")
                    .HasColumnName("lastview");

                entity.Property(e => e.MainCat)
                    .HasColumnType("tinytext")
                    .HasColumnName("main_cat");

                entity.Property(e => e.MidCat)
                    .HasColumnType("tinytext")
                    .HasColumnName("mid_cat");

                entity.Property(e => e.Name)
                    .HasColumnType("tinytext")
                    .HasColumnName("name");

                entity.Property(e => e.Oldid).HasColumnName("oldid");

                entity.Property(e => e.Posterid).HasColumnName("posterid");

                entity.Property(e => e.Postername)
                    .HasColumnType("tinytext")
                    .HasColumnName("postername");

                entity.Property(e => e.Prevkey)
                    .HasMaxLength(32)
                    .HasColumnName("prevkey");

                entity.Property(e => e.Price)
                    .HasColumnType("tinytext")
                    .HasColumnName("price");

                entity.Property(e => e.Pricecomp)
                    .HasColumnType("text")
                    .HasColumnName("pricecomp");

                entity.Property(e => e.Pricesku)
                    .HasColumnType("tinytext")
                    .HasColumnName("pricesku");

                entity.Property(e => e.Priceurl)
                    .HasColumnType("tinytext")
                    .HasColumnName("priceurl");

                entity.Property(e => e.Scrollimg)
                    .HasColumnType("text")
                    .HasColumnName("scrollimg");

                entity.Property(e => e.Source)
                    .HasColumnType("tinytext")
                    .HasColumnName("source");

                entity.Property(e => e.Sourceurl)
                    .HasColumnType("text")
                    .HasColumnName("sourceurl");

                entity.Property(e => e.SubCat)
                    .HasColumnType("tinytext")
                    .HasColumnName("sub_cat");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.Threadid)
                    .HasColumnName("threadid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Title)
                    .HasColumnType("tinytext")
                    .HasColumnName("title");

                entity.Property(e => e.Video)
                    .HasColumnType("text")
                    .HasColumnName("video");
            });

            modelBuilder.Entity<Tblcontentdatum>(entity =>
            {
                entity.ToTable("tblcontentdata");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Text, "text")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contid).HasColumnName("contid");

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.Posterid).HasColumnName("posterid");

                entity.Property(e => e.Text)
                    .HasColumnType("mediumtext")
                    .HasColumnName("text");

                entity.Property(e => e.Title)
                    .HasColumnType("text")
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Tbllogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbllogins");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .HasColumnName("ip");

                entity.Property(e => e.Result)
                    .HasMaxLength(20)
                    .HasColumnName("result");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Tblpoll>(entity =>
            {
                entity.ToTable("tblpoll");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Options)
                    .HasColumnType("text")
                    .HasColumnName("options");

                entity.Property(e => e.Question)
                    .HasColumnType("text")
                    .HasColumnName("question");

                entity.Property(e => e.Sponsorurl)
                    .HasColumnType("text")
                    .HasColumnName("sponsorurl");

                entity.Property(e => e.Votes)
                    .HasColumnType("text")
                    .HasColumnName("votes");
            });

            modelBuilder.Entity<Tblsnippet>(entity =>
            {
                entity.ToTable("tblsnippets");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Site)
                    .HasColumnType("text")
                    .HasColumnName("site");

                entity.Property(e => e.SubCat)
                    .HasColumnType("text")
                    .HasColumnName("sub_cat");

                entity.Property(e => e.Title)
                    .HasColumnType("text")
                    .HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Url)
                    .HasColumnType("text")
                    .HasColumnName("url");
            });

            modelBuilder.Entity<Tbluser>(entity =>
            {
                entity.ToTable("tblusers");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Username, "username")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnType("text")
                    .HasColumnName("email");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(20)
                    .HasColumnName("fullname");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .HasColumnName("ip")
                    .HasDefaultValueSql("''")
                    .UseCollation("latin1_bin");

                entity.Property(e => e.Password)
                    .HasMaxLength(32)
                    .HasColumnName("password")
                    .HasDefaultValueSql("''")
                    .IsFixedLength()
                    .UseCollation("latin1_bin");

                entity.Property(e => e.Perms).HasColumnName("perms");

                entity.Property(e => e.Session)
                    .HasMaxLength(32)
                    .HasColumnName("session")
                    .IsFixedLength();

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
