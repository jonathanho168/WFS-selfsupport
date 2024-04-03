using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonal")]
[Index("PersonalGuid", Name = "RG_tPersonal", IsUnique = true)]
public partial class TPersonal
{
    [Key]
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string BirthCountryCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [StringLength(40)]
    public string? BirthPlace { get; set; }

    [StringLength(15)]
    public string CitizenCountryCode { get; set; } = null!;

    [StringLength(15)]
    public string DisabilityCode { get; set; } = null!;

    [StringLength(30)]
    public string? DriversLicenseNumber { get; set; }

    [StringLength(10)]
    public string? DriversLicenseClass { get; set; }

    [StringLength(15)]
    public string DriversLicenseStateProvinceCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DriversLicenseExpireDate { get; set; }

    [StringLength(15)]
    public string EthnicGroupCode { get; set; } = null!;

    [StringLength(15)]
    public string FamilyStatusCode { get; set; } = null!;

    [StringLength(15)]
    public string GenderCode { get; set; } = null!;

    public byte[]? Picture { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PictureDate { get; set; }

    [StringLength(50)]
    public string? WorkEligibilityProof { get; set; }

    public bool OverEighteenFlag { get; set; }

    public bool EligibleToWorkFlag { get; set; }

    public bool LegalConvictionFlag { get; set; }

    public string? LegalConvictionComments { get; set; }

    public bool OtherEmploymentFlag { get; set; }

    public string? OtherEmploymentComments { get; set; }

    public bool EverBeenFiredFlag { get; set; }

    public string? EverBeenFiredComments { get; set; }

    [Column("PersonalGUID")]
    public Guid PersonalGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LatestMilitaryDischargeDate { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeathDate { get; set; }

    public string? Comments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AutoInsuranceExpirationDate { get; set; }

    [StringLength(80)]
    public string? AutoInsuranceCarrier { get; set; }

    [StringLength(80)]
    public string? AutoInsurancePolicyNumber { get; set; }

    public byte[]? DisabilityDocument { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChildAbuseClearance { get; set; }

    [Column("PAStatePoliceClearance", TypeName = "datetime")]
    public DateTime? PastatePoliceClearance { get; set; }

    [Column("DEANumberExpiration", TypeName = "datetime")]
    public DateTime? DeanumberExpiration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ContractExpiration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LicensureExpiration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LiabilityInsuranceExpiration { get; set; }

    public bool? VisaRequirement { get; set; }

    [StringLength(80)]
    public string? EmployerSponsorship { get; set; }

    public bool DataStorageConsentFlag { get; set; }

    [Column("ElectronicDelieveryConsent1095CFlag")]
    public bool ElectronicDelieveryConsent1095Cflag { get; set; }

    public string? GenderIdentification { get; set; }

    [Column("DMVCheckDate", TypeName = "datetime")]
    public DateTime? DmvcheckDate { get; set; }

    public bool? DrivingCompanyVehicle { get; set; }

    public bool? OwnVehicleCompanyBusiness { get; set; }

    public bool? OwnVehicleWithClients { get; set; }

    public bool PreviousEmploymentWithOrganizationFlag { get; set; }

    [ForeignKey("BirthCountryCode")]
    [InverseProperty("TPersonalBirthCountryCodeNavigations")]
    public virtual TCountry BirthCountryCodeNavigation { get; set; } = null!;

    [ForeignKey("CitizenCountryCode")]
    [InverseProperty("TPersonalCitizenCountryCodeNavigations")]
    public virtual TCountry CitizenCountryCodeNavigation { get; set; } = null!;

    [ForeignKey("DisabilityCode")]
    [InverseProperty("TPersonals")]
    public virtual TDisability DisabilityCodeNavigation { get; set; } = null!;

    [ForeignKey("DriversLicenseStateProvinceCode")]
    [InverseProperty("TPersonals")]
    public virtual TStateProvince DriversLicenseStateProvinceCodeNavigation { get; set; } = null!;

    [ForeignKey("EthnicGroupCode")]
    [InverseProperty("TPersonals")]
    public virtual TEthnicGroup EthnicGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("FamilyStatusCode")]
    [InverseProperty("TPersonals")]
    public virtual TFamilyStatus FamilyStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("GenderCode")]
    [InverseProperty("TPersonals")]
    public virtual TGender GenderCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonal")]
    public virtual TPerson Person { get; set; } = null!;
}
