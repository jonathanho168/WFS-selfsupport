using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportTriggerLog")]
public partial class UsysLnkExportTriggerLog
{
    [Key]
    [Column("LnkExportTriggerLogGUID")]
    public Guid LnkExportTriggerLogGuid { get; set; }

    [Column("LnkExportLogGUID")]
    public Guid LnkExportLogGuid { get; set; }

    [StringLength(15)]
    public string ExportTriggerStatusCode { get; set; } = null!;

    public string? Message { get; set; }

    [StringLength(15)]
    public string ExportTriggerActionCode { get; set; } = null!;

    [Column("DataSentXML", TypeName = "xml")]
    public string? DataSentXml { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ExportTriggerActionCode")]
    [InverseProperty("UsysLnkExportTriggerLogs")]
    public virtual TExportTriggerAction ExportTriggerActionCodeNavigation { get; set; } = null!;

    [ForeignKey("ExportTriggerStatusCode")]
    [InverseProperty("UsysLnkExportTriggerLogs")]
    public virtual TExportTriggerStatus ExportTriggerStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("LnkExportLogGuid")]
    [InverseProperty("UsysLnkExportTriggerLogs")]
    public virtual UsysLnkExportLog LnkExportLog { get; set; } = null!;
}
