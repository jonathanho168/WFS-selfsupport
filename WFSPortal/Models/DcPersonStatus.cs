using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonStatus")]
public partial class DcPersonStatus
{
    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonStatusStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonStatusEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AdjustedHireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LatestHireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OriginalHireDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NormalHoursPerWeek { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SeniorityDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HireSourceCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatusReasonCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatusCategoryCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatusCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WesleyCalendarCode { get; set; }
}
