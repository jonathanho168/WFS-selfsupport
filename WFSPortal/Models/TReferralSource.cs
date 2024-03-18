using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tReferralSource")]
[Index("ReferralSourceGuid", Name = "RG_tReferralSource", IsUnique = true)]
public partial class TReferralSource
{
    [Key]
    [StringLength(15)]
    public string ReferralSourceCode { get; set; } = null!;

    [Column("ReferralSourceGUID")]
    public Guid ReferralSourceGuid { get; set; }

    public bool EmployeeReferralFlag { get; set; }

    public bool RecruitingFirmReferralFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? ReferralSourceDescription { get; set; }

    [InverseProperty("ReferralSourceCodeNavigation")]
    public virtual ICollection<TPersonApplication> TPersonApplications { get; set; } = new List<TPersonApplication>();
}
