using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitPlanAdministrator")]
[Index("BenefitPlanAdministratorGuid", Name = "RG_tBenefitPlanAdministrator", IsUnique = true)]
public partial class TBenefitPlanAdministrator
{
    [Key]
    [StringLength(15)]
    public string BenefitPlanAdministratorCode { get; set; } = null!;

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

    [Column("BenefitPlanAdministratorGUID")]
    public Guid BenefitPlanAdministratorGuid { get; set; }

    [StringLength(20)]
    public string? InternationalPrefix { get; set; }

    [StringLength(20)]
    public string? NationalPrefix { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    public string? BenefitPlanAdministratorDescription { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TBenefitPlanAdministrators")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TBenefitPlanAdministrators")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;

    [InverseProperty("BenefitPlanAdministratorCodeNavigation")]
    public virtual ICollection<TBenefitPlan> TBenefitPlans { get; set; } = new List<TBenefitPlan>();
}
