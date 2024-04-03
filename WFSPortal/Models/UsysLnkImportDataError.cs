using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportDataError")]
public partial class UsysLnkImportDataError
{
    [Column("LnkImportLogGUID")]
    public Guid LnkImportLogGuid { get; set; }

    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [StringLength(255)]
    public string ValidationMessage { get; set; } = null!;

    [StringLength(255)]
    public string? Data { get; set; }

    [Key]
    [Column("LnkImportDataErrorGUID")]
    public Guid LnkImportDataErrorGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LnkImportLogGuid")]
    [InverseProperty("UsysLnkImportDataErrors")]
    public virtual UsysLnkImportLog LnkImportLog { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("UsysLnkImportDataErrors")]
    public virtual TPerson? Person { get; set; }
}
