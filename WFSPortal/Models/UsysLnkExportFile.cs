using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportFile")]
public partial class UsysLnkExportFile
{
    [Column("ExportID")]
    [StringLength(15)]
    public string ExportId { get; set; } = null!;

    [StringLength(80)]
    public string FileDescription { get; set; } = null!;

    [StringLength(2000)]
    public string OutputPath { get; set; } = null!;

    [StringLength(2000)]
    public string OutputFileName { get; set; } = null!;

    [Key]
    [Column("LnkExportFileGUID")]
    public Guid LnkExportFileGuid { get; set; }

    public int RowVersion { get; set; }

    public bool UseTextQualifierFlag { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? TextQualifier { get; set; }

    [ForeignKey("ExportId")]
    [InverseProperty("UsysLnkExportFiles")]
    public virtual UsysLnkExportMaster Export { get; set; } = null!;

    [InverseProperty("LnkExportFile")]
    public virtual ICollection<UsysLnkDataGrouping> UsysLnkDataGroupings { get; set; } = new List<UsysLnkDataGrouping>();

    [InverseProperty("LnkExportFile")]
    public virtual ICollection<UsysLnkDataSorting> UsysLnkDataSortings { get; set; } = new List<UsysLnkDataSorting>();

    [InverseProperty("LnkExportFile")]
    public virtual ICollection<UsysLnkRecord> UsysLnkRecords { get; set; } = new List<UsysLnkRecord>();
}
