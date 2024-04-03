using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitFutureEnrollmentStatus")]
[Index("BenefitFutureEnrollmentStatusGuid", Name = "RG_tBenefitFutureEnrollmentStatus", IsUnique = true)]
public partial class TBenefitFutureEnrollmentStatus
{
    [Key]
    [StringLength(15)]
    public string BenefitFutureEnrollmentStatusCode { get; set; } = null!;

    public bool ApprovedFlag { get; set; }

    [Column("BenefitFutureEnrollmentStatusGUID")]
    public Guid BenefitFutureEnrollmentStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? BenefitFutureEnrollmentStatusDescription { get; set; }

    [InverseProperty("BenefitFutureEnrollmentStatusCodeNavigation")]
    public virtual ICollection<TPersonFutureEnrollment> TPersonFutureEnrollments { get; set; } = new List<TPersonFutureEnrollment>();
}
