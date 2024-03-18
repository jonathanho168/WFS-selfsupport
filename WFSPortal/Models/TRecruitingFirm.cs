using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRecruitingFirm")]
[Index("RecruitingFirmGuid", Name = "RG_tRecruitingFirm", IsUnique = true)]
public partial class TRecruitingFirm
{
    [Key]
    [StringLength(15)]
    public string RecruitingFirmCode { get; set; } = null!;

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

    [StringLength(30)]
    public string? PrimaryContactName { get; set; }

    [StringLength(20)]
    public string? PrimaryContactAreaCode { get; set; }

    [StringLength(20)]
    public string? PrimaryContactPhone { get; set; }

    [StringLength(5)]
    public string? PrimaryContactExtension { get; set; }

    [StringLength(30)]
    public string? SecondaryContactName { get; set; }

    [StringLength(20)]
    public string? SecondaryContactAreaCode { get; set; }

    [StringLength(20)]
    public string? SecondaryContactPhone { get; set; }

    [StringLength(5)]
    public string? SecondaryContactExtension { get; set; }

    [StringLength(15)]
    public string RecruitingSpecialtyCode { get; set; } = null!;

    public string? Comments { get; set; }

    [Column("RecruitingFirmGUID")]
    public Guid RecruitingFirmGuid { get; set; }

    [StringLength(20)]
    public string? PrimaryContactInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? PrimaryContactNationalPrefix { get; set; }

    [StringLength(20)]
    public string? SecondaryContactInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? SecondaryContactNationalPrefix { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Name { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TRecruitingFirms")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("RecruitingSpecialtyCode")]
    [InverseProperty("TRecruitingFirms")]
    public virtual TRecruitingSpecialty RecruitingSpecialtyCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TRecruitingFirms")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;

    [InverseProperty("RecruitingFirmCodeNavigation")]
    public virtual ICollection<TPersonApplication> TPersonApplications { get; set; } = new List<TPersonApplication>();

    [InverseProperty("RecruitingFirmCodeNavigation")]
    public virtual ICollection<TRecruitingAgreement> TRecruitingAgreements { get; set; } = new List<TRecruitingAgreement>();
}
