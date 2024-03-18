using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDisciplineReason")]
[Index("DisciplineReasonGuid", Name = "RG_tDisciplineReason", IsUnique = true)]
public partial class TDisciplineReason
{
    [Key]
    [StringLength(15)]
    public string DisciplineReasonCode { get; set; } = null!;

    [Column("DisciplineReasonGUID")]
    public Guid DisciplineReasonGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DisciplineReasonDescription { get; set; }

    [InverseProperty("DisciplineReasonCodeNavigation")]
    public virtual ICollection<TPersonDiscipline> TPersonDisciplines { get; set; } = new List<TPersonDiscipline>();
}
