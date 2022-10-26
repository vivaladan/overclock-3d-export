namespace Overclock3D.Database.Models
{
    public partial class ForumsLanguage
    {
        public ushort Languageid { get; set; }
        public string Title { get; set; } = null!;
        public ushort Userselect { get; set; }
        public ushort Options { get; set; }
        public string Languagecode { get; set; } = null!;
        public string Charset { get; set; } = null!;
        public string Imagesoverride { get; set; } = null!;
        public string Dateoverride { get; set; } = null!;
        public string Timeoverride { get; set; } = null!;
        public string Registereddateoverride { get; set; } = null!;
        public string Calformat1override { get; set; } = null!;
        public string Calformat2override { get; set; } = null!;
        public string Logdateoverride { get; set; } = null!;
        public string Locale { get; set; } = null!;
        public string Decimalsep { get; set; } = null!;
        public string Thousandsep { get; set; } = null!;
        public string? PhrasegroupGlobal { get; set; }
        public string? PhrasegroupCpglobal { get; set; }
        public string? PhrasegroupCppermission { get; set; }
        public string? PhrasegroupForum { get; set; }
        public string? PhrasegroupCalendar { get; set; }
        public string? PhrasegroupAttachmentImage { get; set; }
        public string? PhrasegroupStyle { get; set; }
        public string? PhrasegroupLogging { get; set; }
        public string? PhrasegroupCphome { get; set; }
        public string? PhrasegroupPromotion { get; set; }
        public string? PhrasegroupUser { get; set; }
        public string? PhrasegroupHelpFaq { get; set; }
        public string? PhrasegroupSql { get; set; }
        public string? PhrasegroupSubscription { get; set; }
        public string? PhrasegroupLanguage { get; set; }
        public string? PhrasegroupBbcode { get; set; }
        public string? PhrasegroupStats { get; set; }
        public string? PhrasegroupDiagnostic { get; set; }
        public string? PhrasegroupMaintenance { get; set; }
        public string? PhrasegroupProfilefield { get; set; }
        public string? PhrasegroupThread { get; set; }
        public string? PhrasegroupTimezone { get; set; }
        public string? PhrasegroupBanning { get; set; }
        public string? PhrasegroupReputation { get; set; }
        public string? PhrasegroupWol { get; set; }
        public string? PhrasegroupThreadmanage { get; set; }
        public string? PhrasegroupPm { get; set; }
        public string? PhrasegroupCpuser { get; set; }
        public string? PhrasegroupAccessmask { get; set; }
        public string? PhrasegroupCron { get; set; }
        public string? PhrasegroupModerator { get; set; }
        public string? PhrasegroupCpoption { get; set; }
        public string? PhrasegroupCprank { get; set; }
        public string? PhrasegroupCpusergroup { get; set; }
        public string? PhrasegroupHoliday { get; set; }
        public string? PhrasegroupPosting { get; set; }
        public string? PhrasegroupPoll { get; set; }
        public string? PhrasegroupFronthelp { get; set; }
        public string? PhrasegroupRegister { get; set; }
        public string? PhrasegroupSearch { get; set; }
        public string? PhrasegroupShowthread { get; set; }
        public string? PhrasegroupPostbit { get; set; }
        public string? PhrasegroupForumdisplay { get; set; }
        public string? PhrasegroupMessaging { get; set; }
        public string? PhrasegroupInlinemod { get; set; }
        public string? PhrasegroupPlugins { get; set; }
        public string? PhrasegroupCprofilefield { get; set; }
        public string? PhrasegroupReputationlevel { get; set; }
        public string? PhrasegroupInfraction { get; set; }
        public string? PhrasegroupInfractionlevel { get; set; }
        public string? PhrasegroupNotice { get; set; }
        public string? PhrasegroupPrefix { get; set; }
        public string? PhrasegroupPrefixadmin { get; set; }
        public string? PhrasegroupAlbum { get; set; }
        public string? PhrasegroupSocialgroups { get; set; }
        public string PhrasegroupAdvPortal { get; set; } = null!;
        public string PhrasegroupAdvPortalCp { get; set; } = null!;
        public string PhrasegroupDtoGarage { get; set; } = null!;
    }
}
