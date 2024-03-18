using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTimeZone")]
[Index("TimeZoneGuid", Name = "RG_tTimeZone", IsUnique = true)]
public partial class TTimeZone
{
    [Key]
    [StringLength(15)]
    public string TimeZoneCode { get; set; } = null!;

    [Column("TimeZoneGUID")]
    public Guid TimeZoneGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(80)]
    public string? SystemTimeZoneDescription { get; set; }

    public string? TimeZoneDescription { get; set; }

    [InverseProperty("TimeZoneCodeNavigation")]
    public virtual ICollection<TFacility> TFacilities { get; set; } = new List<TFacility>();

    [InverseProperty("TimeZoneCodeNavigation")]
    public virtual ICollection<TPersonTimeGroupHist> TPersonTimeGroupHists { get; set; } = new List<TPersonTimeGroupHist>();
}
