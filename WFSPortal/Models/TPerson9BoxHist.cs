using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerson9BoxHist")]
public partial class TPerson9BoxHist
{
    [Key]
    [Column("Person9BoxGUID")]
    public Guid Person9BoxGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Person9BoxStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Person9BoxEndDate { get; set; }

    public bool Person9BoxCurrentFlag { get; set; }

    [StringLength(15)]
    public string Person9BoxPotential { get; set; } = null!;

    [StringLength(15)]
    public string Person9BoxPerformance { get; set; } = null!;

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPerson9BoxHists")]
    public virtual TPerson Person { get; set; } = null!;
}
