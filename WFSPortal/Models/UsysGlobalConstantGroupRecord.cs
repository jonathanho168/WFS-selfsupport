using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysGlobalConstantGroupRecord")]
public partial class UsysGlobalConstantGroupRecord
{
    [Key]
    [Column("GlobalConstantGroupRecordGUID")]
    public Guid GlobalConstantGroupRecordGuid { get; set; }

    [StringLength(100)]
    public string GlobalConstantName { get; set; } = null!;

    [StringLength(100)]
    public string PropertyName { get; set; } = null!;

    [StringLength(20)]
    public string DerivedTableAbbreviation { get; set; } = null!;

    [Column("GlobalConstantGroupGUID")]
    public Guid GlobalConstantGroupGuid { get; set; }

    public int RowVersion { get; set; }

    public bool IsNullable { get; set; }

    [ForeignKey("GlobalConstantGroupGuid")]
    [InverseProperty("UsysGlobalConstantGroupRecords")]
    public virtual UsysGlobalConstantGroup GlobalConstantGroup { get; set; } = null!;

    [ForeignKey("GlobalConstantName")]
    [InverseProperty("UsysGlobalConstantGroupRecords")]
    public virtual UsysGlobalConstant GlobalConstantNameNavigation { get; set; } = null!;
}
