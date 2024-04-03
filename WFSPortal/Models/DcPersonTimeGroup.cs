using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonTimeGroup")]
public partial class DcPersonTimeGroup
{
    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PositionCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonTimeGroupStartDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TimeGroupCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TimeZoneCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MultiDayEntryFlag { get; set; }
}
