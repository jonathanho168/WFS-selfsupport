using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysGlobalConstantGroup")]
[Index("GroupName", Name = "AK_USysViewBusinessObject", IsUnique = true)]
public partial class UsysGlobalConstantGroup
{
    [Key]
    [Column("GlobalConstantGroupGUID")]
    public Guid GlobalConstantGroupGuid { get; set; }

    [StringLength(50)]
    public string GroupName { get; set; } = null!;

    public int RowVersion { get; set; }

    [InverseProperty("GlobalConstantGroup")]
    public virtual ICollection<UsysGlobalConstantGroupRecord> UsysGlobalConstantGroupRecords { get; set; } = new List<UsysGlobalConstantGroupRecord>();
}
