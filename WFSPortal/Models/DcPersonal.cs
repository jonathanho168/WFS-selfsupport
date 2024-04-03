using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonal")]
public partial class DcPersonal
{
    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BirthCountryCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BirthPlace { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CitizenCountryCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DisabilityCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DriversLicenseNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DriversLicenseClass { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DriversLicenseStateProvinceCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DriversLicenseExpireDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EthnicGroupCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FamilyStatusCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GenderCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WorkEligibilityProof { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LatestMilitaryDischargeDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeathDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AutoInsuranceExpirationDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AutoInsuranceCarrier { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AutoInsurancePolicyNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DisabilityDocument { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ChildAbuseClearance { get; set; }

    [Column("FBIClearance")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Fbiclearance { get; set; }

    [Column("PAStatePoliceClearance")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PastatePoliceClearance { get; set; }

    [Column("DEANumberExpiration")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DeanumberExpiration { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContractExpiration { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LicensureExpiration { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LiabilityInsuranceExpiration { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VisaRequirement { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EmployerSponsorship { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatePoliceClearance { get; set; }
}
