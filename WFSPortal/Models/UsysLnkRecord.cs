using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkRecord")]
public partial class UsysLnkRecord
{
    [Column("LnkExportFileGUID")]
    public Guid LnkExportFileGuid { get; set; }

    [StringLength(80)]
    public string RecordDescription { get; set; } = null!;

    public int? Sequence { get; set; }

    public bool? SingleRecordFlag { get; set; }

    public bool? AlwaysSendFlag { get; set; }

    [StringLength(2000)]
    public string? Criteria { get; set; }

    [StringLength(115)]
    public string? WorkTable { get; set; }

    [StringLength(115)]
    public string? WarehouseTable { get; set; }

    [Key]
    [Column("LnkRecordGUID")]
    public Guid LnkRecordGuid { get; set; }

    public int RowVersion { get; set; }

    public bool NoJoinExportPersonFlag { get; set; }

    public bool FullRecordOnChangeFlag { get; set; }

    public bool SourceBasedPersonSelectionFlag { get; set; }

    [ForeignKey("LnkExportFileGuid")]
    [InverseProperty("UsysLnkRecords")]
    public virtual UsysLnkExportFile LnkExportFile { get; set; } = null!;

    [InverseProperty("LnkRecord")]
    public virtual ICollection<UsysLnkDataGroupingRecord> UsysLnkDataGroupingRecords { get; set; } = new List<UsysLnkDataGroupingRecord>();

    [InverseProperty("LnkRecord")]
    public virtual ICollection<UsysLnkDataSortingRecord> UsysLnkDataSortingRecords { get; set; } = new List<UsysLnkDataSortingRecord>();

    [InverseProperty("LnkRecord")]
    public virtual ICollection<UsysLnkExportRecordLog> UsysLnkExportRecordLogs { get; set; } = new List<UsysLnkExportRecordLog>();

    [InverseProperty("LnkRecord")]
    public virtual ICollection<UsysLnkFieldDef> UsysLnkFieldDefs { get; set; } = new List<UsysLnkFieldDef>();
}
