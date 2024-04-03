using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tOrgPublisherPositionType")]
[Index("OrgPublisherPositionTypeGuid", Name = "RG_tOrgPublisherPositionType", IsUnique = true)]
public partial class TOrgPublisherPositionType
{
    [Key]
    [StringLength(15)]
    public string OrgPublisherPositionTypeCode { get; set; } = null!;

    [Column("OrgPublisherPositionTypeGUID")]
    public Guid OrgPublisherPositionTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? OrgPublisherPositionTypeDescription { get; set; }

    [InverseProperty("OrgPublisherPositionTypeCodeNavigation")]
    public virtual ICollection<TJob> TJobs { get; set; } = new List<TJob>();

    [InverseProperty("OrgPublisherPositionTypeCodeNavigation")]
    public virtual ICollection<TPersonJobHist> TPersonJobHists { get; set; } = new List<TPersonJobHist>();

    [InverseProperty("OrgPublisherPositionTypeCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHists { get; set; } = new List<TPositionHist>();
}
