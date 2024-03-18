using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tApplicationStatus")]
[Index("ApplicationStatusGuid", Name = "RG_tApplicationStatus", IsUnique = true)]
public partial class TApplicationStatus
{
    [Key]
    [StringLength(15)]
    public string ApplicationStatusCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("ApplicationStatusGUID")]
    public Guid ApplicationStatusGuid { get; set; }

    public int RowVersion { get; set; }

    public bool ActiveFlag { get; set; }

    public bool ApplicationLockedFlag { get; set; }

    public int Sequence { get; set; }

    public bool WithdrawnFlag { get; set; }

    public string? ApplicationStatusDescription { get; set; }

    public string? CandidateStatusDescription { get; set; }

    public bool ForwardedForConsiderationFlag { get; set; }

    public bool ExtendedOfferFlag { get; set; }

    public bool EvaluationProcessFlag { get; set; }

    [InverseProperty("ApplicationStatusCodeNavigation")]
    public virtual ICollection<TPersonApplicationStatusHist> TPersonApplicationStatusHists { get; set; } = new List<TPersonApplicationStatusHist>();

    [InverseProperty("ApplicationStatusCodeNavigation")]
    public virtual ICollection<TPersonApplication> TPersonApplications { get; set; } = new List<TPersonApplication>();
}
