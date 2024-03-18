using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("WesleyAbsenceCutover")]
public partial class WesleyAbsenceCutover
{
    [Column("Person ID")]
    public double? PersonId { get; set; }

    [Column("Last Name")]
    [StringLength(255)]
    public string? LastName { get; set; }

    [Column("First Name")]
    [StringLength(255)]
    public string? FirstName { get; set; }

    [Column("Time Type Code")]
    [StringLength(255)]
    public string? TimeTypeCode { get; set; }

    [Column("Absence Date", TypeName = "datetime")]
    public DateTime? AbsenceDate { get; set; }

    [Column("Absence Reason Code")]
    [StringLength(255)]
    public string? AbsenceReasonCode { get; set; }

    public double? Hours { get; set; }

    [Column("adjustment comment to be uploaded into HCM")]
    [StringLength(255)]
    public string? AdjustmentCommentToBeUploadedIntoHcm { get; set; }

    [Column("PersonGUID")]
    [StringLength(255)]
    [Unicode(false)]
    public string? PersonGuid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PositionCode { get; set; }

    [Column("PersonAbsencePlanGUID")]
    [StringLength(255)]
    [Unicode(false)]
    public string? PersonAbsencePlanGuid { get; set; }

    [Column("PersonAbsenceGUID")]
    [StringLength(255)]
    [Unicode(false)]
    public string? PersonAbsenceGuid { get; set; }

    [Column("test")]
    public Guid? Test { get; set; }
}
