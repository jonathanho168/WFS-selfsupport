using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoleModuleDefinition")]
public partial class UsysRoleModuleDefinition
{
    [Column("RoleGUID")]
    public Guid RoleGuid { get; set; }

    [Column("ModuleDefinitionGUID")]
    public Guid ModuleDefinitionGuid { get; set; }

    [Key]
    [Column("RoleModuleDefinitionGUID")]
    public Guid RoleModuleDefinitionGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ModuleDefinitionGuid")]
    [InverseProperty("UsysRoleModuleDefinitions")]
    public virtual UsysModuleDefinition ModuleDefinition { get; set; } = null!;

    [ForeignKey("RoleGuid")]
    [InverseProperty("UsysRoleModuleDefinitions")]
    public virtual UsysRole Role { get; set; } = null!;
}
