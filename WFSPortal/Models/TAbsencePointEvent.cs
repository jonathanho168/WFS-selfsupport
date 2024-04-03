using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsencePointEvent")]
public partial class TAbsencePointEvent
{
    [Key]
    [Column("AbsencePointEventGUID")]
    public Guid AbsencePointEventGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EventDate { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string EventType { get; set; } = null!;

    public int RowVersion { get; set; }
}
