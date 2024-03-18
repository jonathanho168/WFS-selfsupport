using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonMedical")]
[Index("PersonMedicalGuid", Name = "RG_tPersonMedical", IsUnique = true)]
public partial class TPersonMedical
{
    [Key]
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string PrimaryPhysicianCode { get; set; } = null!;

    [StringLength(15)]
    public string PrimaryMedicalFacilityCode { get; set; } = null!;

    [StringLength(15)]
    public string BloodTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? LastPhysicalDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NextPhysicalDate { get; set; }

    public bool TobaccoUserFlag { get; set; }

    [StringLength(80)]
    public string? KnownHealthIssues { get; set; }

    [StringLength(10)]
    public string? Height { get; set; }

    public int? Weight { get; set; }

    [StringLength(10)]
    public string? BloodPressure { get; set; }

    public int? Pulse { get; set; }

    [StringLength(80)]
    public string? Allergies { get; set; }

    [StringLength(80)]
    public string? Cardiovascular { get; set; }

    [StringLength(80)]
    public string? GeneralHealthCondition { get; set; }

    [Column("PersonMedicalGUID")]
    public Guid PersonMedicalGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [Column("COVID19VaccinatedFlag")]
    public bool Covid19vaccinatedFlag { get; set; }

    [ForeignKey("BloodTypeCode")]
    [InverseProperty("TPersonMedicals")]
    public virtual TBloodType BloodTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonMedical")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PrimaryMedicalFacilityCode")]
    [InverseProperty("TPersonMedicals")]
    public virtual TMedicalFacility PrimaryMedicalFacilityCodeNavigation { get; set; } = null!;

    [ForeignKey("PrimaryPhysicianCode")]
    [InverseProperty("TPersonMedicals")]
    public virtual TPhysician PrimaryPhysicianCodeNavigation { get; set; } = null!;
}
