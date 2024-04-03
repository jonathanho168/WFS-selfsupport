using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysDatabaseChange")]
public partial class UsysDatabaseChange
{
    [Key]
    [Column("DatabaseChangeGUID")]
    public Guid DatabaseChangeGuid { get; set; }

    [Column("UserGUID")]
    public Guid UserGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ChangeDateTime { get; set; }

    public string ChangesScript { get; set; } = null!;

    public int RowVersion { get; set; }

    public bool ScriptRunFlag { get; set; }

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysDatabaseChanges")]
    public virtual UsysUser User { get; set; } = null!;
}
