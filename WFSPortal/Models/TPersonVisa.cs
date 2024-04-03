using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonVisa")]
public partial class TPersonVisa
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [StringLength(15)]
    public string VisaTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime VisaIssueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VisaExpireDate { get; set; }

    [Key]
    [Column("PersonVisaGUID")]
    public Guid PersonVisaGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [StringLength(20)]
    public string? VisaNumber { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TPersonVisas")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonVisas")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("VisaTypeCode")]
    [InverseProperty("TPersonVisas")]
    public virtual TVisaType VisaTypeCodeNavigation { get; set; } = null!;
}
