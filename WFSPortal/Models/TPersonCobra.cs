using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonCOBRA")]
[Index("PersonGuid", "CobraeventCode", "CobraeventDate", Name = "AK_tPersonCOBRA", IsUnique = true)]
public partial class TPersonCobra
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("COBRAEventCode")]
    [StringLength(15)]
    public string CobraeventCode { get; set; } = null!;

    [Column("COBRAEventDate", TypeName = "datetime")]
    public DateTime CobraeventDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EligibilityDate { get; set; }

    [Column("COBRAStatusCode")]
    [StringLength(15)]
    public string CobrastatusCode { get; set; } = null!;

    [Column("COBRAStatusDate", TypeName = "datetime")]
    public DateTime? CobrastatusDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CoverageEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EmployerNotifiedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonNotifiedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ElectionEndDate { get; set; }

    public string? Comments { get; set; }

    [Key]
    [Column("PersonCOBRAGUID")]
    public Guid PersonCobraguid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CobraeventCode")]
    [InverseProperty("TPersonCobras")]
    public virtual TCobraevent CobraeventCodeNavigation { get; set; } = null!;

    [ForeignKey("CobrastatusCode")]
    [InverseProperty("TPersonCobras")]
    public virtual TCobrastatus CobrastatusCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonCobras")]
    public virtual TPerson Person { get; set; } = null!;
}
