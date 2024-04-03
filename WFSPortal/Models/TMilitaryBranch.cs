using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tMilitaryBranch")]
[Index("MilitaryBranchGuid", Name = "RG_tMilitaryBranch", IsUnique = true)]
public partial class TMilitaryBranch
{
    [Key]
    [StringLength(15)]
    public string MilitaryBranchCode { get; set; } = null!;

    [Column("MilitaryBranchGUID")]
    public Guid MilitaryBranchGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? MilitaryBranchDescription { get; set; }

    [InverseProperty("MilitaryBranchCodeNavigation")]
    public virtual ICollection<TPersonMilitaryHist> TPersonMilitaryHists { get; set; } = new List<TPersonMilitaryHist>();
}
