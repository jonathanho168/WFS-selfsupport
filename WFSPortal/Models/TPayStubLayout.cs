using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPayStubLayout")]
[Index("PayStubLayoutGuid", Name = "RG_tPayStubLayout", IsUnique = true)]
[Index("PayStubStartDate", Name = "UK_PayStubLayoutStartDate", IsUnique = true)]
public partial class TPayStubLayout
{
    [Column(TypeName = "datetime")]
    public DateTime PayStubStartDate { get; set; }

    [StringLength(15)]
    public string PayStubCode { get; set; } = null!;

    [Column("PayStubLayoutXML", TypeName = "xml")]
    public string? PayStubLayoutXml { get; set; }

    [Key]
    [Column("PayStubLayoutGUID")]
    public Guid PayStubLayoutGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PayStubCode")]
    [InverseProperty("TPayStubLayouts")]
    public virtual TPayStub PayStubCodeNavigation { get; set; } = null!;
}
