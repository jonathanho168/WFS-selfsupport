using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonLeaveRequestEligibility")]
public partial class TPersonLeaveRequestEligibility
{
    [Key]
    [Column("PersonLeaveRequestEligibilityGUID")]
    public Guid PersonLeaveRequestEligibilityGuid { get; set; }

    [Column("PersonLeaveRequestGUID")]
    public Guid PersonLeaveRequestGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EligibilityNoticeDate { get; set; }

    [Column("FMLAIneligibleFlag")]
    public bool? FmlaineligibleFlag { get; set; }

    [Column("FMLAIneligibleReason")]
    [StringLength(80)]
    public string? FmlaineligibleReason { get; set; }

    [Column("FMLAIneligibleReasonMonths", TypeName = "decimal(19, 2)")]
    public decimal? FmlaineligibleReasonMonths { get; set; }

    [Column("FMLAContactPerson")]
    [StringLength(30)]
    public string? FmlacontactPerson { get; set; }

    [Column("FMLAPosterLocation")]
    [StringLength(80)]
    public string? FmlaposterLocation { get; set; }

    public bool AdditionalInformationRequiredFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AdditionalInformationDueDate { get; set; }

    public bool AdditionalInformationCertificationRequiredFlag { get; set; }

    public bool AdditionalInformationRelationshipDocRequiredFlag { get; set; }

    public bool AdditionalInformationOtherInformationRequiredFlag { get; set; }

    public string? AdditionalInformationOtherInformationRequiredComments { get; set; }

    public bool HealthPremiumDueFlag { get; set; }

    [StringLength(80)]
    public string? HealthPremiumContactName { get; set; }

    [StringLength(80)]
    public string? HealthPremiumContactLocation { get; set; }

    [Column("PTORequiredFlag")]
    public bool PtorequiredFlag { get; set; }

    [Column("PTORequiredSickFlag")]
    public bool PtorequiredSickFlag { get; set; }

    [Column("PTORequiredVacationFlag")]
    public bool PtorequiredVacationFlag { get; set; }

    [Column("PTORequiredOtherFlag")]
    public bool PtorequiredOtherFlag { get; set; }

    [Column("PTOOptionalFlag")]
    public bool PtooptionalFlag { get; set; }

    [Column("PTOOptionalSickFlag")]
    public bool PtooptionalSickFlag { get; set; }

    [Column("PTOOptionalVacationFlag")]
    public bool PtooptionalVacationFlag { get; set; }

    [Column("PTOOptionalOtherFlag")]
    public bool PtooptionalOtherFlag { get; set; }

    public bool KeyEmployeeFlag { get; set; }

    public bool KeyEmployeeEconomicHarmFlag { get; set; }

    [StringLength(30)]
    public string? IntentToReturnToWorkRequirementInterval { get; set; }

    public string? EligibilityComments { get; set; }

    public int RowVersion { get; set; }

    [Column("FMLAContactPersonLocation")]
    [StringLength(80)]
    public string? FmlacontactPersonLocation { get; set; }

    public bool IntentToReturnToWorkRequirementIntervalFlag { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? HealthPremiumGracePeriodDays { get; set; }

    [Column("FMLAIneligibleReasonHours", TypeName = "decimal(19, 2)")]
    public decimal? FmlaineligibleReasonHours { get; set; }

    public bool AdditionalInformationCertificationAttachedFlag { get; set; }

    [StringLength(15)]
    public string? AdditionalInformationCertificationType { get; set; }

    public bool LeaveNotPaidFlag { get; set; }

    [StringLength(80)]
    public string? PaidLeaveConditions { get; set; }

    [StringLength(80)]
    public string? OtherPaidLeaveInformation { get; set; }

    [ForeignKey("PersonLeaveRequestGuid")]
    [InverseProperty("TPersonLeaveRequestEligibilities")]
    public virtual TPersonLeaveRequest PersonLeaveRequest { get; set; } = null!;

    [InverseProperty("PersonLeaveRequestEligibility")]
    public virtual ICollection<TPersonLeaveRequestEligibilityFile> TPersonLeaveRequestEligibilityFiles { get; set; } = new List<TPersonLeaveRequestEligibilityFile>();
}
