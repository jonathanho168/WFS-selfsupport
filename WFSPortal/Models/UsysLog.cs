using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLog")]
[Index("LogDateTime", "ComponentName", "Severity", Name = "IX_USysLogByComponentNameAndSeverity")]
[Index("LogDateTime", "MachineName", "SiteName", "VirtualDirectoryName", "Severity", Name = "IX_USysLogByInstance")]
[Index("LogDateTime", "PortalName", "Severity", Name = "IX_USysLogByPortal")]
[Index("LogDateTime", "UserName", "Severity", Name = "IX_USysLogByUser")]
public partial class UsysLog
{
    [Key]
    public Guid SysLogGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LogDateTime { get; set; }

    [StringLength(128)]
    public string MachineName { get; set; } = null!;

    [StringLength(128)]
    public string SiteName { get; set; } = null!;

    [StringLength(128)]
    public string VirtualDirectoryName { get; set; } = null!;

    [StringLength(128)]
    public string PortalName { get; set; } = null!;

    [StringLength(64)]
    public string? UserName { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? ComponentName { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string Severity { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string Exception { get; set; } = null!;

    public int RowVersion { get; set; }

    public string? RequestUrl { get; set; }
}
