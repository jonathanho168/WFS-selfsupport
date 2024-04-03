using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonLeaveRequestDesignation")]
public partial class TPersonLeaveRequestDesignation
{
    [Key]
    [Column("PersonLeaveRequestDesignationGUID")]
    public Guid PersonLeaveRequestDesignationGuid { get; set; }

    [Column("PersonLeaveRequestGUID")]
    public Guid PersonLeaveRequestGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocumentationRequestDate { get; set; }

    [StringLength(80)]
    public string DesignationType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FormDueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FormReceivedDate { get; set; }

    [StringLength(80)]
    public string? Designation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DesignationDate { get; set; }

    public bool ScheduledLeaveFlag { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? ScheduledLeaveHours { get; set; }

    public bool RequestedPaidLeaveFlag { get; set; }

    public bool RequiredPaidLeaveFlag { get; set; }

    public bool RequiredFitnessDesignationFlag { get; set; }

    public bool? EssentialDutiesAttachedFlag { get; set; }

    public bool IncompleteCertificationFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CertificationCorrectionDueDate { get; set; }

    public string? DesignationCorrectionComments { get; set; }

    public bool RequireMultipleOpinionsFlag { get; set; }

    public string? DesignationComments { get; set; }

    [Column("PersonLeaveRequestDesignationGroupGUID")]
    public Guid? PersonLeaveRequestDesignationGroupGuid { get; set; }

    public int RowVersion { get; set; }

    public bool RequireMultipleThirdOpinionFlag { get; set; }

    public bool InsufficientCertificationFlag { get; set; }

    [StringLength(80)]
    public string? OtherDesignationText { get; set; }

    [ForeignKey("PersonLeaveRequestGuid")]
    [InverseProperty("TPersonLeaveRequestDesignations")]
    public virtual TPersonLeaveRequest PersonLeaveRequest { get; set; } = null!;

    [InverseProperty("PersonLeaveRequestDesignation")]
    public virtual ICollection<TPersonLeaveRequestDesignationFile> TPersonLeaveRequestDesignationFiles { get; set; } = new List<TPersonLeaveRequestDesignationFile>();
}
