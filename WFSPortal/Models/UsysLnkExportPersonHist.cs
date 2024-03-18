using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportPersonHist")]
[Index("PersonGuid", "LnkExportGroupGuid", "SysLnkExportPersonStartDate", Name = "AK_USysLnkExportPersonHist", IsUnique = true)]
public partial class UsysLnkExportPersonHist
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    public bool? SendAllDataFlag { get; set; }

    [Column("UniqueID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? UniqueId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Field1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Field2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Field3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Field4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Field5 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Field6 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Field7 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Field8 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Field9 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Field10 { get; set; }

    public int RowVersion { get; set; }

    [Key]
    [Column("LnkExportPersonHistGUID")]
    public Guid LnkExportPersonHistGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SysLnkExportPersonStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SysLnkExportPersonEndDate { get; set; }

    public bool SysLnkExportPersonCurrentFlag { get; set; }

    [Column("LnkExportGroupGUID")]
    public Guid LnkExportGroupGuid { get; set; }

    public bool AllDataSentFlag { get; set; }

    [ForeignKey("LnkExportGroupGuid")]
    [InverseProperty("UsysLnkExportPersonHists")]
    public virtual UsysLnkExportGroup LnkExportGroup { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("UsysLnkExportPersonHists")]
    public virtual TPerson Person { get; set; } = null!;
}
