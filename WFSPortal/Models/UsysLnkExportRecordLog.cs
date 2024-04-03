using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportRecordLog")]
public partial class UsysLnkExportRecordLog
{
    [Key]
    [Column("LnkExportRecordLogGUID")]
    public Guid LnkExportRecordLogGuid { get; set; }

    [Column("LnkExportLogGUID")]
    public Guid LnkExportLogGuid { get; set; }

    [Column("LnkRecordGUID")]
    public Guid LnkRecordGuid { get; set; }

    [Column(TypeName = "text")]
    public string? CreateScript { get; set; }

    [Column("DataXML", TypeName = "xml")]
    public string? DataXml { get; set; }

    public int RowVersion { get; set; }

    [Column("DeltaXML", TypeName = "xml")]
    public string? DeltaXml { get; set; }

    [ForeignKey("LnkExportLogGuid")]
    [InverseProperty("UsysLnkExportRecordLogs")]
    public virtual UsysLnkExportLog LnkExportLog { get; set; } = null!;

    [ForeignKey("LnkRecordGuid")]
    [InverseProperty("UsysLnkExportRecordLogs")]
    public virtual UsysLnkRecord LnkRecord { get; set; } = null!;

    [InverseProperty("LnkExportRecordLog")]
    public virtual ICollection<UsysLnkExportRecordDataError> UsysLnkExportRecordDataErrors { get; set; } = new List<UsysLnkExportRecordDataError>();
}
