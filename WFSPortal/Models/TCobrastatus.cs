using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCOBRAStatus")]
[Index("CobrastatusGuid", Name = "RG_tCOBRAStatus", IsUnique = true)]
public partial class TCobrastatus
{
    [Key]
    [Column("COBRAStatusCode")]
    [StringLength(15)]
    public string CobrastatusCode { get; set; } = null!;

    [Column("COBRAStatusGUID")]
    public Guid CobrastatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Column("COBRAStatusDescription")]
    public string? CobrastatusDescription { get; set; }

    [InverseProperty("CobrastatusCodeNavigation")]
    public virtual ICollection<TPersonCobra> TPersonCobras { get; set; } = new List<TPersonCobra>();
}
