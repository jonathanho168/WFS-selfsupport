using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCodeFilterTable")]
[Index("CodeFilterTableGuid", Name = "RG_USysCodeFilterTable", IsUnique = true)]
public partial class UsysCodeFilterTable
{
    [StringLength(15)]
    public string CodeFilterGroupCode { get; set; } = null!;

    [StringLength(128)]
    public string CodeTable { get; set; } = null!;

    public bool? InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Key]
    public Guid CodeFilterTableGuid { get; set; }

    [ForeignKey("CodeFilterGroupCode")]
    [InverseProperty("UsysCodeFilterTables")]
    public virtual UsysCodeFilterGroup CodeFilterGroupCodeNavigation { get; set; } = null!;

    [InverseProperty("CodeFilterTable")]
    public virtual ICollection<UsysCodeFilterDetail> UsysCodeFilterDetails { get; set; } = new List<UsysCodeFilterDetail>();
}
