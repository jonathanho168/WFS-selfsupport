using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysSalaryPlanOtherPayPersonDetail")]
public partial class UsysSalaryPlanOtherPayPersonDetail
{
    [Key]
    [Column("SalaryPlanOtherPayPersonDetailGUID")]
    public Guid SalaryPlanOtherPayPersonDetailGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PersonOtherPayStartDate { get; set; }

    [StringLength(15)]
    public string PersonOtherPayReasonCode { get; set; } = null!;

    [StringLength(15)]
    public string PersonOtherPayChangeAmountFrequencyCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PersonOtherPayChangeAmount { get; set; }

    [StringLength(15)]
    public string PersonOtherPayFrequencyCode { get; set; } = null!;

    [Column("SalaryPlanPersonGUID")]
    public Guid SalaryPlanPersonGuid { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PercentageChange { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonOtherPayEndDate { get; set; }

    [StringLength(15)]
    public string PersonOtherPayTypeCode { get; set; } = null!;

    public string? OtherPayJustification { get; set; }

    [ForeignKey("PersonOtherPayChangeAmountFrequencyCode")]
    [InverseProperty("UsysSalaryPlanOtherPayPersonDetailPersonOtherPayChangeAmountFrequencyCodeNavigations")]
    public virtual TFrequency PersonOtherPayChangeAmountFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonOtherPayFrequencyCode")]
    [InverseProperty("UsysSalaryPlanOtherPayPersonDetailPersonOtherPayFrequencyCodeNavigations")]
    public virtual TFrequency PersonOtherPayFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonOtherPayReasonCode")]
    [InverseProperty("UsysSalaryPlanOtherPayPersonDetails")]
    public virtual TOtherPayReason PersonOtherPayReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonOtherPayTypeCode")]
    [InverseProperty("UsysSalaryPlanOtherPayPersonDetails")]
    public virtual TOtherPayType PersonOtherPayTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("UsysSalaryPlanOtherPayPersonDetails")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("SalaryPlanPersonGuid")]
    [InverseProperty("UsysSalaryPlanOtherPayPersonDetails")]
    public virtual UsysSalaryPlanPerson SalaryPlanPerson { get; set; } = null!;
}
