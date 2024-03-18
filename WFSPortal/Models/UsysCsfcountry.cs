using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCSFCountry")]
public partial class UsysCsfcountry
{
    [Key]
    [Column("CSFCountryGuid")]
    public Guid CsfcountryGuid { get; set; }

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [Column("CSFCode")]
    [StringLength(15)]
    public string Csfcode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("UsysCsfcountries")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("Csfcode")]
    [InverseProperty("UsysCsfcountries")]
    public virtual UsysCsf CsfcodeNavigation { get; set; } = null!;
}
