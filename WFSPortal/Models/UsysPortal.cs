using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysPortal")]
public partial class UsysPortal
{
    [StringLength(128)]
    public string PortalName { get; set; } = null!;

    [Key]
    [Column("PortalGUID")]
    public Guid PortalGuid { get; set; }

    public int RowVersion { get; set; }

    public bool ShowHomePageFlag { get; set; }

    public bool AllowEmployeeSelfRegistrationFlag { get; set; }

    public byte[]? HeaderCompanyImage { get; set; }

    public byte[]? HeaderBackgroundImage { get; set; }

    [StringLength(128)]
    public string? HeaderCompanyUrl { get; set; }

    public byte[]? CssFile { get; set; }

    public bool IsMirror { get; set; }

    [StringLength(255)]
    public string? MirrorUrl { get; set; }

    public bool SearchPersonalEmailFlag { get; set; }

    public bool SearchCompanyEmailFlag { get; set; }

    public bool ShowMyPeopleFlag { get; set; }

    [StringLength(15)]
    public string PortalTypeCode { get; set; } = null!;

    public byte[]? HeaderMicroImage { get; set; }

    public byte[]? LoginBackgroundImage { get; set; }

    public byte[]? LoginCompanyImage { get; set; }

    [ForeignKey("PortalTypeCode")]
    [InverseProperty("UsysPortals")]
    public virtual UsysPortalType PortalTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("Portal")]
    public virtual ICollection<UsysDraft> UsysDrafts { get; set; } = new List<UsysDraft>();

    [InverseProperty("Portal")]
    public virtual ICollection<UsysInstallation> UsysInstallations { get; set; } = new List<UsysInstallation>();

    [InverseProperty("Portal")]
    public virtual ICollection<UsysPortalHomePageModule> UsysPortalHomePageModules { get; set; } = new List<UsysPortalHomePageModule>();

    [InverseProperty("Portal")]
    public virtual ICollection<UsysResource> UsysResources { get; set; } = new List<UsysResource>();

    [InverseProperty("Portal")]
    public virtual ICollection<UsysRolePortal> UsysRolePortals { get; set; } = new List<UsysRolePortal>();

    [InverseProperty("Portal")]
    public virtual ICollection<UsysRoutingInstanceStepHistory> UsysRoutingInstanceStepHistories { get; set; } = new List<UsysRoutingInstanceStepHistory>();

    [InverseProperty("Portal")]
    public virtual ICollection<UsysRoutingInstanceStep> UsysRoutingInstanceSteps { get; set; } = new List<UsysRoutingInstanceStep>();

    [InverseProperty("Portal")]
    public virtual ICollection<UsysTab> UsysTabs { get; set; } = new List<UsysTab>();

    [InverseProperty("Portal")]
    public virtual ICollection<UsysUserHomePageModule> UsysUserHomePageModules { get; set; } = new List<UsysUserHomePageModule>();
}
