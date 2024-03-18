using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportSource")]
public partial class UsysLnkImportSource
{
    [Column("LnkImportMasterGUID")]
    public Guid LnkImportMasterGuid { get; set; }

    public string? ImportSourceDescription { get; set; }

    [StringLength(15)]
    public string ImportSourceTypeCode { get; set; } = null!;

    [StringLength(2000)]
    public string? ImportFilePath { get; set; }

    [StringLength(2000)]
    public string? FileArchivePath { get; set; }

    public bool DelimitedFileFlag { get; set; }

    [StringLength(15)]
    public string? FileDelimiter { get; set; }

    public bool TextQualifierFlag { get; set; }

    [StringLength(15)]
    public string? TextQualifier { get; set; }

    public int? NumberOfHeaderRows { get; set; }

    [Key]
    [Column("LnkImportSourceGUID")]
    public Guid LnkImportSourceGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Column("SQLTable")]
    [StringLength(115)]
    public string? Sqltable { get; set; }

    [ForeignKey("ImportSourceTypeCode")]
    [InverseProperty("UsysLnkImportSources")]
    public virtual UsysLnkImportSourceType ImportSourceTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("LnkImportMasterGuid")]
    [InverseProperty("UsysLnkImportSources")]
    public virtual UsysLnkImportMaster LnkImportMaster { get; set; } = null!;

    [InverseProperty("LnkImportSource")]
    public virtual ICollection<UsysLnkImportFieldDef> UsysLnkImportFieldDefs { get; set; } = new List<UsysLnkImportFieldDef>();

    [InverseProperty("LnkImportSource")]
    public virtual ICollection<UsysLnkImportSourceParameter> UsysLnkImportSourceParameters { get; set; } = new List<UsysLnkImportSourceParameter>();
}
