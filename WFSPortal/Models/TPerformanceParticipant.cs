using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceParticipant")]
public partial class TPerformanceParticipant
{
    [Key]
    [Column("PerformanceParticipantGUID")]
    public Guid PerformanceParticipantGuid { get; set; }

    [StringLength(15)]
    public string PerformanceParticipantTypeCode { get; set; } = null!;

    [StringLength(30)]
    public string Name { get; set; } = null!;

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
    public string? InternationalPrefix { get; set; }

    [StringLength(20)]
    public string? NationalPrefix { get; set; }

    [StringLength(20)]
    public string? AreaCode { get; set; }

    [Column("EMailAddress")]
    [StringLength(255)]
    public string EmailAddress { get; set; } = null!;

    [StringLength(80)]
    public string? Affiliation { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(20)]
    public string? Phone { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TPerformanceParticipants")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("PerformanceParticipantTypeCode")]
    [InverseProperty("TPerformanceParticipants")]
    public virtual TPerformanceParticipantType PerformanceParticipantTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TPerformanceParticipants")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;

    [InverseProperty("PerformanceParticipant")]
    public virtual ICollection<TPersonPerformanceParticipant> TPersonPerformanceParticipants { get; set; } = new List<TPersonPerformanceParticipant>();
}
