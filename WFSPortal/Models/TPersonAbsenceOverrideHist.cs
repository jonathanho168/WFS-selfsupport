using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonAbsenceOverrideHist")]
public partial class TPersonAbsenceOverrideHist
{
    [Key]
    [Column("PersonAbsenceOverrideGUID")]
    public Guid PersonAbsenceOverrideGuid { get; set; }

    public Guid PersonAbsencePlanGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonAbsenceOverrideStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonAbsenceOverrideEndDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal OverrideAccrualRate { get; set; }

    public bool PersonAbsenceOverrideCurrentFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("PersonAbsencePlanGuid")]
    [InverseProperty("TPersonAbsenceOverrideHists")]
    public virtual TPersonAbsencePlan PersonAbsencePlan { get; set; } = null!;
}
