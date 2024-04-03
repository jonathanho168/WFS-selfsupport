using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitType")]
[Index("BenefitTypeGuid", Name = "RG_tBenefitType", IsUnique = true)]
public partial class TBenefitType
{
    [Key]
    [StringLength(15)]
    public string BenefitTypeCode { get; set; } = null!;

    public int SortOrder { get; set; }

    [Column("BenefitTypeGUID")]
    public Guid BenefitTypeGuid { get; set; }

    public bool SinglePlanEnrollmentFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Required]
    [Column("ShowFlexAmountsInOE")]
    public bool? ShowFlexAmountsInOe { get; set; }

    [Required]
    [Column("ShowImputedAmountsInOE")]
    public bool? ShowImputedAmountsInOe { get; set; }

    [Required]
    [Column("ShowCoverageAmountsInOE")]
    public bool? ShowCoverageAmountsInOe { get; set; }

    [Column("ShowEmployerContributionAmountsInOE")]
    public bool ShowEmployerContributionAmountsInOe { get; set; }

    [Column("ShowEmployeeContributionAmountsInOE")]
    public bool ShowEmployeeContributionAmountsInOe { get; set; }

    public bool ShowPreTaxContributionAmountsFlag { get; set; }

    public bool ShowPostTaxContributionAmountsFlag { get; set; }

    public bool RequiresEnrollmentFlag { get; set; }

    [Column("ShowPremiumAmountsInOE")]
    public bool ShowPremiumAmountsInOe { get; set; }

    public string? BenefitTypeDescription { get; set; }

    [InverseProperty("BenefitTypeCodeNavigation")]
    public virtual ICollection<TBenefitPlan> TBenefitPlans { get; set; } = new List<TBenefitPlan>();
}
