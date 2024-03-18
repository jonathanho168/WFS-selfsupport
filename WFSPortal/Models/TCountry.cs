using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCountry")]
[Index("CountryGuid", Name = "RG_tCountry", IsUnique = true)]
public partial class TCountry
{
    [Key]
    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [StringLength(15)]
    public string CountryCurrencyCode { get; set; } = null!;

    [StringLength(30)]
    public string? NationalInsurancePrompt { get; set; }

    [Column("CountryGUID")]
    public Guid CountryGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? CountryDescription { get; set; }

    [ForeignKey("CountryCurrencyCode")]
    [InverseProperty("TCountries")]
    public virtual TCurrency CountryCurrencyCodeNavigation { get; set; } = null!;

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TBenefitPlanAdministrator> TBenefitPlanAdministrators { get; set; } = new List<TBenefitPlanAdministrator>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TCarrier> TCarriers { get; set; } = new List<TCarrier>();

    [InverseProperty("AcadgecountryCodeNavigation")]
    public virtual ICollection<TCompany> TCompanyAcadgecountryCodeNavigations { get; set; } = new List<TCompany>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TCompany> TCompanyCountryCodeNavigations { get; set; } = new List<TCompany>();

    [InverseProperty("MailCountryCodeNavigation")]
    public virtual ICollection<TCompany> TCompanyMailCountryCodeNavigations { get; set; } = new List<TCompany>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TExternalRecruiter> TExternalRecruiters { get; set; } = new List<TExternalRecruiter>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TFacility> TFacilities { get; set; } = new List<TFacility>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TIncident> TIncidents { get; set; } = new List<TIncident>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TLocation> TLocations { get; set; } = new List<TLocation>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TMedicalFacility> TMedicalFacilities { get; set; } = new List<TMedicalFacility>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TPerformanceParticipant> TPerformanceParticipants { get; set; } = new List<TPerformanceParticipant>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TPersonAddress> TPersonAddresses { get; set; } = new List<TPersonAddress>();

    [InverseProperty("InstitutionCountryCodeNavigation")]
    public virtual ICollection<TPersonDirectDeposit> TPersonDirectDeposits { get; set; } = new List<TPersonDirectDeposit>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TPersonEmergency> TPersonEmergencies { get; set; } = new List<TPersonEmergency>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TPersonEmploymentHist> TPersonEmploymentHists { get; set; } = new List<TPersonEmploymentHist>();

    [InverseProperty("ServiceCountryCodeNavigation")]
    public virtual ICollection<TPersonMilitaryHist> TPersonMilitaryHists { get; set; } = new List<TPersonMilitaryHist>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TPersonNationalId> TPersonNationalIds { get; set; } = new List<TPersonNationalId>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TPersonOtherName> TPersonOtherNames { get; set; } = new List<TPersonOtherName>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TPersonPassport> TPersonPassports { get; set; } = new List<TPersonPassport>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TPersonPhone> TPersonPhones { get; set; } = new List<TPersonPhone>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TPersonReference> TPersonReferences { get; set; } = new List<TPersonReference>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TPersonVisa> TPersonVisas { get; set; } = new List<TPersonVisa>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TPersonWorkEligibility> TPersonWorkEligibilities { get; set; } = new List<TPersonWorkEligibility>();

    [InverseProperty("BirthCountryCodeNavigation")]
    public virtual ICollection<TPersonal> TPersonalBirthCountryCodeNavigations { get; set; } = new List<TPersonal>();

    [InverseProperty("CitizenCountryCodeNavigation")]
    public virtual ICollection<TPersonal> TPersonalCitizenCountryCodeNavigations { get; set; } = new List<TPersonal>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TPhysician> TPhysicians { get; set; } = new List<TPhysician>();

    [InverseProperty("ContactCountryCodeNavigation")]
    public virtual ICollection<TPositionFundingHist> TPositionFundingHists { get; set; } = new List<TPositionFundingHist>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TRecruitingFirm> TRecruitingFirms { get; set; } = new List<TRecruitingFirm>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TStateProvince> TStateProvinces { get; set; } = new List<TStateProvince>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<TVendor> TVendors { get; set; } = new List<TVendor>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<UsysCountryFormat> UsysCountryFormats { get; set; } = new List<UsysCountryFormat>();

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<UsysCsfcountry> UsysCsfcountries { get; set; } = new List<UsysCsfcountry>();
}
