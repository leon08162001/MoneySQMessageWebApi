using System;
using System.Configuration;
using System.Data.Entity;
using MoneySQContext.LASTWModels;

namespace MoneySQContext
{
    public partial class LasTWEntities : DbContext
    {
        public LasTWEntities(String Connectionname)
        {
            string ConnStr = ConfigurationManager.ConnectionStrings[Connectionname].ToString();
            string DecryptConn = Utility.DBConnection.GetEntityServerPlainConnString(ConnStr);
            DbContext DbContext = new DbContext(DecryptConn);
            base.Database.Connection.ConnectionString = DbContext.Database.Connection.ConnectionString;
            //base.Database.Connection.ConnectionString = Utility.DBConnection.GetSqlServerPlainConnString(ConnStr);
        }
        public virtual DbSet<addressLog> addressLog { get; set; }
        public virtual DbSet<application_media> application_media { get; set; }
        public virtual DbSet<approvalLog> approvalLog { get; set; }
        public virtual DbSet<carLicense> carLicense { get; set; }
        public virtual DbSet<comUser> comUser { get; set; }
        public virtual DbSet<followup_issues> followup_issues { get; set; }
        public virtual DbSet<followup_issuesItem> followup_issuesItem { get; set; }
        public virtual DbSet<followup_issueType> followup_issueType { get; set; }
        public virtual DbSet<followup_status> followup_status { get; set; }
        public virtual DbSet<history> history { get; set; }
        public virtual DbSet<legalCase> legalCase { get; set; }
        public virtual DbSet<legalCase_Status> legalCase_Status { get; set; }
        public virtual DbSet<loanApplication> loanApplication { get; set; }
        public virtual DbSet<loanApplication_address> loanApplication_address { get; set; }
        public virtual DbSet<loanApplication_addressValuation> loanApplication_addressValuation { get; set; }
        public virtual DbSet<loanApplication_audit> loanApplication_audit { get; set; }
        public virtual DbSet<loanApplication_contractProperty> loanApplication_contractProperty { get; set; }
        public virtual DbSet<loanApplication_customer> loanApplication_customer { get; set; }
        public virtual DbSet<loanApplication_exCustomer> loanApplication_exCustomer { get; set; }
        public virtual DbSet<loanApplication_exCustomer_borrower> loanApplication_exCustomer_borrower { get; set; }
        public virtual DbSet<loanApplication_exCustomer_property> loanApplication_exCustomer_property { get; set; }
        public virtual DbSet<loanApplication_exCustomer_raw> loanApplication_exCustomer_raw { get; set; }
        public virtual DbSet<loanApplication_exCustomer_reply> loanApplication_exCustomer_reply { get; set; }
        public virtual DbSet<loanApplication_exCustomer_status> loanApplication_exCustomer_status { get; set; }
        public virtual DbSet<loanApplication_PropertyType> loanApplication_PropertyType { get; set; }
        public virtual DbSet<loanApplication_status> loanApplication_status { get; set; }
        public virtual DbSet<loanApplicationLog> loanApplicationLog { get; set; }
        public virtual DbSet<loanApplicationPassStevenLog> loanApplicationPassStevenLog { get; set; }
        public virtual DbSet<loanApplicationPayableTo> loanApplicationPayableTo { get; set; }
        public virtual DbSet<loanApplicationRejReason> loanApplicationRejReason { get; set; }
        public virtual DbSet<loanApplicationSMSlog> loanApplicationSMSlog { get; set; }
        public virtual DbSet<media> media { get; set; }
        public virtual DbSet<mortgage_log> mortgage_log { get; set; }
        public virtual DbSet<mortgageCar_schedule> mortgageCar_schedule { get; set; }
        public virtual DbSet<mortgageCar_schedule_log> mortgageCar_schedule_log { get; set; }
        public virtual DbSet<mortgageCar_Survey> mortgageCar_Survey { get; set; }
        public virtual DbSet<privacy> privacy { get; set; }
        public virtual DbSet<refinanceApplication> refinanceApplication { get; set; }
        public virtual DbSet<refinanceApplicationLog> refinanceApplicationLog { get; set; }
        public virtual DbSet<refinanceApprovalLog> refinanceApprovalLog { get; set; }
        public virtual DbSet<refinanceAttachmentLog> refinanceAttachmentLog { get; set; }
        public virtual DbSet<refinanceItem> refinanceItem { get; set; }
        public virtual DbSet<refinancePayableTo> refinancePayableTo { get; set; }
        public virtual DbSet<refinanceReplyHistory> refinanceReplyHistory { get; set; }
        public virtual DbSet<refinanceRetentionReport> refinanceRetentionReport { get; set; }
        public virtual DbSet<refinanceStatus> refinanceStatus { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<systemConfiguration_log> systemConfiguration_log { get; set; }
        public virtual DbSet<SystemMessage> SystemMessage { get; set; }
        public virtual DbSet<UserActivityLog> UserActivityLog { get; set; }
    }
}
