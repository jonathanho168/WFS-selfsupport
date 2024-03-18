using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPhysician")]
[Index("PhysicianGuid", Name = "RG_tPhysician", IsUnique = true)]
public partial class TPhysician
{
    [Key]
    [StringLength(15)]
    public string PhysicianCode { get; set; } = null!;

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

    [Column("PhysicianGUID")]
    public Guid PhysicianGuid { get; set; }

    [StringLength(15)]
    public string PhysicianTypeCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [StringLength(20)]
    public string? InternationalPrefix { get; set; }

    [StringLength(20)]
    public string? NationalPrefix { get; set; }

    public int RowVersion { get; set; }

    public string? Name { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TPhysicians")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("PhysicianTypeCode")]
    [InverseProperty("TPhysicians")]
    public virtual TPhysicianType PhysicianTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TPhysicians")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;

    [InverseProperty("PrimaryPhysicianCodeNavigation")]
    public virtual ICollection<TPersonBenefitHist> TPersonBenefitHists { get; set; } = new List<TPersonBenefitHist>();

    [InverseProperty("PrimaryPhysicianCodeNavigation")]
    public virtual ICollection<TPersonFutureEnrollment> TPersonFutureEnrollmentPrimaryPhysicianCodeNavigations { get; set; } = new List<TPersonFutureEnrollment>();

    [InverseProperty("PrimaryPhysicianCodeOriginalNavigation")]
    public virtual ICollection<TPersonFutureEnrollment> TPersonFutureEnrollmentPrimaryPhysicianCodeOriginalNavigations { get; set; } = new List<TPersonFutureEnrollment>();

    [InverseProperty("PhysicianCodeNavigation")]
    public virtual ICollection<TPersonIncidentTreatment> TPersonIncidentTreatments { get; set; } = new List<TPersonIncidentTreatment>();

    [InverseProperty("PrimaryPhysicianCodeNavigation")]
    public virtual ICollection<TPersonMedical> TPersonMedicals { get; set; } = new List<TPersonMedical>();
}
