using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportLog")]
public partial class UsysLnkExportLog
{
    [Key]
    [Column("LnkExportLogGUID")]
    public Guid LnkExportLogGuid { get; set; }

    [StringLength(15)]
    public string ExportStatusCode { get; set; } = null!;

    [Column("UserGUID")]
    public Guid UserGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExportDateTime { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    public bool SendAllData { get; set; }

    [Column("LnkExportGroupGUID")]
    public Guid LnkExportGroupGuid { get; set; }

    public Guid? PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PayDate { get; set; }

    [ForeignKey("ExportStatusCode")]
    [InverseProperty("UsysLnkExportLogs")]
    public virtual UsysLnkExportStatusCode ExportStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("LnkExportGroupGuid")]
    [InverseProperty("UsysLnkExportLogs")]
    public virtual UsysLnkExportGroup LnkExportGroup { get; set; } = null!;

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysLnkExportLogs")]
    public virtual UsysUser User { get; set; } = null!;

    [InverseProperty("LnkExportLog")]
    public virtual ICollection<UsysLnkExportRecordLog> UsysLnkExportRecordLogs { get; set; } = new List<UsysLnkExportRecordLog>();

    [InverseProperty("LnkExportLog")]
    public virtual ICollection<UsysLnkExportTriggerLog> UsysLnkExportTriggerLogs { get; set; } = new List<UsysLnkExportTriggerLog>();
}
