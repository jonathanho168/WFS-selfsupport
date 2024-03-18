using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonSpeakingEngagement")]
public partial class TPersonSpeakingEngagement
{
    [Key]
    [Column("PersonSpeakingEngagementGUID")]
    public Guid PersonSpeakingEngagementGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(80)]
    public string SpeakingEngagementDescription { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PresentedDate { get; set; }

    [StringLength(80)]
    public string? EventLocation { get; set; }

    [StringLength(80)]
    public string? Audience { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonSpeakingEngagements")]
    public virtual TPerson Person { get; set; } = null!;
}
