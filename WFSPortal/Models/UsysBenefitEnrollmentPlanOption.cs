using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysBenefitEnrollmentPlanOption")]
public partial class UsysBenefitEnrollmentPlanOption
{
    [StringLength(128)]
    public string UserName { get; set; } = null!;

    public Guid BenefitPlanOptionGuid { get; set; }

    [StringLength(128)]
    public string ContributionProcedure { get; set; } = null!;

    [StringLength(15)]
    public string DependentTypeCode { get; set; } = null!;

    [StringLength(128)]
    public string EligibilityProcedure { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ProcessDateTime { get; set; }

    [Key]
    [Column("BenefitEnrollmentPlanOptionGUID")]
    public Guid BenefitEnrollmentPlanOptionGuid { get; set; }

    public int RowVersion { get; set; }

    public byte? DependentMaximumAge { get; set; }
}
