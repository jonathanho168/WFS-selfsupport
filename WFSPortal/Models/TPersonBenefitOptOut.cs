using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonBenefitOptOut")]
public partial class TPersonBenefitOptOut
{
    [Key]
    [Column("PersonBenefitOptOutGUID")]
    public Guid PersonBenefitOptOutGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonBenefitStartDate { get; set; }

    [StringLength(15)]
    public string StartBenefitStatusCode { get; set; } = null!;

    public Guid BenefitPlanOptionGuid { get; set; }

    public bool FailedOptOutAttemptFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FailedOptOutDate { get; set; }

    public bool AllowedToOptOutFlag { get; set; }

    [StringLength(15)]
    public string FailedOptOutReasonCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("BenefitPlanOptionGuid")]
    [InverseProperty("TPersonBenefitOptOuts")]
    public virtual TBenefitPlanOption BenefitPlanOption { get; set; } = null!;

    [ForeignKey("FailedOptOutReasonCode")]
    [InverseProperty("TPersonBenefitOptOuts")]
    public virtual TBenefitWaiveReason FailedOptOutReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonBenefitOptOuts")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("StartBenefitStatusCode")]
    [InverseProperty("TPersonBenefitOptOuts")]
    public virtual TBenefitStatus StartBenefitStatusCodeNavigation { get; set; } = null!;
}
