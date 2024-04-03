using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitEligibilityParameterHist")]
public partial class TBenefitEligibilityParameterHist
{
    [Key]
    [Column("BenefitEligibilityParameterHistGUID")]
    public Guid BenefitEligibilityParameterHistGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BenefitEligibilityParameterStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BenefitEligibilityParameterEndDate { get; set; }

    public bool BenefitEligibilityParameterCurrentFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? MinimumAge { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? MaximumAge { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? MinimumNormalHoursPerWeek { get; set; }

    public int? QualifyTime { get; set; }

    [StringLength(15)]
    public string? QualifyTimeUnit { get; set; }

    public bool FirstOfNextMonthFlag { get; set; }

    public int? HireDateIndicator { get; set; }

    public string? Comments { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public Guid BenefitPlanOptionGuid { get; set; }

    [ForeignKey("BenefitPlanOptionGuid")]
    [InverseProperty("TBenefitEligibilityParameterHists")]
    public virtual TBenefitPlanOption BenefitPlanOption { get; set; } = null!;

    [InverseProperty("BenefitEligibilityParameter")]
    public virtual ICollection<TBenefitEligibilityParameterHistCode> TBenefitEligibilityParameterHistCodes { get; set; } = new List<TBenefitEligibilityParameterHistCode>();
}
