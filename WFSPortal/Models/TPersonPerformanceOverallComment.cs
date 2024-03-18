using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonPerformanceOverallComments")]
public partial class TPersonPerformanceOverallComment
{
    [Key]
    public Guid PersonPerformanceOverallCommentsGuid { get; set; }

    public Guid PersonPerformanceGuid { get; set; }

    [StringLength(15)]
    public string PerformanceParticipantTypeCode { get; set; } = null!;

    public string? Comments { get; set; }

    [StringLength(10)]
    public string RowVersion { get; set; } = null!;

    [ForeignKey("PerformanceParticipantTypeCode")]
    [InverseProperty("TPersonPerformanceOverallComments")]
    public virtual TPerformanceParticipantType PerformanceParticipantTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonPerformanceGuid")]
    [InverseProperty("TPersonPerformanceOverallComments")]
    public virtual TPersonPerformanceHist PersonPerformance { get; set; } = null!;
}
