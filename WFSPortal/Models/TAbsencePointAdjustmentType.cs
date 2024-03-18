using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsencePointAdjustmentType")]
public partial class TAbsencePointAdjustmentType
{
    [Column("AbsencePointAdjustmentTypeGUID")]
    public Guid AbsencePointAdjustmentTypeGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string AbsencePointAdjustmentTypeCode { get; set; } = null!;

    public string? AbsencePointAdjustmentTypeDescription { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    [InverseProperty("AbsencePointAdjustmentTypeCodeNavigation")]
    public virtual ICollection<TPersonAbsencePoint> TPersonAbsencePoints { get; set; } = new List<TPersonAbsencePoint>();
}
