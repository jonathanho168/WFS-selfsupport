using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tStateProvince")]
[Index("CountryCode", "MailingCode", Name = "AK_tStateProvince", IsUnique = true)]
public partial class TStateProvince
{
    [Key]
    [StringLength(15)]
    public string StateProvinceCode { get; set; } = null!;

    [Column("StateProvinceGUID")]
    public Guid StateProvinceGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? StateProvinceDescription { get; set; }

    [StringLength(15)]
    public string? MailingCode { get; set; }

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [ForeignKey("CountryCode")]
    [InverseProperty("TStateProvinces")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TBenefitPlanAdministrator> TBenefitPlanAdministrators { get; set; } = new List<TBenefitPlanAdministrator>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TCarrier> TCarriers { get; set; } = new List<TCarrier>();

    [InverseProperty("AcadgestateProvinceCodeNavigation")]
    public virtual ICollection<TCompany> TCompanyAcadgestateProvinceCodeNavigations { get; set; } = new List<TCompany>();

    [InverseProperty("MailStateProvinceCodeNavigation")]
    public virtual ICollection<TCompany> TCompanyMailStateProvinceCodeNavigations { get; set; } = new List<TCompany>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TCompany> TCompanyStateProvinceCodeNavigations { get; set; } = new List<TCompany>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TExternalRecruiter> TExternalRecruiters { get; set; } = new List<TExternalRecruiter>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TFacility> TFacilities { get; set; } = new List<TFacility>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TIncident> TIncidents { get; set; } = new List<TIncident>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TLocation> TLocations { get; set; } = new List<TLocation>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TMedicalFacility> TMedicalFacilities { get; set; } = new List<TMedicalFacility>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TPerformanceParticipant> TPerformanceParticipants { get; set; } = new List<TPerformanceParticipant>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TPersonAddress> TPersonAddresses { get; set; } = new List<TPersonAddress>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TPersonCertification> TPersonCertifications { get; set; } = new List<TPersonCertification>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TPersonEmergency> TPersonEmergencies { get; set; } = new List<TPersonEmergency>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TPersonEmploymentHist> TPersonEmploymentHists { get; set; } = new List<TPersonEmploymentHist>();

    [InverseProperty("PreparerStateProvinceCodeNavigation")]
    public virtual ICollection<TPersonI9> TPersonI9PreparerStateProvinceCodeNavigations { get; set; } = new List<TPersonI9>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TPersonI9> TPersonI9StateProvinceCodeNavigations { get; set; } = new List<TPersonI9>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TPersonReference> TPersonReferences { get; set; } = new List<TPersonReference>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TPersonWorkEligibility> TPersonWorkEligibilities { get; set; } = new List<TPersonWorkEligibility>();

    [InverseProperty("DriversLicenseStateProvinceCodeNavigation")]
    public virtual ICollection<TPersonal> TPersonals { get; set; } = new List<TPersonal>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TPhysician> TPhysicians { get; set; } = new List<TPhysician>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TRecruitingFirm> TRecruitingFirms { get; set; } = new List<TRecruitingFirm>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TVendor> TVendors { get; set; } = new List<TVendor>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<TWorkersCompensationRate> TWorkersCompensationRates { get; set; } = new List<TWorkersCompensationRate>();

    [InverseProperty("StateProvinceCodeNavigation")]
    public virtual ICollection<UsysCsfstateProvince> UsysCsfstateProvinces { get; set; } = new List<UsysCsfstateProvince>();
}
