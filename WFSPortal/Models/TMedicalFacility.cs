using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tMedicalFacility")]
[Index("MedicalFacilityGuid", Name = "RG_tMedicalFacility", IsUnique = true)]
public partial class TMedicalFacility
{
    [Key]
    [StringLength(15)]
    public string MedicalFacilityCode { get; set; } = null!;

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

    [Column("MedicalFacilityGUID")]
    public Guid MedicalFacilityGuid { get; set; }

    [StringLength(20)]
    public string? InternationalPrefix { get; set; }

    [StringLength(20)]
    public string? NationalPrefix { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Name { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TMedicalFacilities")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TMedicalFacilities")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;

    [InverseProperty("MedicalFacilityCodeNavigation")]
    public virtual ICollection<TPersonDrugTest> TPersonDrugTestMedicalFacilityCodeNavigations { get; set; } = new List<TPersonDrugTest>();

    [InverseProperty("ScheduledMedicalFacilityCodeNavigation")]
    public virtual ICollection<TPersonDrugTest> TPersonDrugTestScheduledMedicalFacilityCodeNavigations { get; set; } = new List<TPersonDrugTest>();

    [InverseProperty("MedicalFacilityCodeNavigation")]
    public virtual ICollection<TPersonIncidentTreatment> TPersonIncidentTreatments { get; set; } = new List<TPersonIncidentTreatment>();

    [InverseProperty("PrimaryMedicalFacilityCodeNavigation")]
    public virtual ICollection<TPersonMedical> TPersonMedicals { get; set; } = new List<TPersonMedical>();
}
