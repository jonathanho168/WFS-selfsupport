using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonAbsencePlanFactTable
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    [StringLength(15)]
    public string AbsencePlanCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    public int? StartYear { get; set; }

    public int? StartQuarter { get; set; }

    public int? StartMonth { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal BeginBalance { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal AccruedYearToDateValue { get; set; }

    [Column("TakenYTD", TypeName = "decimal(38, 4)")]
    public decimal TakenYtd { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal AbsenceBalance { get; set; }
}
