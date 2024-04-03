using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonIncidentBodyPart")]
[Index("PersonIncidentGuid", "IllnessInjuryCode", "BodyPartCode", Name = "AK_tPersonIncidentBodyPart", IsUnique = true)]
public partial class TPersonIncidentBodyPart
{
    [Key]
    [Column("PersonIncidentBodyPartGUID")]
    public Guid PersonIncidentBodyPartGuid { get; set; }

    [Column("PersonIncidentGUID")]
    public Guid PersonIncidentGuid { get; set; }

    [StringLength(15)]
    public string BodyPartCode { get; set; } = null!;

    [StringLength(15)]
    public string IllnessInjuryCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("BodyPartCode")]
    [InverseProperty("TPersonIncidentBodyParts")]
    public virtual TBodyPart BodyPartCodeNavigation { get; set; } = null!;

    [ForeignKey("IllnessInjuryCode")]
    [InverseProperty("TPersonIncidentBodyParts")]
    public virtual TIllnessInjury IllnessInjuryCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonIncidentGuid")]
    [InverseProperty("TPersonIncidentBodyParts")]
    public virtual TPersonIncident PersonIncident { get; set; } = null!;
}
