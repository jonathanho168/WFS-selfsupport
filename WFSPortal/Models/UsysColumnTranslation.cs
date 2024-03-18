using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysColumnTranslation")]
public partial class UsysColumnTranslation
{
    [Key]
    [Column("ColumnTranslationGUID")]
    public Guid ColumnTranslationGuid { get; set; }

    [StringLength(200)]
    public string TableName { get; set; } = null!;

    [StringLength(200)]
    public string ColumnName { get; set; } = null!;

    [Column("TableRowGUID")]
    public Guid TableRowGuid { get; set; }

    [StringLength(15)]
    public string LanguageCode { get; set; } = null!;

    public string? Value { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LanguageCode")]
    [InverseProperty("UsysColumnTranslations")]
    public virtual TLanguage LanguageCodeNavigation { get; set; } = null!;
}
