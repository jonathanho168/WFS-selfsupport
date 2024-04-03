using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysTaskDataLog")]
public partial class UsysTaskDataLog
{
    [Key]
    [Column("TaskDataLogGUID")]
    public Guid TaskDataLogGuid { get; set; }

    public Guid TaskDataGuid { get; set; }

    [Column("LoggedByUserGUID")]
    public Guid LoggedByUserGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LogDate { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LoggedByUserGuid")]
    [InverseProperty("UsysTaskDataLogs")]
    public virtual UsysUser LoggedByUser { get; set; } = null!;

    [ForeignKey("TaskDataGuid")]
    [InverseProperty("UsysTaskDataLogs")]
    public virtual UsysTaskDatum TaskData { get; set; } = null!;
}
