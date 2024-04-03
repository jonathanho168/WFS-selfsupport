using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysEntity")]
[Index("EntityGuid", Name = "RG_USysEntity", IsUnique = true)]
public partial class UsysEntity
{
    [Key]
    [StringLength(50)]
    public string EntityName { get; set; } = null!;

    [StringLength(80)]
    public string EntityDescription { get; set; } = null!;

    [StringLength(15)]
    public string EntityGroupCode { get; set; } = null!;

    [Column("EntityGUID")]
    public Guid EntityGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public int LicenseFlags { get; set; }

    public bool CandidateDataFlag { get; set; }

    [Column("ModuleDefinitionGUID")]
    public Guid? ModuleDefinitionGuid { get; set; }

    public bool NotEligibleForReadOnlyRoleFlag { get; set; }

    [ForeignKey("EntityGroupCode")]
    [InverseProperty("UsysEntities")]
    public virtual UsysEntityGroup EntityGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("ModuleDefinitionGuid")]
    [InverseProperty("UsysEntities")]
    public virtual UsysModuleDefinition? ModuleDefinition { get; set; }

    [InverseProperty("EntityNameNavigation")]
    public virtual ICollection<TAbsenceRule> TAbsenceRules { get; set; } = new List<TAbsenceRule>();

    [InverseProperty("TableEntityNavigation")]
    public virtual ICollection<UsysAlert> UsysAlerts { get; set; } = new List<UsysAlert>();

    [InverseProperty("EntityNameNavigation")]
    public virtual ICollection<UsysAttachmentColumn> UsysAttachmentColumns { get; set; } = new List<UsysAttachmentColumn>();

    [InverseProperty("TaskEntityNameNavigation")]
    public virtual ICollection<UsysChecklistInstanceStep> UsysChecklistInstanceSteps { get; set; } = new List<UsysChecklistInstanceStep>();

    [InverseProperty("TaskEntityNameNavigation")]
    public virtual ICollection<UsysChecklistStep> UsysChecklistSteps { get; set; } = new List<UsysChecklistStep>();

    [InverseProperty("EntityNameNavigation")]
    public virtual ICollection<UsysCommunicationTemplate> UsysCommunicationTemplates { get; set; } = new List<UsysCommunicationTemplate>();

    [InverseProperty("EntityNameNavigation")]
    public virtual ICollection<UsysCsfentity> UsysCsfentities { get; set; } = new List<UsysCsfentity>();

    [InverseProperty("Entity")]
    public virtual ICollection<UsysDraft> UsysDrafts { get; set; } = new List<UsysDraft>();

    [InverseProperty("TableEntityNameNavigation")]
    public virtual ICollection<UsysLnkExportTrigger> UsysLnkExportTriggers { get; set; } = new List<UsysLnkExportTrigger>();

    [InverseProperty("ReportEntityNameNavigation")]
    public virtual ICollection<UsysLnkImportMaster> UsysLnkImportMasters { get; set; } = new List<UsysLnkImportMaster>();

    [InverseProperty("EntityNameNavigation")]
    public virtual ICollection<UsysNavigator> UsysNavigators { get; set; } = new List<UsysNavigator>();

    [InverseProperty("TaskEntityNavigation")]
    public virtual ICollection<UsysRecipientOverride> UsysRecipientOverrides { get; set; } = new List<UsysRecipientOverride>();

    [InverseProperty("EntityNameNavigation")]
    public virtual ICollection<UsysRoleEntity> UsysRoleEntities { get; set; } = new List<UsysRoleEntity>();

    [InverseProperty("TaskEntityNavigation")]
    public virtual UsysRouting? UsysRouting { get; set; }

    [InverseProperty("EntityNameNavigation")]
    public virtual ICollection<UsysRule> UsysRules { get; set; } = new List<UsysRule>();

    [InverseProperty("EntityNameNavigation")]
    public virtual UsysSynchronizationEntity? UsysSynchronizationEntity { get; set; }

    [InverseProperty("EntityNameNavigation")]
    public virtual ICollection<UsysTaskDatum> UsysTaskData { get; set; } = new List<UsysTaskDatum>();
}
