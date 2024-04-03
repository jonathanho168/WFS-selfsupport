using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysPortalHomePageModule")]
public partial class UsysPortalHomePageModule
{
    [Column("PortalGUID")]
    public Guid PortalGuid { get; set; }

    [Column("ModuleGUID")]
    public Guid ModuleGuid { get; set; }

    [Key]
    [Column("PortalHomePageModuleGUID")]
    public Guid PortalHomePageModuleGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ModuleGuid")]
    [InverseProperty("UsysPortalHomePageModules")]
    public virtual UsysModule Module { get; set; } = null!;

    [ForeignKey("PortalGuid")]
    [InverseProperty("UsysPortalHomePageModules")]
    public virtual UsysPortal Portal { get; set; } = null!;
}
