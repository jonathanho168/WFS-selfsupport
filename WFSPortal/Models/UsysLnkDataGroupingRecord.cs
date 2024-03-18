using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkDataGroupingRecord")]
public partial class UsysLnkDataGroupingRecord
{
    [Key]
    [Column("LnkDataGroupingRecordGUID")]
    public Guid LnkDataGroupingRecordGuid { get; set; }

    [Column("LnkDataGroupingGUID")]
    public Guid LnkDataGroupingGuid { get; set; }

    [Column("LnkRecordGUID")]
    public Guid LnkRecordGuid { get; set; }

    public int Sequence { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LnkDataGroupingGuid")]
    [InverseProperty("UsysLnkDataGroupingRecords")]
    public virtual UsysLnkDataGrouping LnkDataGrouping { get; set; } = null!;

    [ForeignKey("LnkRecordGuid")]
    [InverseProperty("UsysLnkDataGroupingRecords")]
    public virtual UsysLnkRecord LnkRecord { get; set; } = null!;
}
