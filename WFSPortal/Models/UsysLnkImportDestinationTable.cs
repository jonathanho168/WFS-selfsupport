using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportDestinationTable")]
public partial class UsysLnkImportDestinationTable
{
    [Key]
    [Column("LnkImportDestinationTableGUID")]
    public Guid LnkImportDestinationTableGuid { get; set; }

    [StringLength(50)]
    public string DestinationTableName { get; set; } = null!;

    public int Sequence { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("LnkImportDestinationTable")]
    public virtual ICollection<UsysLnkImportFieldDef> UsysLnkImportFieldDefs { get; set; } = new List<UsysLnkImportFieldDef>();
}
