using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonEmergency")]
[Index("PersonGuid", "LastName", "FirstName", Name = "AK_tPersonEmergency", IsUnique = true)]
public partial class TPersonEmergency
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

    public int Priority { get; set; }

    [StringLength(15)]
    public string RelationshipCode { get; set; } = null!;

    [StringLength(20)]
    public string? DayAreaCode { get; set; }

    [StringLength(20)]
    public string? DayPhone { get; set; }

    [StringLength(20)]
    public string? HomeAreaCode { get; set; }

    [StringLength(20)]
    public string? HomePhone { get; set; }

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

    public string? Comments { get; set; }

    [Key]
    [Column("PersonEmergencyGUID")]
    public Guid PersonEmergencyGuid { get; set; }

    [StringLength(20)]
    public string? DayInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? DayNationalPrefix { get; set; }

    [StringLength(20)]
    public string? HomeInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? HomeNationalPrefix { get; set; }

    public int RowVersion { get; set; }

    [StringLength(5)]
    public string? Extension { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TPersonEmergencies")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonEmergencies")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("RelationshipCode")]
    [InverseProperty("TPersonEmergencies")]
    public virtual TRelationship RelationshipCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TPersonEmergencies")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;
}
