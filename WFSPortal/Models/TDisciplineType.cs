using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDisciplineType")]
[Index("DisciplineTypeGuid", Name = "RG_tDisciplineType", IsUnique = true)]
public partial class TDisciplineType
{
    [Key]
    [StringLength(15)]
    public string DisciplineTypeCode { get; set; } = null!;

    [Column("DisciplineTypeGUID")]
    public Guid DisciplineTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DisciplineTypeDescription { get; set; }

    [InverseProperty("DisciplineTypeCodeNavigation")]
    public virtual ICollection<TPersonDiscipline> TPersonDisciplines { get; set; } = new List<TPersonDiscipline>();
}
