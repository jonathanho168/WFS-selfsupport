using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportFieldDef")]
public partial class UsysLnkImportFieldDef
{
    [Column("LnkImportSourceGUID")]
    public Guid LnkImportSourceGuid { get; set; }

    [StringLength(40)]
    public string ImportFieldName { get; set; } = null!;

    public int StartPosition { get; set; }

    [StringLength(15)]
    public string LnkImportFieldDataTypeCode { get; set; } = null!;

    [StringLength(8)]
    public string Length { get; set; } = null!;

    [StringLength(1)]
    public string? Justification { get; set; }

    public bool KeyField { get; set; }

    [Column("LnkImportDestinationTableGUID")]
    public Guid? LnkImportDestinationTableGuid { get; set; }

    [StringLength(60)]
    public string? DestinationFieldName { get; set; }

    [StringLength(2000)]
    public string? TransformationCode { get; set; }

    [StringLength(2000)]
    public string? ValidationRule { get; set; }

    public string? ValidationMessage { get; set; }

    [Key]
    [Column("LnkImportFieldDefGUID")]
    public Guid LnkImportFieldDefGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LnkImportDestinationTableGuid")]
    [InverseProperty("UsysLnkImportFieldDefs")]
    public virtual UsysLnkImportDestinationTable? LnkImportDestinationTable { get; set; }

    [ForeignKey("LnkImportFieldDataTypeCode")]
    [InverseProperty("UsysLnkImportFieldDefs")]
    public virtual UsysLnkImportFieldDataType LnkImportFieldDataTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("LnkImportSourceGuid")]
    [InverseProperty("UsysLnkImportFieldDefs")]
    public virtual UsysLnkImportSource LnkImportSource { get; set; } = null!;

    [InverseProperty("LnkImportFieldDef")]
    public virtual ICollection<UsysLnkImportFieldTranslation> UsysLnkImportFieldTranslations { get; set; } = new List<UsysLnkImportFieldTranslation>();
}
