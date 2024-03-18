using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonReference")]
public partial class TPersonReference
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(30)]
    public string LastName { get; set; } = null!;

    [StringLength(30)]
    public string FirstName { get; set; } = null!;

    [StringLength(5)]
    public string? Salutation { get; set; }

    [StringLength(30)]
    public string? MiddleName { get; set; }

    [StringLength(80)]
    public string? Title { get; set; }

    [StringLength(80)]
    public string? Company { get; set; }

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

    [StringLength(20)]
    public string? HomeAreaCode { get; set; }

    [StringLength(20)]
    public string? HomePhone { get; set; }

    [StringLength(255)]
    public string? EmailAddress { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastVerifiedDate { get; set; }

    public bool ProfessionalReferenceFlag { get; set; }

    public string? Comments { get; set; }

    [Key]
    [Column("PersonReferenceGUID")]
    public Guid PersonReferenceGuid { get; set; }

    [StringLength(20)]
    public string? DayInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? DayNationalPrefix { get; set; }

    [StringLength(20)]
    public string? HomeInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? HomeNationalPrefix { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? YearsKnown { get; set; }

    public string? EmployeeComments { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TPersonReferences")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonReferences")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TPersonReferences")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;
}
