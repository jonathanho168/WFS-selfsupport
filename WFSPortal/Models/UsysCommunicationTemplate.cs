using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCommunicationTemplate")]
public partial class UsysCommunicationTemplate
{
    [StringLength(50)]
    public string? EntityName { get; set; }

    [Key]
    [Column("CommunicationTemplateGUID")]
    public Guid CommunicationTemplateGuid { get; set; }

    [StringLength(15)]
    public string TemplateType { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string? EmailProfileCode { get; set; }

    [StringLength(15)]
    public string? CommunicationTemplateName { get; set; }

    [StringLength(256)]
    public string? Attachments { get; set; }

    public int LicenseFlags { get; set; }

    public string? Body { get; set; }

    public string? CommunicationTemplateDescription { get; set; }

    public string? Subject { get; set; }

    [ForeignKey("EmailProfileCode")]
    [InverseProperty("UsysCommunicationTemplates")]
    public virtual UsysEmailProfile? EmailProfileCodeNavigation { get; set; }

    [ForeignKey("EntityName")]
    [InverseProperty("UsysCommunicationTemplates")]
    public virtual UsysEntity? EntityNameNavigation { get; set; }

    [InverseProperty("CommunicationTemplate")]
    public virtual ICollection<TAbsenceRuleSet> TAbsenceRuleSets { get; set; } = new List<TAbsenceRuleSet>();

    [InverseProperty("BenefitOpenEnrollmentEmployeeApprovedEmailTemplateNavigation")]
    public virtual ICollection<TBenefitOpenEnrollmentGroup> TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentEmployeeApprovedEmailTemplateNavigations { get; set; } = new List<TBenefitOpenEnrollmentGroup>();

    [InverseProperty("BenefitOpenEnrollmentEmployeeCompletedEmailTemplateNavigation")]
    public virtual ICollection<TBenefitOpenEnrollmentGroup> TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentEmployeeCompletedEmailTemplateNavigations { get; set; } = new List<TBenefitOpenEnrollmentGroup>();

    [InverseProperty("BenefitOpenEnrollmentEmployeeCompletedToAdminEmailTemplateNavigation")]
    public virtual ICollection<TBenefitOpenEnrollmentGroup> TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentEmployeeCompletedToAdminEmailTemplateNavigations { get; set; } = new List<TBenefitOpenEnrollmentGroup>();

    [InverseProperty("BenefitOpenEnrollmentEmployeeDeniedEmailTemplateNavigation")]
    public virtual ICollection<TBenefitOpenEnrollmentGroup> TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentEmployeeDeniedEmailTemplateNavigations { get; set; } = new List<TBenefitOpenEnrollmentGroup>();

    [InverseProperty("BenefitOpenEnrollmentGroupConfirmationEmailTemplateNavigation")]
    public virtual ICollection<TBenefitOpenEnrollmentGroup> TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentGroupConfirmationEmailTemplateNavigations { get; set; } = new List<TBenefitOpenEnrollmentGroup>();

    [InverseProperty("BenefitOpenEnrollmentGroupCreatedEmailTemplateNavigation")]
    public virtual ICollection<TBenefitOpenEnrollmentGroup> TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentGroupCreatedEmailTemplateNavigations { get; set; } = new List<TBenefitOpenEnrollmentGroup>();

    [InverseProperty("CommunicationTemplate")]
    public virtual ICollection<TPersonApplicationCommunication> TPersonApplicationCommunications { get; set; } = new List<TPersonApplicationCommunication>();

    [InverseProperty("CommunicationTemplate")]
    public virtual ICollection<UsysAlert> UsysAlerts { get; set; } = new List<UsysAlert>();
}
