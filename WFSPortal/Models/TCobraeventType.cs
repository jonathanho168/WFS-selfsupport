using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCOBRAEventType")]
[Index("CobraeventTypeGuid", Name = "RG_tCOBRAEventType", IsUnique = true)]
public partial class TCobraeventType
{
    [Key]
    [Column("COBRAEventTypeCode")]
    [StringLength(15)]
    public string CobraeventTypeCode { get; set; } = null!;

    [Column("COBRAEventTypeGUID")]
    public Guid CobraeventTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Column("COBRAEventTypeDescription")]
    public string? CobraeventTypeDescription { get; set; }

    [InverseProperty("CobraeventTypeCodeNavigation")]
    public virtual ICollection<TCobraevent> TCobraevents { get; set; } = new List<TCobraevent>();
}
