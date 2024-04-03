using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoleFlag")]
public partial class UsysRoleFlag
{
    [Key]
    [Column("RoleFlagGUID")]
    public Guid RoleFlagGuid { get; set; }

    [Column("RoleGUID")]
    public Guid RoleGuid { get; set; }

    [Column("FlagGUID")]
    public Guid FlagGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("FlagGuid")]
    [InverseProperty("UsysRoleFlags")]
    public virtual UsysFlag Flag { get; set; } = null!;

    [ForeignKey("RoleGuid")]
    [InverseProperty("UsysRoleFlags")]
    public virtual UsysRole Role { get; set; } = null!;
}
