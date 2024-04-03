using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBodyPart")]
[Index("BodyPartGuid", Name = "RG_tBodyPart", IsUnique = true)]
public partial class TBodyPart
{
    [Key]
    [StringLength(15)]
    public string BodyPartCode { get; set; } = null!;

    [Column("BodyPartGUID")]
    public Guid BodyPartGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? BodyPartDescription { get; set; }

    [InverseProperty("BodyPartCodeNavigation")]
    public virtual ICollection<TPersonIncidentBodyPart> TPersonIncidentBodyParts { get; set; } = new List<TPersonIncidentBodyPart>();
}
