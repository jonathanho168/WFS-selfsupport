using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonEmploymentHist")]
[Index("CompanyName", Name = "IX_tPersonEmploymentHist_CompanyName")]
[Index("JobTitle", Name = "IX_tPersonEmploymentHist_JobTitle")]
public partial class TPersonEmploymentHist
{
    [Key]
    [Column("PersonEmploymentGUID")]
    public Guid PersonEmploymentGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonEmploymentStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonEmploymentEndDate { get; set; }

    [StringLength(80)]
    public string? CompanyName { get; set; }

    [Column(TypeName = "money")]
    public decimal? StartingPay { get; set; }

    [StringLength(15)]
    public string StartingPayFrequencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? EndingPay { get; set; }

    [StringLength(15)]
    public string EndingPayFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string CurrencyCode { get; set; } = null!;

    [StringLength(15)]
    public string FunctionalAreaCode { get; set; } = null!;

    [StringLength(80)]
    public string? JobTitle { get; set; }

    public string? PrimaryResponsibilities { get; set; }

    [StringLength(15)]
    public string ProfessionalLevelCode { get; set; } = null!;

    [StringLength(15)]
    public string DepartureReasonCode { get; set; } = null!;

    public bool EligibleForRehireFlag { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    public bool? CanWeContact { get; set; }

    [StringLength(64)]
    public string? SupervisorName { get; set; }

    [StringLength(15)]
    public string? CountryCode { get; set; }

    public string? Address { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(15)]
    public string? StateProvinceCode { get; set; }

    [StringLength(12)]
    public string? PostalCode { get; set; }

    [StringLength(20)]
    public string? NationalPrefix { get; set; }

    [StringLength(20)]
    public string? InternationalPrefix { get; set; }

    [StringLength(20)]
    public string? AreaCode { get; set; }

    [StringLength(20)]
    public string? Phone { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TPersonEmploymentHists")]
    public virtual TCountry? CountryCodeNavigation { get; set; }

    [ForeignKey("CurrencyCode")]
    [InverseProperty("TPersonEmploymentHists")]
    public virtual TCurrency CurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("DepartureReasonCode")]
    [InverseProperty("TPersonEmploymentHists")]
    public virtual TDepartureReason DepartureReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("EndingPayFrequencyCode")]
    [InverseProperty("TPersonEmploymentHistEndingPayFrequencyCodeNavigations")]
    public virtual TFrequency EndingPayFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("FunctionalAreaCode")]
    [InverseProperty("TPersonEmploymentHists")]
    public virtual TFunctionalArea FunctionalAreaCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonEmploymentHists")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("ProfessionalLevelCode")]
    [InverseProperty("TPersonEmploymentHists")]
    public virtual TProfessionalLevel ProfessionalLevelCodeNavigation { get; set; } = null!;

    [ForeignKey("StartingPayFrequencyCode")]
    [InverseProperty("TPersonEmploymentHistStartingPayFrequencyCodeNavigations")]
    public virtual TFrequency StartingPayFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TPersonEmploymentHists")]
    public virtual TStateProvince? StateProvinceCodeNavigation { get; set; }
}
