using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonUnionHist")]
public partial class TPersonUnionHist
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonUnionStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonUnionEndDate { get; set; }

    [StringLength(15)]
    public string UnionCode { get; set; } = null!;

    [StringLength(15)]
    public string? LocalNumber { get; set; }

    [StringLength(30)]
    public string? UnionOfficer { get; set; }

    public bool SuperSeniorityFlag { get; set; }

    public bool PersonUnionCurrentFlag { get; set; }

    [Key]
    [Column("PersonUnionGUID")]
    public Guid PersonUnionGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [StringLength(15)]
    public string BargainingUnitCode { get; set; } = null!;

    [ForeignKey("BargainingUnitCode")]
    [InverseProperty("TPersonUnionHists")]
    public virtual TBargainingUnit BargainingUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonUnionHists")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("UnionCode")]
    [InverseProperty("TPersonUnionHists")]
    public virtual TUnion UnionCodeNavigation { get; set; } = null!;
}
