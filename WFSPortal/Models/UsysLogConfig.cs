using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLogConfig")]
[Index("LogComponent", Name = "AK_USysLogConfig", IsUnique = true)]
public partial class UsysLogConfig
{
    [Key]
    public Guid SysLogConfigGuid { get; set; }

    [StringLength(255)]
    public string LogComponent { get; set; } = null!;

    [StringLength(20)]
    public string LogLevel { get; set; } = null!;

    public string? Comments { get; set; }

    public int RowVersion { get; set; }
}
