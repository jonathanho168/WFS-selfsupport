using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysUserHomePageModule")]
[Index("UserGuid", "ModuleGuid", Name = "AK_USysUserHomePageModule", IsUnique = true)]
public partial class UsysUserHomePageModule
{
    [Column("UserGUID")]
    public Guid UserGuid { get; set; }

    [Column("ModuleGUID")]
    public Guid ModuleGuid { get; set; }

    [Key]
    [Column("UserHomePageModuleGUID")]
    public Guid UserHomePageModuleGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("PortalGUID")]
    public Guid? PortalGuid { get; set; }

    [ForeignKey("ModuleGuid")]
    [InverseProperty("UsysUserHomePageModules")]
    public virtual UsysModule Module { get; set; } = null!;

    [ForeignKey("PortalGuid")]
    [InverseProperty("UsysUserHomePageModules")]
    public virtual UsysPortal? Portal { get; set; }

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysUserHomePageModules")]
    public virtual UsysUser User { get; set; } = null!;
}
