using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitStatementParameters")]
[Index("StatementYear", Name = "AK_tBenefitStatementParameters", IsUnique = true)]
public partial class TBenefitStatementParameter
{
    public int? StatementYear { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SalaryDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? SocialSecurityCalculationFactor { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? SocialSecurityMaximum { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? MedicareCalculationFactor { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? MedicareMaximum { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? FederalUnemploymentCalculationFactor { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? FederalUnemploymentMaximum { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? StateUnemploymentCalculationFactor { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? StateUnemploymentMaximum { get; set; }

    [Key]
    [Column("BenefitStatementParametersGUID")]
    public Guid BenefitStatementParametersGuid { get; set; }

    public int RowVersion { get; set; }
}
