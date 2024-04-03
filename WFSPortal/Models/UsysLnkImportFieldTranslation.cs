using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportFieldTranslation")]
public partial class UsysLnkImportFieldTranslation
{
    [Column("LnkImportFieldDefGUID")]
    public Guid LnkImportFieldDefGuid { get; set; }

    [StringLength(50)]
    public string SourceValue { get; set; } = null!;

    [StringLength(50)]
    public string? TranslationValue { get; set; }

    [Key]
    [Column("LnkImportFieldTranslationGUID")]
    public Guid LnkImportFieldTranslationGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LnkImportFieldDefGuid")]
    [InverseProperty("UsysLnkImportFieldTranslations")]
    public virtual UsysLnkImportFieldDef LnkImportFieldDef { get; set; } = null!;
}
