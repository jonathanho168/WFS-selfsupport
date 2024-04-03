using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tLocation")]
[Index("LocationGuid", Name = "RG_tLocation", IsUnique = true)]
public partial class TLocation
{
    [Key]
    [StringLength(15)]
    public string LocationCode { get; set; } = null!;

    [StringLength(20)]
    public string? AreaCode { get; set; }

    [StringLength(20)]
    public string? Phone { get; set; }

    [StringLength(255)]
    public string? Address { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(30)]
    public string? County { get; set; }

    [StringLength(15)]
    public string StateProvinceCode { get; set; } = null!;

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [StringLength(12)]
    public string? PostalCode { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("LocationGUID")]
    public Guid LocationGuid { get; set; }

    [StringLength(20)]
    public string? InternationalPrefix { get; set; }

    [StringLength(20)]
    public string? NationalPrefix { get; set; }

    public int RowVersion { get; set; }

    public int? LeaveWeeks { get; set; }

    [Column("MFMLAWeeks")]
    public int? Mfmlaweeks { get; set; }

    [Column("FMLAContactPerson")]
    [StringLength(128)]
    public string? FmlacontactPerson { get; set; }

    [Column("FMLAPosterLocation")]
    [StringLength(128)]
    public string? FmlaposterLocation { get; set; }

    [Column("FMLAContactLocation")]
    [StringLength(128)]
    public string? FmlacontactLocation { get; set; }

    public string? LocationDescription { get; set; }

    [StringLength(15)]
    public string CensusMetropolitanAreaCode { get; set; } = null!;

    [ForeignKey("CensusMetropolitanAreaCode")]
    [InverseProperty("TLocations")]
    public virtual TCensusMetropolitanArea CensusMetropolitanAreaCodeNavigation { get; set; } = null!;

    [ForeignKey("CountryCode")]
    [InverseProperty("TLocations")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TLocations")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;

    [InverseProperty("GradeLocationCodeNavigation")]
    public virtual ICollection<TGradeHist> TGradeHists { get; set; } = new List<TGradeHist>();

    [InverseProperty("LocationCodeNavigation")]
    public virtual ICollection<TIncident> TIncidents { get; set; } = new List<TIncident>();

    [InverseProperty("GradeLocationCodeNavigation")]
    public virtual ICollection<TPersonJobHist> TPersonJobHists { get; set; } = new List<TPersonJobHist>();

    [InverseProperty("LocationCodeNavigation")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHists { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("LocationCodeNavigation")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("LocationCodeNavigation")]
    public virtual ICollection<TPersonW2> TPersonW2s { get; set; } = new List<TPersonW2>();

    [InverseProperty("LocationCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHists { get; set; } = new List<TPositionHist>();

    [InverseProperty("LocationCodeNavigation")]
    public virtual ICollection<TRequisition> TRequisitions { get; set; } = new List<TRequisition>();

    [InverseProperty("LocationCodeNavigation")]
    public virtual ICollection<UsysCsflocation> UsysCsflocations { get; set; } = new List<UsysCsflocation>();
}
