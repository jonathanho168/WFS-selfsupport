using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysModuleDefinition")]
public partial class UsysModuleDefinition
{
    [StringLength(128)]
    public string Name { get; set; } = null!;

    [StringLength(256)]
    public string Source { get; set; } = null!;

    [Key]
    [Column("ModuleDefinitionGUID")]
    public Guid ModuleDefinitionGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(50)]
    public string? ImageSrc { get; set; }

    public bool ReadOnlyContent { get; set; }

    public bool AllowAnonymous { get; set; }

    public bool CanPrintFlag { get; set; }

    public int LicenseFlags { get; set; }

    public bool RequiresRowSecurityFlag { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ModuleType { get; set; }

    [InverseProperty("ModuleDefinition")]
    public virtual ICollection<UsysAnnouncement> UsysAnnouncements { get; set; } = new List<UsysAnnouncement>();

    [InverseProperty("ModuleDefinition")]
    public virtual ICollection<UsysCsfmoduleDefinition> UsysCsfmoduleDefinitions { get; set; } = new List<UsysCsfmoduleDefinition>();

    [InverseProperty("ModuleDefinition")]
    public virtual ICollection<UsysEntity> UsysEntities { get; set; } = new List<UsysEntity>();

    [InverseProperty("ModuleDefinition")]
    public virtual ICollection<UsysHtmlText> UsysHtmlTexts { get; set; } = new List<UsysHtmlText>();

    [InverseProperty("ModuleDefinition")]
    public virtual ICollection<UsysModuleField> UsysModuleFields { get; set; } = new List<UsysModuleField>();

    [InverseProperty("ModuleDefinition")]
    public virtual ICollection<UsysModuleSetting> UsysModuleSettings { get; set; } = new List<UsysModuleSetting>();

    [InverseProperty("ModuleDefinition")]
    public virtual ICollection<UsysModule> UsysModules { get; set; } = new List<UsysModule>();

    [InverseProperty("ModuleDefinition")]
    public virtual ICollection<UsysRoleModuleDefinition> UsysRoleModuleDefinitions { get; set; } = new List<UsysRoleModuleDefinition>();
}
