using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportTrigger")]
[Index("TableEntityName", Name = "IX_USysLnkExportTrigger_TableEntityName")]
public partial class UsysLnkExportTrigger
{
    [Key]
    [Column("LnkExportTriggerGUID")]
    public Guid LnkExportTriggerGuid { get; set; }

    [Column("ExportID")]
    [StringLength(15)]
    public string ExportId { get; set; } = null!;

    [StringLength(50)]
    public string TableEntityName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string TriggerType { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("ExportId")]
    [InverseProperty("UsysLnkExportTriggers")]
    public virtual UsysLnkExportMaster Export { get; set; } = null!;

    [ForeignKey("TableEntityName")]
    [InverseProperty("UsysLnkExportTriggers")]
    public virtual UsysEntity TableEntityNameNavigation { get; set; } = null!;
}
