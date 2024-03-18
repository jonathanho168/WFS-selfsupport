using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportRecordDataError")]
public partial class UsysLnkExportRecordDataError
{
    [Key]
    [Column("LnkExportRecordDataErrorGUID")]
    public Guid LnkExportRecordDataErrorGuid { get; set; }

    [Column("LnkExportRecordLogGUID")]
    public Guid LnkExportRecordLogGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EventDate { get; set; }

    [StringLength(255)]
    public string PersonName { get; set; } = null!;

    [StringLength(255)]
    public string FieldName { get; set; } = null!;

    [StringLength(255)]
    public string Value { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("LnkExportRecordLogGuid")]
    [InverseProperty("UsysLnkExportRecordDataErrors")]
    public virtual UsysLnkExportRecordLog LnkExportRecordLog { get; set; } = null!;
}
