using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonAbsencePoint")]
public partial class TPersonAbsencePoint
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Key]
    [Column("PersonAbsencePointGUID")]
    public Guid PersonAbsencePointGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonAbsencePointDate { get; set; }

    [StringLength(15)]
    public string? AbsencePointIncidentCode { get; set; }

    [StringLength(15)]
    public string? AbsencePointCorrectiveActionCode { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PersonCurrentAbsencePointAdj { get; set; }

    [StringLength(15)]
    public string AbsencePointAdjustmentTypeCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("AbsencePointAdjustmentTypeCode")]
    [InverseProperty("TPersonAbsencePoints")]
    public virtual TAbsencePointAdjustmentType AbsencePointAdjustmentTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("AbsencePointCorrectiveActionCode")]
    [InverseProperty("TPersonAbsencePoints")]
    public virtual TAbsencePointCorrectiveAction? AbsencePointCorrectiveActionCodeNavigation { get; set; }

    [ForeignKey("AbsencePointIncidentCode")]
    [InverseProperty("TPersonAbsencePoints")]
    public virtual TAbsencePointIncident? AbsencePointIncidentCodeNavigation { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonAbsencePoints")]
    public virtual TPerson Person { get; set; } = null!;
}
