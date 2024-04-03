using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonIncidentRestrictedTimeHist")]
public partial class TPersonIncidentRestrictedTimeHist
{
    [Key]
    [Column("PersonIncidentRestrictedTimeGUID")]
    public Guid PersonIncidentRestrictedTimeGuid { get; set; }

    [Column("PersonIncidentGUID")]
    public Guid PersonIncidentGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonIncidentRestrictedTimeStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonIncidentRestrictedTimeEndDate { get; set; }

    public bool PersonIncidentRestrictedTimeCurrentFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? RestrictedWorkDays { get; set; }

    public string? RestrictedDetails { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("PersonIncidentGuid")]
    [InverseProperty("TPersonIncidentRestrictedTimeHists")]
    public virtual TPersonIncident PersonIncident { get; set; } = null!;
}
