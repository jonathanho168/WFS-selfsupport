using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysUserRole")]
public partial class UsysUserRole
{
    [Key]
    [Column("UserRoleGUID")]
    public Guid UserRoleGuid { get; set; }

    [Column("UserGUID")]
    public Guid UserGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("RoleGUID")]
    public Guid RoleGuid { get; set; }

    [ForeignKey("RoleGuid")]
    [InverseProperty("UsysUserRoles")]
    public virtual UsysRole Role { get; set; } = null!;

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysUserRoles")]
    public virtual UsysUser User { get; set; } = null!;
}
