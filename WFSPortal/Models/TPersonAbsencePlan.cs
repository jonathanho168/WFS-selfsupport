using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonAbsencePlan")]
[Index("PersonGuid", "AbsencePlanCode", "StartDate", Name = "AK_tPersonAbsencePlan", IsUnique = true)]
public partial class TPersonAbsencePlan
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string AbsencePlanCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AccruedDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal AccruedYearToDateValue { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal BeginBalance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Key]
    [Column("PersonAbsencePlanGUID")]
    public Guid PersonAbsencePlanGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime YearBeginDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime YearEndDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? YearBeginBalance { get; set; }

    public bool PersonAbsencePlanCurrentFlag { get; set; }

    [ForeignKey("AbsencePlanCode")]
    [InverseProperty("TPersonAbsencePlans")]
    public virtual TAbsencePlan AbsencePlanCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonAbsencePlans")]
    public virtual TPerson Person { get; set; } = null!;

    [InverseProperty("PersonAbsencePlan")]
    public virtual ICollection<TPersonAbsenceHist> TPersonAbsenceHists { get; set; } = new List<TPersonAbsenceHist>();

    [InverseProperty("PersonAbsencePlan")]
    public virtual ICollection<TPersonAbsenceOverrideHist> TPersonAbsenceOverrideHists { get; set; } = new List<TPersonAbsenceOverrideHist>();
}
