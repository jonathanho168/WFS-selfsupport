using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkPersonAbsenceHistErp
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string AbsencePlanCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PersonAbsenceStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonAbsenceEndDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? AbsenceDuration { get; set; }

    public bool PaidFlag { get; set; }

    public string? Comments { get; set; }

    public int? LaborHedSeq { get; set; }

    public int? LaborDtlSeq { get; set; }

    [Column("PersonAbsenceGUID")]
    public Guid PersonAbsenceGuid { get; set; }
}
