using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysInstallation")]
[Index("InstallationGuid", Name = "RG_USysInstallation", IsUnique = true)]
public partial class UsysInstallation
{
    [Key]
    [Column("InstallationID")]
    public int InstallationId { get; set; }

    [StringLength(30)]
    public string ProductName { get; set; } = null!;

    public int Version { get; set; }

    public int ModificationLevel { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InstallDateTime { get; set; }

    [Column("InstallationGUID")]
    public Guid InstallationGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(100)]
    public string? LicenseKey { get; set; }

    [StringLength(20)]
    public string? AssemblyVersion { get; set; }

    public int? LicenseFlags { get; set; }

    public bool ChangesScriptRun { get; set; }

    public int Revision { get; set; }

    [StringLength(128)]
    public string? MachineName { get; set; }

    [StringLength(128)]
    public string? SiteName { get; set; }

    [StringLength(128)]
    public string? VirtualDirectoryName { get; set; }

    [Column("PortalGUID")]
    public Guid? PortalGuid { get; set; }

    [StringLength(20)]
    public string? VersioningNumber { get; set; }

    public bool TelemetryOptInFlag { get; set; }

    public bool TelemetryLicenseInfoFlag { get; set; }

    [ForeignKey("PortalGuid")]
    [InverseProperty("UsysInstallations")]
    public virtual UsysPortal? Portal { get; set; }
}
