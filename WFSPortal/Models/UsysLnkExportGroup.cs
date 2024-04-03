using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportGroup")]
public partial class UsysLnkExportGroup
{
    [Column("ExportID")]
    [StringLength(15)]
    public string ExportId { get; set; } = null!;

    [StringLength(15)]
    public string ExportGroup { get; set; } = null!;

    [Key]
    [Column("LnkExportGroupGUID")]
    public Guid LnkExportGroupGuid { get; set; }

    public bool DirectDepositEditDisabledFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(2000)]
    public string? ArchivePath { get; set; }

    public bool ProcessRulesFlag { get; set; }

    public bool CheckRowSecurityToRunFlag { get; set; }

    public string? ExportGroupDescription { get; set; }

    public bool InactiveFlag { get; set; }

    [ForeignKey("ExportId")]
    [InverseProperty("UsysLnkExportGroups")]
    public virtual UsysLnkExportMaster Export { get; set; } = null!;

    [InverseProperty("LnkExportGroup")]
    public virtual ICollection<UsysLnkExportGroupRule> UsysLnkExportGroupRules { get; set; } = new List<UsysLnkExportGroupRule>();

    [InverseProperty("LnkExportGroup")]
    public virtual ICollection<UsysLnkExportLog> UsysLnkExportLogs { get; set; } = new List<UsysLnkExportLog>();

    [InverseProperty("LnkExportGroup")]
    public virtual ICollection<UsysLnkExportPersonHist> UsysLnkExportPersonHists { get; set; } = new List<UsysLnkExportPersonHist>();

    [InverseProperty("LnkExportGroup")]
    public virtual ICollection<UsysLnkExportScheduleHist> UsysLnkExportScheduleHists { get; set; } = new List<UsysLnkExportScheduleHist>();
}
