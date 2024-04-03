using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitRangeHist")]
[Index("BenefitPlanOptionGuid", "BenefitRangeType", "BenefitRangeStartDate", Name = "AK_tBenefitRangeHist", IsUnique = true)]
public partial class TBenefitRangeHist
{
    [Key]
    [Column("BenefitRangeGUID")]
    public Guid BenefitRangeGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BenefitRangeStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BenefitRangeEndDate { get; set; }

    public bool BenefitRangeCurrentFlag { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string BenefitRangeType { get; set; } = null!;

    public Guid BenefitPlanOptionGuid { get; set; }

    [ForeignKey("BenefitPlanOptionGuid")]
    [InverseProperty("TBenefitRangeHists")]
    public virtual TBenefitPlanOption BenefitPlanOption { get; set; } = null!;

    [InverseProperty("BenefitRange")]
    public virtual ICollection<TBenefitRangeValue> TBenefitRangeValues { get; set; } = new List<TBenefitRangeValue>();
}
