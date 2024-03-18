using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSUISDITax")]
[Index("SuisditaxGuid", Name = "RG_tSUISDITax", IsUnique = true)]
public partial class TSuisditax
{
    [Key]
    [Column("SUISDITaxCode")]
    [StringLength(15)]
    public string SuisditaxCode { get; set; } = null!;

    [Column("SUISDITaxGUID")]
    public Guid SuisditaxGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Column("SUISDITaxDescription")]
    public string? SuisditaxDescription { get; set; }

    [InverseProperty("SuisditaxCodeNavigation")]
    public virtual ICollection<TPersonTax> TPersonTaxes { get; set; } = new List<TPersonTax>();
}
