using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonTermination")]
public partial class TPersonTermination
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveDate { get; set; }

    public short? AgeAtTermination { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AutoNotificationsSentDate { get; set; }

    [Column("CheckListVerifiedByPersonGUID")]
    public Guid? CheckListVerifiedByPersonGuid { get; set; }

    public bool EligibleForRehireFlag { get; set; }

    public string? ExitInterviewComments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExitInterviewDateTime { get; set; }

    [Column("ExitInterviewerPersonGUID")]
    public Guid? ExitInterviewerPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinalCheckReadyDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastWorkDate { get; set; }

    [StringLength(80)]
    public string? NextEmployerName { get; set; }

    [StringLength(80)]
    public string? NextEmployerLocation { get; set; }

    [StringLength(80)]
    public string? NextEmployerPosition { get; set; }

    [StringLength(15)]
    public string NextEmployerSalaryCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? NextEmployerSalaryAmount { get; set; }

    [StringLength(15)]
    public string NextEmployerSalaryFrequencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? NoticeGivenDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecallRightsExpireDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ServiceAtTermination { get; set; }

    [StringLength(15)]
    public string SeverancePayCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? SeverancePayAmount { get; set; }

    [StringLength(80)]
    public string? SeverancePayDescription { get; set; }

    [StringLength(15)]
    public string TerminationReasonCode { get; set; } = null!;

    public string? TerminationReasonComments { get; set; }

    [StringLength(15)]
    public string TerminationTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string UnusedVacationPayCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? UnusedVacationPayAmount { get; set; }

    [Key]
    [Column("PersonTerminationGUID")]
    public Guid PersonTerminationGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [Required]
    public bool? RecommendForRehire { get; set; }

    public string? PropertyComments { get; set; }

    public bool? EmployeeSupervision { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TerminationNoticeDate { get; set; }

    public byte[]? TerminationNoticeDocument { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpectedRecallDate { get; set; }

    public bool RecallUnknownFlag { get; set; }

    public bool NotReturningFlag { get; set; }

    [ForeignKey("CheckListVerifiedByPersonGuid")]
    [InverseProperty("TPersonTerminationCheckListVerifiedByPeople")]
    public virtual TPerson? CheckListVerifiedByPerson { get; set; }

    [ForeignKey("ExitInterviewerPersonGuid")]
    [InverseProperty("TPersonTerminationExitInterviewerPeople")]
    public virtual TPerson? ExitInterviewerPerson { get; set; }

    [ForeignKey("NextEmployerSalaryCurrencyCode")]
    [InverseProperty("TPersonTerminationNextEmployerSalaryCurrencyCodeNavigations")]
    public virtual TCurrency NextEmployerSalaryCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("NextEmployerSalaryFrequencyCode")]
    [InverseProperty("TPersonTerminations")]
    public virtual TFrequency NextEmployerSalaryFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonTerminationPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("SeverancePayCurrencyCode")]
    [InverseProperty("TPersonTerminationSeverancePayCurrencyCodeNavigations")]
    public virtual TCurrency SeverancePayCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("TerminationReasonCode")]
    [InverseProperty("TPersonTerminations")]
    public virtual TTerminationReason TerminationReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("TerminationTypeCode")]
    [InverseProperty("TPersonTerminations")]
    public virtual TTerminationType TerminationTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("UnusedVacationPayCurrencyCode")]
    [InverseProperty("TPersonTerminationUnusedVacationPayCurrencyCodeNavigations")]
    public virtual TCurrency UnusedVacationPayCurrencyCodeNavigation { get; set; } = null!;
}
