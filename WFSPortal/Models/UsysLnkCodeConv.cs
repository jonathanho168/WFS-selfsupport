using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkCodeConv")]
public partial class UsysLnkCodeConv
{
    [Column("LnkFieldDefGUID")]
    public Guid LnkFieldDefGuid { get; set; }

    [Column("IVANCodeValue")]
    [StringLength(50)]
    [Unicode(false)]
    public string IvancodeValue { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ConvertCodeValue { get; set; }

    [Key]
    [Column("LnkCodeConvGUID")]
    public Guid LnkCodeConvGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LnkFieldDefGuid")]
    [InverseProperty("UsysLnkCodeConvs")]
    public virtual UsysLnkFieldDef LnkFieldDef { get; set; } = null!;
}
