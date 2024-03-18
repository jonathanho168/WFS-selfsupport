using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysModule")]
public partial class UsysModule
{
    public int ModuleOrder { get; set; }

    [StringLength(50)]
    public string? PaneName { get; set; }

    [Key]
    [Column("ModuleGUID")]
    public Guid ModuleGuid { get; set; }

    public int RowVersion { get; set; }

    public Guid? SysTabGuid { get; set; }

    [Column("ModuleDefinitionGUID")]
    public Guid? ModuleDefinitionGuid { get; set; }

    [Column(TypeName = "xml")]
    public string? Parameters { get; set; }

    [ForeignKey("ModuleDefinitionGuid")]
    [InverseProperty("UsysModules")]
    public virtual UsysModuleDefinition? ModuleDefinition { get; set; }

    [ForeignKey("SysTabGuid")]
    [InverseProperty("UsysModules")]
    public virtual UsysTab? SysTab { get; set; }

    [InverseProperty("Module")]
    public virtual ICollection<UsysPortalHomePageModule> UsysPortalHomePageModules { get; set; } = new List<UsysPortalHomePageModule>();

    [InverseProperty("Module")]
    public virtual ICollection<UsysUserHomePageModule> UsysUserHomePageModules { get; set; } = new List<UsysUserHomePageModule>();
}
