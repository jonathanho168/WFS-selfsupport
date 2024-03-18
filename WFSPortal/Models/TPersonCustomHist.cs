using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonCustomHist")]
public partial class TPersonCustomHist
{
    [Key]
    [Column("PersonCustomGUID")]
    public Guid PersonCustomGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonCustomStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonCustomEndDate { get; set; }

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
    public string Custom11Code { get; set; } = null!;

    [StringLength(15)]
    public string Custom12Code { get; set; } = null!;

    [StringLength(15)]
    public string Custom13Code { get; set; } = null!;

    [StringLength(15)]
    public string Custom14Code { get; set; } = null!;

    [StringLength(1024)]
    public string? Comments1 { get; set; }

    [StringLength(1024)]
    public string? Comments2 { get; set; }

    public bool PersonCustomCurrentFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public byte[]? CardImage1 { get; set; }

    [ForeignKey("Custom11Code")]
    [InverseProperty("TPersonCustomHists")]
    public virtual TCustom11 Custom11CodeNavigation { get; set; } = null!;

    [ForeignKey("Custom12Code")]
    [InverseProperty("TPersonCustomHists")]
    public virtual TCustom12 Custom12CodeNavigation { get; set; } = null!;

    [ForeignKey("Custom13Code")]
    [InverseProperty("TPersonCustomHists")]
    public virtual TCustom13 Custom13CodeNavigation { get; set; } = null!;

    [ForeignKey("Custom14Code")]
    [InverseProperty("TPersonCustomHists")]
    public virtual TCustom14 Custom14CodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonCustomHists")]
    public virtual TPerson Person { get; set; } = null!;
}
