using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoleCodeFilterGroup")]
public partial class UsysRoleCodeFilterGroup
{
    [StringLength(15)]
    public string CodeFilterGroupCode { get; set; } = null!;

    [Key]
    [Column("SysRoleCodeFilterGroupGUID")]
    public Guid SysRoleCodeFilterGroupGuid { get; set; }

    [Column("RoleGUID")]
    public Guid RoleGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CodeFilterGroupCode")]
    [InverseProperty("UsysRoleCodeFilterGroups")]
    public virtual UsysCodeFilterGroup CodeFilterGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("RoleGuid")]
    [InverseProperty("UsysRoleCodeFilterGroups")]
    public virtual UsysRole Role { get; set; } = null!;
}
