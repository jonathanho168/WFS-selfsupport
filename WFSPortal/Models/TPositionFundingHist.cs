using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPositionFundingHist")]
[Index("PositionBudgetGuid", "FundingSourceCode", "PositionFundingStartDate", Name = "AK_tPositionFundingHist", IsUnique = true)]
public partial class TPositionFundingHist
{
    [Column("PositionBudgetGUID")]
    public Guid PositionBudgetGuid { get; set; }

    [StringLength(15)]
    public string FundingSourceCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PositionFundingStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PositionFundingEndDate { get; set; }

    public bool PositionFundingCurrentFlag { get; set; }

    [StringLength(20)]
    public string ContractNumber { get; set; } = null!;

    [StringLength(80)]
    public string? PriorityFundingContact { get; set; }

    [StringLength(20)]
    public string? ContactAreaCode { get; set; }

    [StringLength(20)]
    public string? ContactPhone { get; set; }

    [Column(TypeName = "money")]
    public decimal? PositionFundingAmount { get; set; }

    [StringLength(15)]
    public string PositionFundingFrequencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? PositionFundingTotalAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RenewalDate { get; set; }

    public string? Comments { get; set; }

    [Key]
    [Column("PositionFundingGUID")]
    public Guid PositionFundingGuid { get; set; }

    [StringLength(15)]
    public string? ContactCountryCode { get; set; }

    [StringLength(20)]
    public string? ContactInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? ContactNationalPrefix { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ContactCountryCode")]
    [InverseProperty("TPositionFundingHists")]
    public virtual TCountry? ContactCountryCodeNavigation { get; set; }

    [ForeignKey("FundingSourceCode")]
    [InverseProperty("TPositionFundingHists")]
    public virtual TFundingSource FundingSourceCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionBudgetGuid")]
    [InverseProperty("TPositionFundingHists")]
    public virtual TPositionBudgetHist PositionBudget { get; set; } = null!;

    [ForeignKey("PositionFundingFrequencyCode")]
    [InverseProperty("TPositionFundingHists")]
    public virtual TFrequency PositionFundingFrequencyCodeNavigation { get; set; } = null!;
}
