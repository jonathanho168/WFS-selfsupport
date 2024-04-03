using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCSFLocation")]
public partial class UsysCsflocation
{
    [Key]
    [Column("CSFLocationGuid")]
    public Guid CsflocationGuid { get; set; }

    [Column("CSFCode")]
    [StringLength(15)]
    public string Csfcode { get; set; } = null!;

    [StringLength(15)]
    public string LocationCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("Csfcode")]
    [InverseProperty("UsysCsflocations")]
    public virtual UsysCsf CsfcodeNavigation { get; set; } = null!;

    [ForeignKey("LocationCode")]
    [InverseProperty("UsysCsflocations")]
    public virtual TLocation LocationCodeNavigation { get; set; } = null!;
}
