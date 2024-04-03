using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCSFField")]
public partial class UsysCsffield
{
    [Key]
    [Column("CSFFieldGuid")]
    public Guid CsffieldGuid { get; set; }

    [Column("CSFCode")]
    [StringLength(15)]
    public string Csfcode { get; set; } = null!;

    [StringLength(200)]
    public string TableName { get; set; } = null!;

    [StringLength(200)]
    public string ColumnName { get; set; } = null!;

    [Column("RequiredForCSFFlag")]
    public bool RequiredForCsfflag { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("CSFFieldDescription")]
    public string? CsffieldDescription { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("Csfcode")]
    [InverseProperty("UsysCsffields")]
    public virtual UsysCsf CsfcodeNavigation { get; set; } = null!;
}
