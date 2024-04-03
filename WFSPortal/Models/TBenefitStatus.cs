using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitStatus")]
[Index("BenefitStatusGuid", Name = "RG_tBenefitStatus", IsUnique = true)]
public partial class TBenefitStatus
{
    [Key]
    [StringLength(15)]
    public string BenefitStatusCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("BenefitStatusGUID")]
    public Guid BenefitStatusGuid { get; set; }

    public int RowVersion { get; set; }

    public bool ActiveEnrollment { get; set; }

    public string? BenefitStatusDescription { get; set; }

    [InverseProperty("AutoEnrollmentStartStatusCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHists { get; set; } = new List<TBenefitHist>();

    [InverseProperty("StartBenefitStatusCodeNavigation")]
    public virtual ICollection<TBenefitPlanOptionAutoEnroll> TBenefitPlanOptionAutoEnrolls { get; set; } = new List<TBenefitPlanOptionAutoEnroll>();

    [InverseProperty("EndBenefitStatusCodeNavigation")]
    public virtual ICollection<TPersonBenefitHist> TPersonBenefitHistEndBenefitStatusCodeNavigations { get; set; } = new List<TPersonBenefitHist>();

    [InverseProperty("StartBenefitStatusCodeNavigation")]
    public virtual ICollection<TPersonBenefitHist> TPersonBenefitHistStartBenefitStatusCodeNavigations { get; set; } = new List<TPersonBenefitHist>();

    [InverseProperty("StartBenefitStatusCodeNavigation")]
    public virtual ICollection<TPersonBenefitOptOut> TPersonBenefitOptOuts { get; set; } = new List<TPersonBenefitOptOut>();

    [InverseProperty("EndBenefitStatusCodeNavigation")]
    public virtual ICollection<TPersonFutureEnrollment> TPersonFutureEnrollmentEndBenefitStatusCodeNavigations { get; set; } = new List<TPersonFutureEnrollment>();

    [InverseProperty("StartBenefitStatusCodeNavigation")]
    public virtual ICollection<TPersonFutureEnrollment> TPersonFutureEnrollmentStartBenefitStatusCodeNavigations { get; set; } = new List<TPersonFutureEnrollment>();
}
