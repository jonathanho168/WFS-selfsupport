using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportTriggerRecordLog")]
public partial class UsysLnkExportTriggerRecordLog
{
    [Key]
    [Column("LnkExportTriggerRecordLogGUID")]
    public Guid LnkExportTriggerRecordLogGuid { get; set; }

    [Column("LnkExportTriggerLogGUID")]
    public Guid LnkExportTriggerLogGuid { get; set; }

    [StringLength(255)]
    public string? FieldName { get; set; }

    public string? Description { get; set; }

    public string? Message { get; set; }

    [Column("DataSentXML", TypeName = "xml")]
    public string? DataSentXml { get; set; }

    public int RowVersion { get; set; }
}
