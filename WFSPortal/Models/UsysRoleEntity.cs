using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoleEntity")]
public partial class UsysRoleEntity
{
    [StringLength(50)]
    public string EntityName { get; set; } = null!;

    [Key]
    [Column("RoleEntityGUID")]
    public Guid RoleEntityGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("RoleGUID")]
    public Guid RoleGuid { get; set; }

    [ForeignKey("EntityName")]
    [InverseProperty("UsysRoleEntities")]
    public virtual UsysEntity EntityNameNavigation { get; set; } = null!;

    [ForeignKey("RoleGuid")]
    [InverseProperty("UsysRoleEntities")]
    public virtual UsysRole Role { get; set; } = null!;
}
