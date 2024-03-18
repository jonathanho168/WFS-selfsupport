using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportMaster")]
[Index("LnkExportMasterGuid", Name = "RG_USysLnkExportMaster", IsUnique = true)]
public partial class UsysLnkExportMaster
{
    [Key]
    [Column("ExportID")]
    [StringLength(15)]
    public string ExportId { get; set; } = null!;

    public bool FixedLengthFlag { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Delimiter { get; set; }

    public bool SendAllDataFlag { get; set; }

    public bool RollupFlag { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? DelCharacter { get; set; }

    [Column("LnkExportMasterGUID")]
    public Guid LnkExportMasterGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? ExportTemplateClass { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string ExportType { get; set; } = null!;

    public bool DeleteWorkTablesFlag { get; set; }

    public int LogHistoryCount { get; set; }

    public bool EndDateExportGroupFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public string? ExportDescription { get; set; }

    [InverseProperty("Export")]
    public virtual ICollection<UsysIntegrationTemplateKey> UsysIntegrationTemplateKeys { get; set; } = new List<UsysIntegrationTemplateKey>();

    [InverseProperty("Export")]
    public virtual ICollection<UsysLnkExportFile> UsysLnkExportFiles { get; set; } = new List<UsysLnkExportFile>();

    [InverseProperty("Export")]
    public virtual ICollection<UsysLnkExportGroup> UsysLnkExportGroups { get; set; } = new List<UsysLnkExportGroup>();

    [InverseProperty("Export")]
    public virtual ICollection<UsysLnkExportMasterParameter> UsysLnkExportMasterParameters { get; set; } = new List<UsysLnkExportMasterParameter>();

    [InverseProperty("Export")]
    public virtual ICollection<UsysLnkExportTriggerPerson> UsysLnkExportTriggerPeople { get; set; } = new List<UsysLnkExportTriggerPerson>();

    [InverseProperty("Export")]
    public virtual ICollection<UsysLnkExportTrigger> UsysLnkExportTriggers { get; set; } = new List<UsysLnkExportTrigger>();

    [InverseProperty("Export")]
    public virtual ICollection<UsysLnkRollupCode> UsysLnkRollupCodes { get; set; } = new List<UsysLnkRollupCode>();
}
