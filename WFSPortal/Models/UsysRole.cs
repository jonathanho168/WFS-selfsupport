using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRole")]
public partial class UsysRole
{
    [StringLength(50)]
    public string RoleName { get; set; } = null!;

    [Key]
    [Column("RoleGUID")]
    public Guid RoleGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public bool IsCodeFilterRole { get; set; }

    [InverseProperty("Role")]
    public virtual ICollection<UsysRoleCodeFilterGroup> UsysRoleCodeFilterGroups { get; set; } = new List<UsysRoleCodeFilterGroup>();

    [InverseProperty("Role")]
    public virtual ICollection<UsysRoleEntity> UsysRoleEntities { get; set; } = new List<UsysRoleEntity>();

    [InverseProperty("Role")]
    public virtual ICollection<UsysRoleFlag> UsysRoleFlags { get; set; } = new List<UsysRoleFlag>();

    [InverseProperty("Role")]
    public virtual ICollection<UsysRoleModuleDefinition> UsysRoleModuleDefinitions { get; set; } = new List<UsysRoleModuleDefinition>();

    [InverseProperty("Role")]
    public virtual ICollection<UsysRolePortal> UsysRolePortals { get; set; } = new List<UsysRolePortal>();

    [InverseProperty("Role")]
    public virtual ICollection<UsysRoleRule> UsysRoleRules { get; set; } = new List<UsysRoleRule>();

    [InverseProperty("Role")]
    public virtual ICollection<UsysUserRole> UsysUserRoles { get; set; } = new List<UsysUserRole>();
}
