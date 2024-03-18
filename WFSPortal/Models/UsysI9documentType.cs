using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysI9DocumentType")]
public partial class UsysI9documentType
{
    [Column("I9DocumentTypeGUID")]
    public Guid I9documentTypeGuid { get; set; }

    [Key]
    [Column("I9DocumentTypeCode")]
    [StringLength(15)]
    public string I9documentTypeCode { get; set; } = null!;

    [Column("I9DocumentColumn")]
    [StringLength(15)]
    public string I9documentColumn { get; set; } = null!;

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("I9DocumentTypeDescription")]
    public string? I9documentTypeDescription { get; set; }

    [InverseProperty("I9documentTypeCodeNavigation")]
    public virtual ICollection<TPersonI9file> TPersonI9files { get; set; } = new List<TPersonI9file>();
}
