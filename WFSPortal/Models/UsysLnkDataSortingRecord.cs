using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkDataSortingRecord")]
public partial class UsysLnkDataSortingRecord
{
    [Key]
    [Column("LnkDataSortingRecordGUID")]
    public Guid LnkDataSortingRecordGuid { get; set; }

    [Column("LnkDataSortingGUID")]
    public Guid LnkDataSortingGuid { get; set; }

    [Column("LnkRecordGUID")]
    public Guid LnkRecordGuid { get; set; }

    [Column("LnkFieldDefGUID")]
    public Guid LnkFieldDefGuid { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string SortOrder { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("LnkDataSortingGuid")]
    [InverseProperty("UsysLnkDataSortingRecords")]
    public virtual UsysLnkDataSorting LnkDataSorting { get; set; } = null!;

    [ForeignKey("LnkFieldDefGuid")]
    [InverseProperty("UsysLnkDataSortingRecords")]
    public virtual UsysLnkFieldDef LnkFieldDef { get; set; } = null!;

    [ForeignKey("LnkRecordGuid")]
    [InverseProperty("UsysLnkDataSortingRecords")]
    public virtual UsysLnkRecord LnkRecord { get; set; } = null!;
}
