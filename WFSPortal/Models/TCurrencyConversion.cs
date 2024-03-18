using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCurrencyConversion")]
public partial class TCurrencyConversion
{
    [StringLength(15)]
    public string CurrencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectiveDate { get; set; }

    [Column(TypeName = "numeric(18, 8)")]
    public decimal ExchangeRate { get; set; }

    [Key]
    [Column("CurrencyConversionGUID")]
    public Guid CurrencyConversionGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CurrencyCode")]
    [InverseProperty("TCurrencyConversions")]
    public virtual TCurrency CurrencyCodeNavigation { get; set; } = null!;
}
