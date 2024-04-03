using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonCommunityActivity")]
public partial class TPersonCommunityActivity
{
    [Key]
    [Column("PersonCommunityActivityGUID")]
    public Guid PersonCommunityActivityGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(80)]
    public string CommunityActivity { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [StringLength(80)]
    public string? Role { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonCommunityActivities")]
    public virtual TPerson Person { get; set; } = null!;
}
