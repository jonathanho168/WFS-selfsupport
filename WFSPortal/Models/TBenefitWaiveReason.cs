using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitWaiveReason")]
public partial class TBenefitWaiveReason
{
    [Column("BenefitWaiveReasonGUID")]
    public Guid BenefitWaiveReasonGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string BenefitWaiveReasonCode { get; set; } = null!;

    public string? BenefitWaiveReasonDescription { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool OptOutFlag { get; set; }

    [InverseProperty("BenefitWaiveReasonCodeNavigation")]
    public virtual ICollection<TPersonBenefitHist> TPersonBenefitHists { get; set; } = new List<TPersonBenefitHist>();

    [InverseProperty("FailedOptOutReasonCodeNavigation")]
    public virtual ICollection<TPersonBenefitOptOut> TPersonBenefitOptOuts { get; set; } = new List<TPersonBenefitOptOut>();

    [InverseProperty("BenefitWaiveReasonCodeNavigation")]
    public virtual ICollection<TPersonFutureEnrollment> TPersonFutureEnrollmentBenefitWaiveReasonCodeNavigations { get; set; } = new List<TPersonFutureEnrollment>();

    [InverseProperty("BenefitWaiveReasonCodeOriginalNavigation")]
    public virtual ICollection<TPersonFutureEnrollment> TPersonFutureEnrollmentBenefitWaiveReasonCodeOriginalNavigations { get; set; } = new List<TPersonFutureEnrollment>();
}
