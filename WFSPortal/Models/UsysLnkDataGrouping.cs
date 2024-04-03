using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkDataGrouping")]
public partial class UsysLnkDataGrouping
{
    [Key]
    [Column("LnkDataGroupingGUID")]
    public Guid LnkDataGroupingGuid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DataGroupingDescription { get; set; } = null!;

    [Column("LnkExportFileGUID")]
    public Guid LnkExportFileGuid { get; set; }

    [Column("LnkDataGroupingParentGUID")]
    public Guid? LnkDataGroupingParentGuid { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("LnkDataGroupingParent")]
    public virtual ICollection<UsysLnkDataGrouping> InverseLnkDataGroupingParent { get; set; } = new List<UsysLnkDataGrouping>();

    [ForeignKey("LnkDataGroupingParentGuid")]
    [InverseProperty("InverseLnkDataGroupingParent")]
    public virtual UsysLnkDataGrouping? LnkDataGroupingParent { get; set; }

    [ForeignKey("LnkExportFileGuid")]
    [InverseProperty("UsysLnkDataGroupings")]
    public virtual UsysLnkExportFile LnkExportFile { get; set; } = null!;

    [InverseProperty("LnkDataGrouping")]
    public virtual ICollection<UsysLnkDataGroupingField> UsysLnkDataGroupingFields { get; set; } = new List<UsysLnkDataGroupingField>();

    [InverseProperty("LnkDataGrouping")]
    public virtual ICollection<UsysLnkDataGroupingRecord> UsysLnkDataGroupingRecords { get; set; } = new List<UsysLnkDataGroupingRecord>();

    [InverseProperty("LnkDataGrouping")]
    public virtual ICollection<UsysLnkDataSortingDataGrouping> UsysLnkDataSortingDataGroupings { get; set; } = new List<UsysLnkDataSortingDataGrouping>();
}
