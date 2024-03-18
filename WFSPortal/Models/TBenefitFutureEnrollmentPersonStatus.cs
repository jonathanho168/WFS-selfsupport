using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitFutureEnrollmentPersonStatus")]
[Index("BenefitFutureEnrollmentPersonStatusGuid", Name = "RG_tBenefitFutureEnrollmentPersonStatus", IsUnique = true)]
public partial class TBenefitFutureEnrollmentPersonStatus
{
    [Key]
    [StringLength(15)]
    public string BenefitFutureEnrollmentPersonStatusCode { get; set; } = null!;

    public short ProcessingOrder { get; set; }

    [Column("BenefitFutureEnrollmentPersonStatusGUID")]
    public Guid BenefitFutureEnrollmentPersonStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? BenefitFutureEnrollmentPersonStatusDescription { get; set; }

    [InverseProperty("BenefitFutureEnrollmentPersonStatusCodeNavigation")]
    public virtual ICollection<TPersonFutureEnrollmentStatus> TPersonFutureEnrollmentStatuses { get; set; } = new List<TPersonFutureEnrollmentStatus>();
}
