using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDisciplineAction")]
[Index("DisciplineActionGuid", Name = "RG_tDisciplineAction", IsUnique = true)]
public partial class TDisciplineAction
{
    [Key]
    [StringLength(15)]
    public string DisciplineActionCode { get; set; } = null!;

    [Column("DisciplineActionGUID")]
    public Guid DisciplineActionGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DisciplineActionDescription { get; set; }

    [InverseProperty("DisciplineActionCodeNavigation")]
    public virtual ICollection<TPersonDiscipline> TPersonDisciplines { get; set; } = new List<TPersonDiscipline>();
}
