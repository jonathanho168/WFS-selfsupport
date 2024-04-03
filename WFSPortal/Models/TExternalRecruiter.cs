using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tExternalRecruiter")]
[Index("ExternalRecruiterGuid", Name = "RG_tExternalRecruiter", IsUnique = true)]
public partial class TExternalRecruiter
{
    [Key]
    [StringLength(15)]
    public string ExternalRecruiterCode { get; set; } = null!;

    [StringLength(5)]
    public string? Salutation { get; set; }

    [StringLength(30)]
    public string LastName { get; set; } = null!;

    [StringLength(30)]
    public string? FirstName { get; set; }

    [StringLength(30)]
    public string? MiddleName { get; set; }

    [StringLength(10)]
    public string? Suffix { get; set; }

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
    public string? DayAreaCode { get; set; }

    [StringLength(20)]
    public string? DayPhone { get; set; }

    [StringLength(5)]
    public string? DayExtension { get; set; }

    [StringLength(20)]
    public string? FaxAreaCode { get; set; }

    [StringLength(20)]
    public string? FaxPhone { get; set; }

    [StringLength(20)]
    public string? MobileAreaCode { get; set; }

    [StringLength(20)]
    public string? MobilePhone { get; set; }

    [StringLength(20)]
    public string? PagerAreaCode { get; set; }

    [StringLength(20)]
    public string? PagerPhone { get; set; }

    [StringLength(255)]
    public string? EmailAddress { get; set; }

    [Column("ExternalRecruiterGUID")]
    public Guid ExternalRecruiterGuid { get; set; }

    [StringLength(20)]
    public string? DayInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? DayNationalPrefix { get; set; }

    [StringLength(20)]
    public string? FaxInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? FaxNationalPrefix { get; set; }

    [StringLength(20)]
    public string? MobileInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? MobileNationalPrefix { get; set; }

    [StringLength(20)]
    public string? PagerInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? PagerNationalPrefix { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? ExternalRecruiterDescription { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TExternalRecruiters")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TExternalRecruiters")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;

    [InverseProperty("ExternalRecruiterCodeNavigation")]
    public virtual ICollection<TRequisition> TRequisitions { get; set; } = new List<TRequisition>();
}
