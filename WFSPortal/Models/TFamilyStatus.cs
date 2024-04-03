using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tFamilyStatus")]
[Index("FamilyStatusGuid", Name = "RG_tFamilyStatus", IsUnique = true)]
public partial class TFamilyStatus
{
    [Key]
    [StringLength(15)]
    public string FamilyStatusCode { get; set; } = null!;

    [Column("FamilyStatusGUID")]
    public Guid FamilyStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? FamilyStatusDescription { get; set; }

    [InverseProperty("FamilyStatusCodeNavigation")]
    public virtual ICollection<TPersonal> TPersonals { get; set; } = new List<TPersonal>();
}
