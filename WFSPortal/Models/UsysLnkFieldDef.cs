using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkFieldDef")]
[Index("LnkRecordGuid", "ExportFieldName", Name = "IX_USysLnkFieldDef_LnkRecordGUID_ExportFieldName", IsUnique = true)]
[Index("TableName", "FieldName", Name = "IX_USysLnkFieldDef_TableName_FieldName")]
public partial class UsysLnkFieldDef
{
    [Column("LnkRecordGUID")]
    public Guid LnkRecordGuid { get; set; }

    public int StartPosition { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ExportFieldName { get; set; }

    public bool RequiredFlag { get; set; }

    public bool ExcludeFlag { get; set; }

    public bool KeyFlag { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string? FieldName { get; set; }

    [StringLength(2000)]
    public string? Value { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string Format { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Length { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? Justification { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? FillChar { get; set; }

    [StringLength(2000)]
    public string? Validation { get; set; }

    public bool ValidFlag { get; set; }

    public bool ConversionFlag { get; set; }

    public bool NoDeleteFlag { get; set; }

    [Key]
    [Column("LnkFieldDefGUID")]
    public Guid LnkFieldDefGuid { get; set; }

    public int RowVersion { get; set; }

    public bool RollupFlag { get; set; }

    public bool EncryptedDataFlag { get; set; }

    public string? ValidationErrorMessage { get; set; }

    public bool DoNotCompareFlag { get; set; }

    [ForeignKey("LnkRecordGuid")]
    [InverseProperty("UsysLnkFieldDefs")]
    public virtual UsysLnkRecord LnkRecord { get; set; } = null!;

    [InverseProperty("LnkFieldDef")]
    public virtual ICollection<UsysLnkCodeConv> UsysLnkCodeConvs { get; set; } = new List<UsysLnkCodeConv>();

    [InverseProperty("LnkFieldDef")]
    public virtual ICollection<UsysLnkDataGroupingField> UsysLnkDataGroupingFields { get; set; } = new List<UsysLnkDataGroupingField>();

    [InverseProperty("LnkFieldDef")]
    public virtual ICollection<UsysLnkDataSortingDataGrouping> UsysLnkDataSortingDataGroupings { get; set; } = new List<UsysLnkDataSortingDataGrouping>();

    [InverseProperty("LnkFieldDef")]
    public virtual ICollection<UsysLnkDataSortingRecord> UsysLnkDataSortingRecords { get; set; } = new List<UsysLnkDataSortingRecord>();

    [InverseProperty("AssocLnkFieldDef")]
    public virtual ICollection<UsysLnkFieldAssoc> UsysLnkFieldAssocAssocLnkFieldDefs { get; set; } = new List<UsysLnkFieldAssoc>();

    [InverseProperty("LnkFieldDef")]
    public virtual ICollection<UsysLnkFieldAssoc> UsysLnkFieldAssocLnkFieldDefs { get; set; } = new List<UsysLnkFieldAssoc>();
}
