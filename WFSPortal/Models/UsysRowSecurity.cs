using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRowSecurity")]
public partial class UsysRowSecurity
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    public bool LockedFlag { get; set; }

    [Key]
    [Column("RowSecurityGUID")]
    public Guid RowSecurityGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("UserGUID")]
    public Guid UserGuid { get; set; }

    public bool ViewPayFlag { get; set; }

    public bool CandidateDataOnlyFlag { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("UsysRowSecurities")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysRowSecurities")]
    public virtual UsysUser User { get; set; } = null!;
}
