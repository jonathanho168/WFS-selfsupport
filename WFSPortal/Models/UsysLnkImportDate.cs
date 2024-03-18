using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportDate")]
public partial class UsysLnkImportDate
{
    [Column("LnkImportMasterGUID")]
    public Guid LnkImportMasterGuid { get; set; }

    public string? ImportDateDescription { get; set; }

    [Key]
    [Column("LnkImportDateGUID")]
    public Guid LnkImportDateGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LnkImportMasterGuid")]
    [InverseProperty("UsysLnkImportDates")]
    public virtual UsysLnkImportMaster LnkImportMaster { get; set; } = null!;
}
