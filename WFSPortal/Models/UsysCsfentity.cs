using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCSFEntity")]
public partial class UsysCsfentity
{
    [Key]
    [Column("CSFEntityGuid")]
    public Guid CsfentityGuid { get; set; }

    [StringLength(50)]
    public string EntityName { get; set; } = null!;

    [Column("CSFCode")]
    [StringLength(15)]
    public string Csfcode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("Csfcode")]
    [InverseProperty("UsysCsfentities")]
    public virtual UsysCsf CsfcodeNavigation { get; set; } = null!;

    [ForeignKey("EntityName")]
    [InverseProperty("UsysCsfentities")]
    public virtual UsysEntity EntityNameNavigation { get; set; } = null!;
}
