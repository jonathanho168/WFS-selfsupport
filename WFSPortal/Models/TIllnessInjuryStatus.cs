using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tIllnessInjuryStatus")]
[Index("IllnessInjuryStatusGuid", Name = "RG_tIllnessInjuryStatus", IsUnique = true)]
public partial class TIllnessInjuryStatus
{
    [Key]
    [StringLength(15)]
    public string IllnessInjuryStatusCode { get; set; } = null!;

    [Column("IllnessInjuryStatusGUID")]
    public Guid IllnessInjuryStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? IllnessInjuryStatusDescription { get; set; }

    [InverseProperty("IllnessInjuryStatusCodeNavigation")]
    public virtual ICollection<TPersonIncident> TPersonIncidents { get; set; } = new List<TPersonIncident>();
}
