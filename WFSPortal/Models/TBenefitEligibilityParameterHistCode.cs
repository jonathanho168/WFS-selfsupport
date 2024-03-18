using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitEligibilityParameterHistCode")]
public partial class TBenefitEligibilityParameterHistCode
{
    [Column("BenefitEligibilityParameterGUID")]
    public Guid BenefitEligibilityParameterGuid { get; set; }

    [StringLength(15)]
    public string CodeType { get; set; } = null!;

    [StringLength(15)]
    public string Code { get; set; } = null!;

    [Key]
    [Column("BenefitEligibilityParameterHistCodeGUID")]
    public Guid BenefitEligibilityParameterHistCodeGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("BenefitEligibilityParameterGuid")]
    [InverseProperty("TBenefitEligibilityParameterHistCodes")]
    public virtual TBenefitEligibilityParameterHist BenefitEligibilityParameter { get; set; } = null!;
}
