using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkDataSortingDataGrouping")]
public partial class UsysLnkDataSortingDataGrouping
{
    [Key]
    [Column("LnkDataSortingDataGroupingGUID")]
    public Guid LnkDataSortingDataGroupingGuid { get; set; }

    [Column("LnkDataSortingGUID")]
    public Guid LnkDataSortingGuid { get; set; }

    [Column("LnkDataGroupingGUID")]
    public Guid LnkDataGroupingGuid { get; set; }

    [Column("LnkFieldDefGUID")]
    public Guid LnkFieldDefGuid { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string SortOrder { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("LnkDataGroupingGuid")]
    [InverseProperty("UsysLnkDataSortingDataGroupings")]
    public virtual UsysLnkDataGrouping LnkDataGrouping { get; set; } = null!;

    [ForeignKey("LnkDataSortingGuid")]
    [InverseProperty("UsysLnkDataSortingDataGroupings")]
    public virtual UsysLnkDataSorting LnkDataSorting { get; set; } = null!;

    [ForeignKey("LnkFieldDefGuid")]
    [InverseProperty("UsysLnkDataSortingDataGroupings")]
    public virtual UsysLnkFieldDef LnkFieldDef { get; set; } = null!;
}
