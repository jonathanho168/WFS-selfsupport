using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapRequisitionFactTable
{
    [StringLength(15)]
    public string RequisitionCode { get; set; } = null!;

    [StringLength(15)]
    public string ExternalRecruiterCode { get; set; } = null!;

    [Column("InternalRecruiterPersonGUID")]
    public Guid? InternalRecruiterPersonGuid { get; set; }

    [StringLength(125)]
    public string? InternalRecruiter { get; set; }

    public bool? OpenFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PostingDate { get; set; }

    public int? PostingYear { get; set; }

    public int? PostingQuarter { get; set; }

    public int? PostingMonth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CloseDate { get; set; }

    public int? ClosedYear { get; set; }

    public int? ClosedQuarter { get; set; }

    public int? ClosedMonth { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal RequisitionCost { get; set; }

    public int RequisitionAgeInDays { get; set; }
}
