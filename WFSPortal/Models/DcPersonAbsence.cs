using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonAbsence")]
public partial class DcPersonAbsence
{
    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AbsencePlanCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? BalanceAsOfStartDate { get; set; }

    [Column("Start Date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }
}
