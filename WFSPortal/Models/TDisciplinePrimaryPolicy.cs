using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDisciplinePrimaryPolicy")]
[Index("DisciplinePrimaryPolicyGuid", Name = "RG_tDisciplinePrimaryPolicy", IsUnique = true)]
public partial class TDisciplinePrimaryPolicy
{
    [Key]
    [StringLength(15)]
    public string DisciplinePrimaryPolicyCode { get; set; } = null!;

    [Column("DisciplinePrimaryPolicyGUID")]
    public Guid DisciplinePrimaryPolicyGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DisciplinePrimaryPolicyDescription { get; set; }

    [InverseProperty("DisciplinePrimaryPolicyCodeNavigation")]
    public virtual ICollection<TPersonDiscipline> TPersonDisciplines { get; set; } = new List<TPersonDiscipline>();
}
