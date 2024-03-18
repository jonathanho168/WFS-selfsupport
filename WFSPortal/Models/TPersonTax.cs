using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonTax")]
[Index("PersonTaxGuid", Name = "RG_tPersonTax", IsUnique = true)]
public partial class TPersonTax
{
    [Key]
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(30)]
    public string FederalFilingStatus { get; set; } = null!;

    public byte? FederalTaxExemptions { get; set; }

    [Column("LivesInTaxID")]
    [StringLength(20)]
    public string? LivesInTaxId { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? RateMultiplier { get; set; }

    [StringLength(30)]
    public string? StateFilingStatus { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? StateTaxExemptions { get; set; }

    [Column("SUISDITaxCode")]
    [StringLength(15)]
    public string SuisditaxCode { get; set; } = null!;

    [Column("WorksInTaxID")]
    [StringLength(20)]
    public string? WorksInTaxId { get; set; }

    [Column("PersonTaxGUID")]
    public Guid PersonTaxGuid { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? FederalAdditionalWithholding { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? StateAdditionalWithholding { get; set; }

    [Column("SignedByPersonGUID")]
    public Guid? SignedByPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SignedDate { get; set; }

    public string? Comments { get; set; }

    public bool ExemptFlag { get; set; }

    public bool CanadianPensionPlanIndicator { get; set; }

    public bool QuebecPensionPlanIndicator { get; set; }

    [StringLength(50)]
    public string? TaxFileNumber { get; set; }

    public bool CsfAnzTaxFreeThresholdFlag { get; set; }

    [Column("CsfAnzHELPTaxFlag")]
    public bool CsfAnzHelptaxFlag { get; set; }

    [Column("CsfAnzHECSTaxFlag")]
    public bool CsfAnzHecstaxFlag { get; set; }

    [Column("CsfAnzSFSSTaxFlag")]
    public bool CsfAnzSfsstaxFlag { get; set; }

    [StringLength(15)]
    public string CsfAnzTaxCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? CsfAnzWitholdingVariation { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? FederalOtherIncomeWithholding { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? FederalDeductionsWithholding { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? FederalDependentsQualifyingChildrenAmount { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? FederalDependentsOtherDependentsAmount { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? FederalDependentsTotalAmount { get; set; }

    public bool FederalMultipleJobsFlag { get; set; }

    [ForeignKey("CsfAnzTaxCurrencyCode")]
    [InverseProperty("TPersonTaxes")]
    public virtual TCurrency CsfAnzTaxCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonTaxPerson")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("SignedByPersonGuid")]
    [InverseProperty("TPersonTaxSignedByPeople")]
    public virtual TPerson? SignedByPerson { get; set; }

    [ForeignKey("SuisditaxCode")]
    [InverseProperty("TPersonTaxes")]
    public virtual TSuisditax SuisditaxCodeNavigation { get; set; } = null!;
}
