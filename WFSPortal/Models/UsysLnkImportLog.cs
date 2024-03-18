using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportLog")]
public partial class UsysLnkImportLog
{
    [Key]
    [Column("LnkImportLogGUID")]
    public Guid LnkImportLogGuid { get; set; }

    [StringLength(15)]
    public string ImportGroupCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ImportDateTime { get; set; }

    [Column("UserGUID")]
    public Guid UserGuid { get; set; }

    [StringLength(15)]
    public string ImportStatusCode { get; set; } = null!;

    [Column("ProcessingDataXML", TypeName = "xml")]
    public string? ProcessingDataXml { get; set; }

    [Column("DataXML", TypeName = "xml")]
    public string? DataXml { get; set; }

    [StringLength(10)]
    public string? ScheduleStatus { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ImportGroupCode")]
    [InverseProperty("UsysLnkImportLogs")]
    public virtual UsysLnkImportGroup ImportGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("ImportStatusCode")]
    [InverseProperty("UsysLnkImportLogs")]
    public virtual UsysLnkImportStatusCode ImportStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysLnkImportLogs")]
    public virtual UsysUser User { get; set; } = null!;

    [InverseProperty("LnkImportLog")]
    public virtual ICollection<UsysLnkImportDataError> UsysLnkImportDataErrors { get; set; } = new List<UsysLnkImportDataError>();
}
