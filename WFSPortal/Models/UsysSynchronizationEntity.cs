using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysSynchronizationEntity")]
public partial class UsysSynchronizationEntity
{
    [Key]
    [Column("SynchronizationEntityGUID")]
    public Guid SynchronizationEntityGuid { get; set; }

    [StringLength(50)]
    public string EntityName { get; set; } = null!;

    public bool PushDataFlag { get; set; }

    public bool PullDataFlag { get; set; }

    public bool AllowDeletesFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("EntityName")]
    [InverseProperty("UsysSynchronizationEntity")]
    public virtual UsysEntity EntityNameNavigation { get; set; } = null!;
}
