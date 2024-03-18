using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonProjectHist")]
[Index("PersonGuid", "ProjectCode", "PersonProjectStartDate", "PositionCode", Name = "AK_tPersonProjectHist", IsUnique = true)]
public partial class TPersonProjectHist
{
    [Key]
    [Column("PersonProjectGUID")]
    public Guid PersonProjectGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string ProjectCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PersonProjectStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonProjectEndDate { get; set; }

    public bool PersonProjectCurrentFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PersonProjectAllocation { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public bool ProjectManagerFlag { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonProjectHists")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonProjectHists")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("ProjectCode")]
    [InverseProperty("TPersonProjectHists")]
    public virtual TProject ProjectCodeNavigation { get; set; } = null!;
}
