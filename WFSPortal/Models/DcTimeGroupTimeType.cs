using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcTimeGroupTimeType")]
public partial class DcTimeGroupTimeType
{
    [StringLength(50)]
    [Unicode(false)]
    public string? TimeGroupCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TimeTypeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MinimumHours { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MaximumHours { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Increment { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AccumulateForOvertimeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ConvertibleToOvertimeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EmployeeEntryBlockedFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RevisedEntryBlockedFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RoundingMethod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HideAllocationFlag { get; set; }
}
