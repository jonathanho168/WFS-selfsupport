using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysBatchJob")]
[Index("BatchJobState", "BatchJobStartDate", "ServerName", Name = "WFS_USysBatchJob_BatchJobState_BatchJobStartDate_ServerName")]
public partial class UsysBatchJob
{
    [Key]
    [Column("BatchJobGUID")]
    public Guid BatchJobGuid { get; set; }

    public int BatchJobState { get; set; }

    [StringLength(80)]
    public string BatchJobDescription { get; set; } = null!;

    [StringLength(80)]
    public string? BatchJobKey { get; set; }

    public int BatchJobConcurrency { get; set; }

    [Column("BatchJobUserGUID")]
    public Guid BatchJobUserGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BatchJobStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BatchJobEndDate { get; set; }

    [StringLength(80)]
    public string? BatchJobMessage { get; set; }

    public int RowVersion { get; set; }

    [StringLength(80)]
    public string JobType { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string? ConfigXml { get; set; }

    [StringLength(256)]
    public string? ServerName { get; set; }

    [InverseProperty("BatchJob")]
    public virtual ICollection<UsysBatchJobLog> UsysBatchJobLogs { get; set; } = new List<UsysBatchJobLog>();
}
