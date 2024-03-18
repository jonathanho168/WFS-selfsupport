using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysUserAccessLog")]
[Index("UserName", Name = "WFS_UserAccessLog_Username_Date")]
public partial class UsysUserAccessLog
{
    [Key]
    [Column("UserAccessLogGUID")]
    public Guid UserAccessLogGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AccessDateTime { get; set; }

    [StringLength(128)]
    public string UserName { get; set; } = null!;

    public int AccessType { get; set; }

    [StringLength(40)]
    public string UserIpAddress { get; set; } = null!;

    public bool SuccessFlag { get; set; }

    [Column("UserGUID")]
    public Guid? UserGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysUserAccessLogs")]
    public virtual UsysUser? User { get; set; }
}
