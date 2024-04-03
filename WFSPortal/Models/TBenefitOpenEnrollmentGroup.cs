using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitOpenEnrollmentGroup")]
[Index("BenefitOpenEnrollmentGroupGuid", Name = "RG_tBenefitOpenEnrollmentGroup", IsUnique = true)]
public partial class TBenefitOpenEnrollmentGroup
{
    [Key]
    [StringLength(15)]
    public string BenefitOpenEnrollmentGroupCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime BenefitOpenEnrollmentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BenefitOpenEnrollmentStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BenefitOpenEnrollmentEndDate { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("BenefitOpenEnrollmentGroupGUID")]
    public Guid BenefitOpenEnrollmentGroupGuid { get; set; }

    public bool NewEnrollmentFlag { get; set; }

    public bool NewEnrollmentTemplateFlag { get; set; }

    public int? QualifyTime { get; set; }

    [StringLength(15)]
    public string? QualifyTimeUnit { get; set; }

    public bool FirstOfNextMonthFlag { get; set; }

    public int? HireDateIndicator { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EarliestEligibilityDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LatestEligibilityDate { get; set; }

    [StringLength(15)]
    public string? BasedOnTemplateCode { get; set; }

    public int? AutoCreateIntervalTime { get; set; }

    [StringLength(15)]
    public string? AutoCreateIntervalTimeUnit { get; set; }

    public int? AutoCreateDaysInAdvance { get; set; }

    public int? ChoicesAvailableDaysInAdvance { get; set; }

    public int? ChoicesAvailableDays { get; set; }

    public int? PurgeDelayDays { get; set; }

    public int RowVersion { get; set; }

    public bool AutoGenerateChoicesFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public bool LifeEventEnrollmentFlag { get; set; }

    public bool LifeEventEnrollmentTemplateFlag { get; set; }

    public bool? BenefitOptionOnlyFlag { get; set; }

    public bool AllowDependentEdit { get; set; }

    public string? BenefitOpenEnrollmentGroupDescription { get; set; }

    public string? DetailComments { get; set; }

    public string? SummaryComments { get; set; }

    public bool SendEmployeeNotificationEmailFlag { get; set; }

    [StringLength(255)]
    public string? BenefitOpenEnrollmentGroupAdministratorEmail { get; set; }

    public Guid? BenefitOpenEnrollmentGroupConfirmationEmailTemplate { get; set; }

    public Guid? BenefitOpenEnrollmentGroupCreatedEmailTemplate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SendOnDate { get; set; }

    public bool SendUponCreationOfGroupFlag { get; set; }

    public Guid? BenefitOpenEnrollmentEmployeeCompletedEmailTemplate { get; set; }

    public Guid? BenefitOpenEnrollmentEmployeeCompletedToAdminEmailTemplate { get; set; }

    public Guid? BenefitOpenEnrollmentEmployeeApprovedEmailTemplate { get; set; }

    public Guid? BenefitOpenEnrollmentEmployeeDeniedEmailTemplate { get; set; }

    public bool SendEmployeeCompletedEmailFlag { get; set; }

    public bool SendEmployeeCompletedToAdminEmailFlag { get; set; }

    public bool SendEmployeeApprovedEmailFlag { get; set; }

    public bool SendEmployeeDeniedEmailFlag { get; set; }

    [ForeignKey("BasedOnTemplateCode")]
    [InverseProperty("InverseBasedOnTemplateCodeNavigation")]
    public virtual TBenefitOpenEnrollmentGroup? BasedOnTemplateCodeNavigation { get; set; }

    [ForeignKey("BenefitOpenEnrollmentEmployeeApprovedEmailTemplate")]
    [InverseProperty("TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentEmployeeApprovedEmailTemplateNavigations")]
    public virtual UsysCommunicationTemplate? BenefitOpenEnrollmentEmployeeApprovedEmailTemplateNavigation { get; set; }

    [ForeignKey("BenefitOpenEnrollmentEmployeeCompletedEmailTemplate")]
    [InverseProperty("TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentEmployeeCompletedEmailTemplateNavigations")]
    public virtual UsysCommunicationTemplate? BenefitOpenEnrollmentEmployeeCompletedEmailTemplateNavigation { get; set; }

    [ForeignKey("BenefitOpenEnrollmentEmployeeCompletedToAdminEmailTemplate")]
    [InverseProperty("TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentEmployeeCompletedToAdminEmailTemplateNavigations")]
    public virtual UsysCommunicationTemplate? BenefitOpenEnrollmentEmployeeCompletedToAdminEmailTemplateNavigation { get; set; }

    [ForeignKey("BenefitOpenEnrollmentEmployeeDeniedEmailTemplate")]
    [InverseProperty("TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentEmployeeDeniedEmailTemplateNavigations")]
    public virtual UsysCommunicationTemplate? BenefitOpenEnrollmentEmployeeDeniedEmailTemplateNavigation { get; set; }

    [ForeignKey("BenefitOpenEnrollmentGroupConfirmationEmailTemplate")]
    [InverseProperty("TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentGroupConfirmationEmailTemplateNavigations")]
    public virtual UsysCommunicationTemplate? BenefitOpenEnrollmentGroupConfirmationEmailTemplateNavigation { get; set; }

    [ForeignKey("BenefitOpenEnrollmentGroupCreatedEmailTemplate")]
    [InverseProperty("TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentGroupCreatedEmailTemplateNavigations")]
    public virtual UsysCommunicationTemplate? BenefitOpenEnrollmentGroupCreatedEmailTemplateNavigation { get; set; }

    [InverseProperty("BasedOnTemplateCodeNavigation")]
    public virtual ICollection<TBenefitOpenEnrollmentGroup> InverseBasedOnTemplateCodeNavigation { get; set; } = new List<TBenefitOpenEnrollmentGroup>();

    [InverseProperty("BenefitOpenEnrollmentGroupCodeNavigation")]
    public virtual ICollection<TBenefitOpenEnrollmentGroupPlanOption> TBenefitOpenEnrollmentGroupPlanOptions { get; set; } = new List<TBenefitOpenEnrollmentGroupPlanOption>();

    [InverseProperty("BenefitOpenEnrollmentGroupCodeNavigation")]
    public virtual ICollection<TBenefitOpenEnrollmentGroupStep> TBenefitOpenEnrollmentGroupSteps { get; set; } = new List<TBenefitOpenEnrollmentGroupStep>();

    [InverseProperty("BenefitOpenEnrollmentGroupTemplateNavigation")]
    public virtual ICollection<TLifeEventType> TLifeEventTypes { get; set; } = new List<TLifeEventType>();

    [InverseProperty("BenefitOpenEnrollmentGroupCodeNavigation")]
    public virtual ICollection<TPersonFutureEnrollmentStatus> TPersonFutureEnrollmentStatuses { get; set; } = new List<TPersonFutureEnrollmentStatus>();
}
