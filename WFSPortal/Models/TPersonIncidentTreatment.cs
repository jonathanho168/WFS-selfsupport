using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonIncidentTreatment")]
public partial class TPersonIncidentTreatment
{
    [Key]
    [Column("PersonIncidentTreatmentGUID")]
    public Guid PersonIncidentTreatmentGuid { get; set; }

    [Column("PersonIncidentGUID")]
    public Guid PersonIncidentGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TreatmentDate { get; set; }

    [StringLength(15)]
    public string PhysicianCode { get; set; } = null!;

    [StringLength(15)]
    public string MedicalFacilityCode { get; set; } = null!;

    public string? TreatmentDetails { get; set; }

    public int RowVersion { get; set; }

    public string? FacilityandLocation { get; set; }

    [ForeignKey("MedicalFacilityCode")]
    [InverseProperty("TPersonIncidentTreatments")]
    public virtual TMedicalFacility MedicalFacilityCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonIncidentGuid")]
    [InverseProperty("TPersonIncidentTreatments")]
    public virtual TPersonIncident PersonIncident { get; set; } = null!;

    [ForeignKey("PhysicianCode")]
    [InverseProperty("TPersonIncidentTreatments")]
    public virtual TPhysician PhysicianCodeNavigation { get; set; } = null!;
}
