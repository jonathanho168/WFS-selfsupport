using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonApplicationFactTable
{
    [Column("PersonApplicationGUID")]
    public Guid PersonApplicationGuid { get; set; }

    [Column("PersonApplicationEvaluationGUID")]
    public Guid? PersonApplicationEvaluationGuid { get; set; }

    [Column("ApplicationID")]
    public int? ApplicationId { get; set; }

    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ApplicationDate { get; set; }

    public int? ApplicationYear { get; set; }

    public int? ApplicationQuarter { get; set; }

    public int? ApplicationMonth { get; set; }

    [StringLength(15)]
    public string? ApplicationStatusCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApplicationStatusDate { get; set; }

    public int? ApplicationStatusYear { get; set; }

    public int? ApplicationStatusQuarter { get; set; }

    public int? ApplicationStatusMonth { get; set; }

    [StringLength(15)]
    public string RequisitionCode { get; set; } = null!;

    [StringLength(15)]
    public string ReferralSourceCode { get; set; } = null!;

    [StringLength(15)]
    public string? ExternalRecruiterCode { get; set; }

    [Column("InternalRecruiterPersonGUID")]
    public Guid? InternalRecruiterPersonGuid { get; set; }

    [StringLength(125)]
    public string? InternalRecruiter { get; set; }

    public bool? OpenFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PostingDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CloseDate { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal ApplicationCost { get; set; }

    public int ApplicationAgeInDays { get; set; }
}
