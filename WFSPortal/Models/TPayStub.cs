using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPayStub")]
[Index("PayStubGuid", Name = "RG_tPayStub", IsUnique = true)]
public partial class TPayStub
{
    [Key]
    [StringLength(15)]
    public string PayStubCode { get; set; } = null!;

    [Column("PayStubXSLT", TypeName = "xml")]
    public string? PayStubXslt { get; set; }

    [Column("PayStubGUID")]
    public Guid PayStubGuid { get; set; }

    public int RowVersion { get; set; }

    public byte[]? PreviewFile { get; set; }

    public bool InactiveFlag { get; set; }

    public string? PayStubDescription { get; set; }

    [InverseProperty("PayStubCodeNavigation")]
    public virtual ICollection<TPayStubLayout> TPayStubLayouts { get; set; } = new List<TPayStubLayout>();
}
