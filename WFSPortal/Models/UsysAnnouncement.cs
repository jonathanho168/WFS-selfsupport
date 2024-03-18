using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysAnnouncements")]
[Index("ModuleDefinitionGuid", Name = "IX_USysAnnouncments_ModuleDefinitionGUID")]
[Index("AnnouncementsGuid", Name = "RG_USysAnnouncements", IsUnique = true)]
public partial class UsysAnnouncement
{
    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(150)]
    public string? MoreLink { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    public int? ViewOrder { get; set; }

    [Key]
    [Column("AnnouncementsGUID")]
    public Guid AnnouncementsGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("ModuleDefinitionGUID")]
    public Guid? ModuleDefinitionGuid { get; set; }

    public Guid? CreatedByUserGuid { get; set; }

    public string? Description { get; set; }

    public string? Title { get; set; }

    [ForeignKey("CreatedByUserGuid")]
    [InverseProperty("UsysAnnouncements")]
    public virtual UsysUser? CreatedByUser { get; set; }

    [ForeignKey("ModuleDefinitionGuid")]
    [InverseProperty("UsysAnnouncements")]
    public virtual UsysModuleDefinition? ModuleDefinition { get; set; }
}
