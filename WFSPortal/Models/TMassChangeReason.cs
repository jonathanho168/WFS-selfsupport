using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tMassChangeReason")]
[Index("MassChangeReasonGuid", Name = "RG_tMassChangeReason", IsUnique = true)]
public partial class TMassChangeReason
{
    [Key]
    [StringLength(15)]
    public string MassChangeReasonCode { get; set; } = null!;

    [Column("MassChangeReasonGUID")]
    public Guid MassChangeReasonGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? MassChangeReasonDescription { get; set; }

    [InverseProperty("MassChangeReasonCodeNavigation")]
    public virtual ICollection<TMassChange> TMassChanges { get; set; } = new List<TMassChange>();
}
