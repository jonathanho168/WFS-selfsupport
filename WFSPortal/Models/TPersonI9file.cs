using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonI9File")]
public partial class TPersonI9file
{
    [Key]
    [Column("PersonI9FileGUID")]
    public Guid PersonI9fileGuid { get; set; }

    [Column("PersonI9GUID")]
    public Guid PersonI9guid { get; set; }

    [Column("I9DocumentTypeCode")]
    [StringLength(15)]
    public string I9documentTypeCode { get; set; } = null!;

    [StringLength(80)]
    public string? IssuingAuthority { get; set; }

    [StringLength(50)]
    public string? DocumentNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    [Column("PersonI9File")]
    public byte[]? PersonI9file { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("I9documentTypeCode")]
    [InverseProperty("TPersonI9files")]
    public virtual UsysI9documentType I9documentTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonI9guid")]
    [InverseProperty("TPersonI9files")]
    public virtual TPersonI9 PersonI9 { get; set; } = null!;
}
