using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tMilitaryConflict")]
[Index("MilitaryConflictGuid", Name = "RG_tMilitaryConflict", IsUnique = true)]
public partial class TMilitaryConflict
{
    [Key]
    [StringLength(15)]
    public string MilitaryConflictCode { get; set; } = null!;

    [Column("MilitaryConflictGUID")]
    public Guid MilitaryConflictGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? MilitaryConflictDescription { get; set; }

    [InverseProperty("MilitaryConflictCodeNavigation")]
    public virtual ICollection<TPersonMilitaryHist> TPersonMilitaryHists { get; set; } = new List<TPersonMilitaryHist>();
}
