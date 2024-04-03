using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonWorkEligibility")]
public partial class TPersonWorkEligibility
{
    [Key]
    [Column("PersonWorkEligibilityGUID")]
    public Guid PersonWorkEligibilityGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveDate { get; set; }

    [StringLength(30)]
    public string? LastName { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }

    [StringLength(30)]
    public string? MiddleName { get; set; }

    [StringLength(30)]
    public string? FormerLastName { get; set; }

    [StringLength(255)]
    public string? Address { get; set; }

    [StringLength(255)]
    public string? ApartmentNumber { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(15)]
    public string? StateProvinceCode { get; set; }

    [StringLength(15)]
    public string? CountryCode { get; set; }

    [StringLength(12)]
    public string? PostalCode { get; set; }

    [StringLength(255)]
    public string? EmailAddress { get; set; }

    [StringLength(20)]
    public string? InternationalPrefix { get; set; }

    [StringLength(20)]
    public string? NationalPrefix { get; set; }

    [StringLength(20)]
    public string? AreaCode { get; set; }

    [StringLength(20)]
    public string? Phone { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("NationalID")]
    [StringLength(50)]
    public string? NationalId { get; set; }

    [Column("VerifiedByPersonGUID")]
    public Guid? VerifiedByPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VerifiedDate { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TPersonWorkEligibilities")]
    public virtual TCountry? CountryCodeNavigation { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonWorkEligibilityPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TPersonWorkEligibilities")]
    public virtual TStateProvince? StateProvinceCodeNavigation { get; set; }

    [InverseProperty("PersonWorkEligibility")]
    public virtual ICollection<TPersonWorkEligibilityFile> TPersonWorkEligibilityFiles { get; set; } = new List<TPersonWorkEligibilityFile>();

    [ForeignKey("VerifiedByPersonGuid")]
    [InverseProperty("TPersonWorkEligibilityVerifiedByPeople")]
    public virtual TPerson? VerifiedByPerson { get; set; }
}
