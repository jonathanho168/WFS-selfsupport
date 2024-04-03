using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysEntityGroup")]
[Index("EntityGroupGuid", Name = "RG_USysEntityGroup", IsUnique = true)]
public partial class UsysEntityGroup
{
    [Key]
    [StringLength(15)]
    public string EntityGroupCode { get; set; } = null!;

    [StringLength(80)]
    public string EntityGroupDescription { get; set; } = null!;

    [Column("EntityGroupGUID")]
    public Guid EntityGroupGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public int? SortOrder { get; set; }

    [InverseProperty("EntityGroupCodeNavigation")]
    public virtual ICollection<UsysEntity> UsysEntities { get; set; } = new List<UsysEntity>();
}
