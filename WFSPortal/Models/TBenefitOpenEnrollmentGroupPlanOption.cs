using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitOpenEnrollmentGroupPlanOption")]
public partial class TBenefitOpenEnrollmentGroupPlanOption
{
    [StringLength(15)]
    public string BenefitOpenEnrollmentGroupCode { get; set; } = null!;

    [Key]
    [Column("BenefitOpenEnrollmentGroupPlanOptionGUID")]
    public Guid BenefitOpenEnrollmentGroupPlanOptionGuid { get; set; }

    public int RowVersion { get; set; }

    public Guid BenefitPlanOptionGuid { get; set; }

    [ForeignKey("BenefitOpenEnrollmentGroupCode")]
    [InverseProperty("TBenefitOpenEnrollmentGroupPlanOptions")]
    public virtual TBenefitOpenEnrollmentGroup BenefitOpenEnrollmentGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("BenefitPlanOptionGuid")]
    [InverseProperty("TBenefitOpenEnrollmentGroupPlanOptions")]
    public virtual TBenefitPlanOption BenefitPlanOption { get; set; } = null!;
}
