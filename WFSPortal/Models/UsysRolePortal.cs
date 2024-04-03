using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRolePortal")]
[Index("PortalGuid", Name = "IX_USysRolePortal_PortalGuid")]
public partial class UsysRolePortal
{
    [Key]
    public Guid RolePortalGuid { get; set; }

    public Guid RoleGuid { get; set; }

    public Guid PortalGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PortalGuid")]
    [InverseProperty("UsysRolePortals")]
    public virtual UsysPortal Portal { get; set; } = null!;

    [ForeignKey("RoleGuid")]
    [InverseProperty("UsysRolePortals")]
    public virtual UsysRole Role { get; set; } = null!;
}
