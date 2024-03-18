using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonFMLAAdjustment")]
public partial class TPersonFmlaadjustment
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AdjustmentDate { get; set; }

    public bool BeginningBalanceFlag { get; set; }

    public string? Comments { get; set; }

    [Key]
    [Column("PersonFMLAAdjustmentGUID")]
    public Guid PersonFmlaadjustmentGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("MFMLAAdjustmentFlag")]
    public bool MfmlaadjustmentFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal AdjustmentHours { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonFmlaadjustments")]
    public virtual TPerson Person { get; set; } = null!;
}
