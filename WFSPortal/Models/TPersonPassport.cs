using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonPassport")]
public partial class TPersonPassport
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PassportIssueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PassportExpireDate { get; set; }

    [StringLength(20)]
    public string? PassportNumber { get; set; }

    [Key]
    [Column("PersonPassportGUID")]
    public Guid PersonPassportGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TPersonPassports")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonPassports")]
    public virtual TPerson Person { get; set; } = null!;
}
