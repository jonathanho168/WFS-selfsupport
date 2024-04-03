using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkDataSorting")]
public partial class UsysLnkDataSorting
{
    [Key]
    [Column("LnkDataSortingGUID")]
    public Guid LnkDataSortingGuid { get; set; }

    [Column("LnkExportFileGUID")]
    public Guid LnkExportFileGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LnkExportFileGuid")]
    [InverseProperty("UsysLnkDataSortings")]
    public virtual UsysLnkExportFile LnkExportFile { get; set; } = null!;

    [InverseProperty("LnkDataSorting")]
    public virtual ICollection<UsysLnkDataSortingDataGrouping> UsysLnkDataSortingDataGroupings { get; set; } = new List<UsysLnkDataSortingDataGrouping>();

    [InverseProperty("LnkDataSorting")]
    public virtual ICollection<UsysLnkDataSortingRecord> UsysLnkDataSortingRecords { get; set; } = new List<UsysLnkDataSortingRecord>();
}
