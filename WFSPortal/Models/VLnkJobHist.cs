using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkJobHist
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonJobStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonJobEndDate { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [StringLength(15)]
    public string? AlternateJobCode { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EvaluationPoints { get; set; }

    [Column("EEOCategoryCode")]
    [StringLength(15)]
    public string EeocategoryCode { get; set; } = null!;

    [StringLength(15)]
    public string JobCategoryCode { get; set; } = null!;

    [StringLength(15)]
    public string JobFamilyCode { get; set; } = null!;

    [StringLength(15)]
    public string JobGroupCode { get; set; } = null!;

    [StringLength(15)]
    public string OvertimeStatusCode { get; set; } = null!;

    [StringLength(15)]
    public string GradeCode { get; set; } = null!;

    [StringLength(15)]
    public string WorkersCompensationCode { get; set; } = null!;

    [StringLength(15)]
    public string JobReportsToJobCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("JobGUID")]
    public Guid JobGuid { get; set; }

    [StringLength(15)]
    public string OrgPublisherPositionTypeCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public string? JobTitle { get; set; }

    [Column("EEACategoryCode")]
    [StringLength(15)]
    public string EeacategoryCode { get; set; } = null!;

    [StringLength(15)]
    public string? JobTimeGroupCode { get; set; }
}
