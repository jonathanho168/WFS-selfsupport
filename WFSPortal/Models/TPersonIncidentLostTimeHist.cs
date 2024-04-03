using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonIncidentLostTimeHist")]
public partial class TPersonIncidentLostTimeHist
{
    [Key]
    [Column("PersonIncidentLostTimeGUID")]
    public Guid PersonIncidentLostTimeGuid { get; set; }

    [Column("PersonIncidentGUID")]
    public Guid PersonIncidentGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonIncidentLostTimeStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonIncidentLostTimeEndDate { get; set; }

    public bool PersonIncidentLostTimeCurrentFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? LostWorkDays { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? LostWorkHours { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("PersonIncidentGuid")]
    [InverseProperty("TPersonIncidentLostTimeHists")]
    public virtual TPersonIncident PersonIncident { get; set; } = null!;
}
