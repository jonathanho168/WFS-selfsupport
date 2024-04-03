using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tIllnessInjury")]
[Index("IllnessInjuryGuid", Name = "RG_tIllnessInjury", IsUnique = true)]
public partial class TIllnessInjury
{
    [Key]
    [StringLength(15)]
    public string IllnessInjuryCode { get; set; } = null!;

    public bool InjuryFlag { get; set; }

    [Column("IllnessInjuryGUID")]
    public Guid IllnessInjuryGuid { get; set; }

    [StringLength(15)]
    public string IllnessTypeCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? IllnessInjuryDescription { get; set; }

    [ForeignKey("IllnessTypeCode")]
    [InverseProperty("TIllnessInjuries")]
    public virtual TIllnessType IllnessTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("IllnessInjuryCodeNavigation")]
    public virtual ICollection<TPersonIncidentBodyPart> TPersonIncidentBodyParts { get; set; } = new List<TPersonIncidentBodyPart>();

    [InverseProperty("IllnessInjuryCodeNavigation")]
    public virtual ICollection<TPersonIncident> TPersonIncidents { get; set; } = new List<TPersonIncident>();
}
