using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysBatchJobLog")]
public partial class UsysBatchJobLog
{
    [Key]
    [Column("BatchJobLogGUID")]
    public Guid BatchJobLogGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BatchJobLogEventDate { get; set; }

    public int BatchJobLogLevel { get; set; }

    public int RowVersion { get; set; }

    [Column("BatchJobGUID")]
    public Guid BatchJobGuid { get; set; }

    [Column("BatchJobLogMessageXML", TypeName = "xml")]
    public string? BatchJobLogMessageXml { get; set; }

    [ForeignKey("BatchJobGuid")]
    [InverseProperty("UsysBatchJobLogs")]
    public virtual UsysBatchJob BatchJob { get; set; } = null!;
}
