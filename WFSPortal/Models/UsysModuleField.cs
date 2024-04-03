using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysModuleField")]
public partial class UsysModuleField
{
    [Key]
    [Column("ModuleFieldGUID")]
    public Guid ModuleFieldGuid { get; set; }

    [Column("ModuleDefinitionGUID")]
    public Guid ModuleDefinitionGuid { get; set; }

    [StringLength(128)]
    public string FieldName { get; set; } = null!;

    public bool HiddenFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ModuleDefinitionGuid")]
    [InverseProperty("UsysModuleFields")]
    public virtual UsysModuleDefinition ModuleDefinition { get; set; } = null!;
}
