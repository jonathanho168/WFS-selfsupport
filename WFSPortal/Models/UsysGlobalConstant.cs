using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysGlobalConstant")]
[Index("GlobalConstantGuid", Name = "RG_USysGlobalConstant", IsUnique = true)]
public partial class UsysGlobalConstant
{
    [Key]
    [StringLength(100)]
    public string GlobalConstantName { get; set; } = null!;

    public string? GlobalConstantValue { get; set; }

    [Column("GlobalConstantGUID")]
    public Guid GlobalConstantGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(50)]
    public string UnderlyingDataType { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public int LicenseFlags { get; set; }

    public string? FriendlyName { get; set; }

    [InverseProperty("GlobalConstantNameNavigation")]
    public virtual ICollection<UsysGlobalConstantGroupRecord> UsysGlobalConstantGroupRecords { get; set; } = new List<UsysGlobalConstantGroupRecord>();
}
