using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VrptArchiveAbsence
{
    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [StringLength(15)]
    public string ReasonCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Duration { get; set; }

    public bool ExcusedFlag { get; set; }

    [Column("FMLAFlag")]
    public bool Fmlaflag { get; set; }

    public bool PaidFlag { get; set; }

    public string? Comments { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public bool MilitaryCaregiverFlag { get; set; }

    [StringLength(15)]
    public string TransactionTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string? LeaveTypeCode { get; set; }

    [StringLength(15)]
    public string PlanCode { get; set; } = null!;

    public string? PlanDescription { get; set; }

    [Column("EmployeeID")]
    [StringLength(24)]
    public string? EmployeeId { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(30)]
    public string LastName { get; set; } = null!;
}
