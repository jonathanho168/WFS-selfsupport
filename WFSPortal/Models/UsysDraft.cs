using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysDraft")]
public partial class UsysDraft
{
    [Key]
    [Column("DraftGUID")]
    public Guid DraftGuid { get; set; }

    [Column("UserGUID")]
    public Guid? UserGuid { get; set; }

    [Column("EntityGUID")]
    [StringLength(50)]
    public string? EntityGuid { get; set; }

    [Column("ContextGUID")]
    public Guid ContextGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    public int RowVersion { get; set; }

    [Column("TaskXML", TypeName = "xml")]
    public string TaskXml { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastAccessedTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastSavedTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastPersistedTime { get; set; }

    [Column("PortalGUID")]
    public Guid? PortalGuid { get; set; }

    [ForeignKey("EntityGuid")]
    [InverseProperty("UsysDrafts")]
    public virtual UsysEntity? Entity { get; set; }

    [ForeignKey("PortalGuid")]
    [InverseProperty("UsysDrafts")]
    public virtual UsysPortal? Portal { get; set; }

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysDrafts")]
    public virtual UsysUser? User { get; set; }
}
