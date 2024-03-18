using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCSFUser")]
public partial class UsysCsfuser
{
    [Key]
    [Column("CSFUserGuid")]
    public Guid CsfuserGuid { get; set; }

    public Guid UserGuid { get; set; }

    [Column("CSFCode")]
    [StringLength(15)]
    public string Csfcode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("Csfcode")]
    [InverseProperty("UsysCsfusers")]
    public virtual UsysCsf CsfcodeNavigation { get; set; } = null!;

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysCsfusers")]
    public virtual UsysUser User { get; set; } = null!;
}
