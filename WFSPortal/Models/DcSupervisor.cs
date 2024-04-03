using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcSupervisor")]
public partial class DcSupervisor
{
    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [Column("positioncode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Positioncode { get; set; }

    [Column("Job Eff Date", TypeName = "datetime")]
    public DateTime? JobEffDate { get; set; }

    [Column("postionend", TypeName = "datetime")]
    public DateTime? Postionend { get; set; }

    [Column("locreason")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Locreason { get; set; }

    [Column("compcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Compcode { get; set; }

    [Column("hc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Hc { get; set; }

    [Column("hd")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Hd { get; set; }

    [Column("division")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Division { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FuncArea { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LocCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrgUnitCode { get; set; }

    [Column("projectCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SectionCode { get; set; }

    [Column("shiftcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Shiftcode { get; set; }

    [Column("supSSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SupSsn { get; set; }
}
