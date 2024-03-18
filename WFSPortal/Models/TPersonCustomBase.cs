using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonCustomBase")]
public partial class TPersonCustomBase
{
    [Key]
    [Column("PersonCustomBaseGUID")]
    public Guid PersonCustomBaseGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(50)]
    public string? Text1 { get; set; }

    [StringLength(50)]
    public string? Text2 { get; set; }

    [StringLength(50)]
    public string? Text3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date3 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount1 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount2 { get; set; }

    [StringLength(15)]
    public string Custom1Code { get; set; } = null!;

    [StringLength(15)]
    public string Custom2Code { get; set; } = null!;

    [StringLength(15)]
    public string Custom3Code { get; set; } = null!;

    [StringLength(15)]
    public string Custom4Code { get; set; } = null!;

    [StringLength(1024)]
    public string? Comments1 { get; set; }

    [StringLength(1024)]
    public string? Comments2 { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("Custom1Code")]
    [InverseProperty("TPersonCustomBases")]
    public virtual TCustom1 Custom1CodeNavigation { get; set; } = null!;

    [ForeignKey("Custom2Code")]
    [InverseProperty("TPersonCustomBases")]
    public virtual TCustom2 Custom2CodeNavigation { get; set; } = null!;

    [ForeignKey("Custom3Code")]
    [InverseProperty("TPersonCustomBases")]
    public virtual TCustom3 Custom3CodeNavigation { get; set; } = null!;

    [ForeignKey("Custom4Code")]
    [InverseProperty("TPersonCustomBases")]
    public virtual TCustom4 Custom4CodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonCustomBase")]
    public virtual TPerson Person { get; set; } = null!;
}
