using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonAchievement")]
public partial class TPersonAchievement
{
    [Key]
    [Column("PersonAchievementGUID")]
    public Guid PersonAchievementGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(80)]
    public string Achievement { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AchievedDate { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonAchievements")]
    public virtual TPerson Person { get; set; } = null!;
}
