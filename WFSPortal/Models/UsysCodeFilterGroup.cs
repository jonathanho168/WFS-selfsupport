using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCodeFilterGroup")]
[Index("CodeFilterGroupGuid", Name = "RG_USysCodeFilterGroup", IsUnique = true)]
public partial class UsysCodeFilterGroup
{
    [Key]
    [StringLength(15)]
    public string CodeFilterGroupCode { get; set; } = null!;

    [Column("CodeFilterGroupGUID")]
    public Guid? CodeFilterGroupGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? CodeFilterGroupDescription { get; set; }

    [InverseProperty("CodeFilterGroupCodeNavigation")]
    public virtual ICollection<UsysCodeFilterTable> UsysCodeFilterTables { get; set; } = new List<UsysCodeFilterTable>();

    [InverseProperty("CodeFilterGroupCodeNavigation")]
    public virtual ICollection<UsysRoleCodeFilterGroup> UsysRoleCodeFilterGroups { get; set; } = new List<UsysRoleCodeFilterGroup>();
}
