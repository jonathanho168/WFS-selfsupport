using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportType")]
public partial class UsysLnkImportType
{
    [Key]
    [StringLength(15)]
    public string ImportTypeCode { get; set; } = null!;

    public string? ImportTypeDescription { get; set; }

    [Column("ImportTypeGUID")]
    public Guid ImportTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("ImportTypeCodeNavigation")]
    public virtual ICollection<UsysLnkImportMaster> UsysLnkImportMasters { get; set; } = new List<UsysLnkImportMaster>();
}
