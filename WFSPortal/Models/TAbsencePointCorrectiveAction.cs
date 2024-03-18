using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsencePointCorrectiveAction")]
public partial class TAbsencePointCorrectiveAction
{
    [Column("AbsencePointCorrectiveActionGUID")]
    public Guid AbsencePointCorrectiveActionGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string AbsencePointCorrectiveActionCode { get; set; } = null!;

    public string? AbsencePointCorrectiveActionDescription { get; set; }

    public bool InactiveFlag { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? AbsencePointCorrectiveActionLimit { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? AbsencePointTotalforCorrectiveAction { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("AbsencePointCorrectiveActionCodeNavigation")]
    public virtual ICollection<TPersonAbsencePoint> TPersonAbsencePoints { get; set; } = new List<TPersonAbsencePoint>();
}
