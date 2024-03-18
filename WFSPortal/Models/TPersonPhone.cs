using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonPhone")]
public partial class TPersonPhone
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    public int PhoneSequence { get; set; }

    [StringLength(15)]
    public string PhoneTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [StringLength(20)]
    public string? InternationalPrefix { get; set; }

    [StringLength(20)]
    public string? NationalPrefix { get; set; }

    [StringLength(20)]
    public string? AreaCode { get; set; }

    [StringLength(20)]
    public string? Phone { get; set; }

    [StringLength(5)]
    public string? Extension { get; set; }

    [Key]
    [Column("PersonPhoneGUID")]
    public Guid PersonPhoneGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public Guid? PersonAddressGuid { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TPersonPhones")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonPhones")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonAddressGuid")]
    [InverseProperty("TPersonPhones")]
    public virtual TPersonAddress? PersonAddress { get; set; }

    [ForeignKey("PhoneTypeCode")]
    [InverseProperty("TPersonPhones")]
    public virtual TPhoneType PhoneTypeCodeNavigation { get; set; } = null!;
}
