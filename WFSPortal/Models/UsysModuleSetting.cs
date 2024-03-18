using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysModuleSetting")]
public partial class UsysModuleSetting
{
    [StringLength(50)]
    public string SettingName { get; set; } = null!;

    [StringLength(256)]
    public string SettingValue { get; set; } = null!;

    [Key]
    [Column("ModuleSettingGUID")]
    public Guid ModuleSettingGuid { get; set; }

    public int RowVersion { get; set; }

    public Guid ModuleDefinitionGuid { get; set; }

    [ForeignKey("ModuleDefinitionGuid")]
    [InverseProperty("UsysModuleSettings")]
    public virtual UsysModuleDefinition ModuleDefinition { get; set; } = null!;
}
