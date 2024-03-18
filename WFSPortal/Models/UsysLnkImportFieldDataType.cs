using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportFieldDataType")]
public partial class UsysLnkImportFieldDataType
{
    [Key]
    [StringLength(15)]
    public string LnkImportFieldDataTypeCode { get; set; } = null!;

    public string? ImportFieldDataTypeDescription { get; set; }

    [Column("LnkImportFieldDataTypeGUID")]
    public Guid LnkImportFieldDataTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("LnkImportFieldDataTypeCodeNavigation")]
    public virtual ICollection<UsysLnkImportFieldDef> UsysLnkImportFieldDefs { get; set; } = new List<UsysLnkImportFieldDef>();
}
