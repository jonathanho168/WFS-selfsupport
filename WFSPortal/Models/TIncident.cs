using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tIncident")]
public partial class TIncident
{
    [Column("IncidentID")]
    [StringLength(80)]
    public string IncidentId { get; set; } = null!;

    [StringLength(15)]
    public string IncidentTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IncidentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReportedDate { get; set; }

    public bool ReportableFlag { get; set; }

    [StringLength(15)]
    public string OccupationalIncidentTypeCode { get; set; } = null!;

    public bool OccupationalIncidentFlag { get; set; }

    public string? OccupationalComments { get; set; }

    public bool EmployerPremisesFlag { get; set; }

    [StringLength(15)]
    public string LocationCode { get; set; } = null!;

    [StringLength(15)]
    public string DepartmentCode { get; set; } = null!;

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

    public string? UnsafeConditions { get; set; }

    public string? UnsafeEquipment { get; set; }

    public string? UnsafePractices { get; set; }

    [StringLength(30)]
    public string? RegulatingAuthority { get; set; }

    [StringLength(30)]
    public string? InvestigatingParty { get; set; }

    public string? Witnesses { get; set; }

    public string? CauseSummary { get; set; }

    public string? IncidentSummary { get; set; }

    [Key]
    [Column("IncidentGUID")]
    public Guid IncidentGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool? RecordableIncidence { get; set; }

    public bool? RecordableFlag { get; set; }

    public bool? PoliceContacted { get; set; }

    public string? ResultOfPoliceContact { get; set; }

    [StringLength(15)]
    public string CompanyCode { get; set; } = null!;

    [Column("SupervisorOnLocationPersonGUID")]
    public Guid? SupervisorOnLocationPersonGuid { get; set; }

    public bool RiskAssessmentFlag { get; set; }

    public bool SafeWorkMethodStatementPreparedFlag { get; set; }

    public string? NoRiskAssessmentDetails { get; set; }

    public string? NoSafeWorkMethodStatementPreparedDetails { get; set; }

    public string? PreventRecurrenceActionTaken { get; set; }

    [StringLength(30)]
    public string? FirstWitnessName { get; set; }

    [StringLength(20)]
    public string? FirstWitnessContactNumber { get; set; }

    [StringLength(30)]
    public string? SecondWitnessName { get; set; }

    [StringLength(20)]
    public string? SecondWitnessContactNumber { get; set; }

    [ForeignKey("CompanyCode")]
    [InverseProperty("TIncidents")]
    public virtual TCompany CompanyCodeNavigation { get; set; } = null!;

    [ForeignKey("CountryCode")]
    [InverseProperty("TIncidents")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("DepartmentCode")]
    [InverseProperty("TIncidents")]
    public virtual TDepartment DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("IncidentTypeCode")]
    [InverseProperty("TIncidents")]
    public virtual TIncidentType IncidentTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("LocationCode")]
    [InverseProperty("TIncidents")]
    public virtual TLocation LocationCodeNavigation { get; set; } = null!;

    [ForeignKey("OccupationalIncidentTypeCode")]
    [InverseProperty("TIncidents")]
    public virtual TOccupationalIncidentType OccupationalIncidentTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TIncidents")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;

    [ForeignKey("SupervisorOnLocationPersonGuid")]
    [InverseProperty("TIncidents")]
    public virtual TPerson? SupervisorOnLocationPerson { get; set; }

    [InverseProperty("Incident")]
    public virtual ICollection<TPersonIncident> TPersonIncidents { get; set; } = new List<TPersonIncident>();
}
