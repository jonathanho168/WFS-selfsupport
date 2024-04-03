using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tProperty")]
[Index("PropertyGuid", Name = "RG_tProperty", IsUnique = true)]
public partial class TProperty
{
    [Key]
    [StringLength(15)]
    public string PropertyCode { get; set; } = null!;

    [StringLength(15)]
    public string PropertyTypeCode { get; set; } = null!;

    [StringLength(30)]
    public string? SerialNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AcquiredDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DisposalDate { get; set; }

    public string? Comments { get; set; }

    public bool EmployeeOwnedFlag { get; set; }

    public bool CopossessionFlag { get; set; }

    [Column("PropertyGUID")]
    public Guid PropertyGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? PropertyDescription { get; set; }

    [ForeignKey("PropertyTypeCode")]
    [InverseProperty("TProperties")]
    public virtual TPropertyType PropertyTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("PropertyCodeNavigation")]
    public virtual ICollection<TPersonPropertyHist> TPersonPropertyHists { get; set; } = new List<TPersonPropertyHist>();
}
