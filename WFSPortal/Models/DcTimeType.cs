using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcTimeTypes")]
public partial class DcTimeType
{
    [StringLength(50)]
    [Unicode(false)]
    public string? TimeTypeCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? TimeTypeDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaidFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExcusedFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AbsencePlanCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TimeWorkedFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HolidayFlag { get; set; }

    [Column("OTZeroRate")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OtzeroRate { get; set; }
}
