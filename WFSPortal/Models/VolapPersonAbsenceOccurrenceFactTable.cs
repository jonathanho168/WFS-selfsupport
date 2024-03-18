using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonAbsenceOccurrenceFactTable
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string? AbsencePlanCode { get; set; }

    [StringLength(15)]
    public string AbsenceTransactionTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AbsenceStartDate { get; set; }

    public int? AbsenceStartYear { get; set; }

    public int? AbsenceStartQuarter { get; set; }

    public int? AbsenceStartMonth { get; set; }

    public int? AbsenceStartDay { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AbsenceEndDate { get; set; }

    [StringLength(15)]
    public string AbsenceReasonCode { get; set; } = null!;

    public bool PaidFlag { get; set; }

    public bool ExcusedFlag { get; set; }

    [Column("FMLAFlag")]
    public bool Fmlaflag { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column(TypeName = "numeric(38, 6)")]
    public decimal? Cost { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal AbsenceDuration { get; set; }
}
