using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tFacility")]
[Index("FacilityGuid", Name = "RG_tFacility", IsUnique = true)]
public partial class TFacility
{
    [Column("FacilityGUID")]
    public Guid FacilityGuid { get; set; }

    [StringLength(15)]
    public string TrainingProviderCode { get; set; } = null!;

    [Key]
    [StringLength(15)]
    public string FacilityCode { get; set; } = null!;

    [StringLength(255)]
    public string? Address { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(15)]
    public string StateProvinceCode { get; set; } = null!;

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [StringLength(12)]
    public string? PostalCode { get; set; }

    [StringLength(20)]
    public string? AreaCode { get; set; }

    [StringLength(20)]
    public string? Phone { get; set; }

    public bool MultiScheduleFlag { get; set; }

    public int? MaximumCapacity { get; set; }

    public bool HandicapAccessFlag { get; set; }

    public string? DrivingDirections { get; set; }

    public bool InactiveFlag { get; set; }

    [StringLength(15)]
    public string TimeZoneCode { get; set; } = null!;

    [StringLength(20)]
    public string? InternationalPrefix { get; set; }

    [StringLength(20)]
    public string? NationalPrefix { get; set; }

    public int RowVersion { get; set; }

    public string? FacilityDescription { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TFacilities")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TFacilities")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;

    [InverseProperty("FacilityCodeNavigation")]
    public virtual ICollection<TClassSchedule> TClassSchedules { get; set; } = new List<TClassSchedule>();

    [InverseProperty("FacilityCodeNavigation")]
    public virtual ICollection<TClass> TClasses { get; set; } = new List<TClass>();

    [ForeignKey("TimeZoneCode")]
    [InverseProperty("TFacilities")]
    public virtual TTimeZone TimeZoneCodeNavigation { get; set; } = null!;

    [ForeignKey("TrainingProviderCode")]
    [InverseProperty("TFacilities")]
    public virtual TTrainingProvider TrainingProviderCodeNavigation { get; set; } = null!;
}
