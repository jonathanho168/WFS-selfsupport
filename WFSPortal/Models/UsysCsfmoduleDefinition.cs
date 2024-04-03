using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCSFModuleDefinition")]
public partial class UsysCsfmoduleDefinition
{
    [Key]
    [Column("CSFModuleDefinitionGuid")]
    public Guid CsfmoduleDefinitionGuid { get; set; }

    public Guid ModuleDefinitionGuid { get; set; }

    [Column("CSFCode")]
    [StringLength(15)]
    public string Csfcode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("Csfcode")]
    [InverseProperty("UsysCsfmoduleDefinitions")]
    public virtual UsysCsf CsfcodeNavigation { get; set; } = null!;

    [ForeignKey("ModuleDefinitionGuid")]
    [InverseProperty("UsysCsfmoduleDefinitions")]
    public virtual UsysModuleDefinition ModuleDefinition { get; set; } = null!;
}
