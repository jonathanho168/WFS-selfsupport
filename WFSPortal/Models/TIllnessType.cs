using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tIllnessType")]
[Index("IllnessTypeGuid", Name = "RG_tIllnessType", IsUnique = true)]
public partial class TIllnessType
{
    [Key]
    [StringLength(15)]
    public string IllnessTypeCode { get; set; } = null!;

    [Column("IllnessTypeGUID")]
    public Guid IllnessTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? IllnessTypeDescription { get; set; }

    [InverseProperty("IllnessTypeCodeNavigation")]
    public virtual ICollection<TIllnessInjury> TIllnessInjuries { get; set; } = new List<TIllnessInjury>();
}
