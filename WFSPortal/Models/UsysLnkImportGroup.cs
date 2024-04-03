using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportGroup")]
public partial class UsysLnkImportGroup
{
    [Key]
    [StringLength(15)]
    public string ImportGroupCode { get; set; } = null!;

    public string? ImportGroupDescription { get; set; }

    [Column("LnkImportMasterGUID")]
    public Guid LnkImportMasterGuid { get; set; }

    public bool CheckRowSecurityToRunFlag { get; set; }

    [Column("LnkImportGroupGUID")]
    public Guid LnkImportGroupGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool CanBeScheduledFlag { get; set; }

    [ForeignKey("LnkImportMasterGuid")]
    [InverseProperty("UsysLnkImportGroups")]
    public virtual UsysLnkImportMaster LnkImportMaster { get; set; } = null!;

    [InverseProperty("ImportGroupCodeNavigation")]
    public virtual ICollection<UsysLnkImportGroupAssignment> UsysLnkImportGroupAssignments { get; set; } = new List<UsysLnkImportGroupAssignment>();

    [InverseProperty("ImportGroupCodeNavigation")]
    public virtual ICollection<UsysLnkImportLog> UsysLnkImportLogs { get; set; } = new List<UsysLnkImportLog>();

    [InverseProperty("ImportGroupCodeNavigation")]
    public virtual ICollection<UsysLnkImportScheduleHist> UsysLnkImportScheduleHists { get; set; } = new List<UsysLnkImportScheduleHist>();
}
