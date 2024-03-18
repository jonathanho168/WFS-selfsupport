using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRequisitionJobDescriptionHist")]
[Index("RequisitionJobDescriptionGuid", Name = "RG_tRequisitionJobDescriptionHist", IsUnique = true)]
public partial class TRequisitionJobDescriptionHist
{
    [Key]
    public Guid RequisitionJobDescriptionGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RequisitionJobDescriptionStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RequisitionJobDescriptionEndDate { get; set; }

    public bool RequisitionJobDescriptionCurrentFlag { get; set; }

    [StringLength(15)]
    public string RequisitionCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public byte[]? Attachment { get; set; }

    public string? CertificationsRequired { get; set; }

    public string? DesiredDegree { get; set; }

    public string? DesiredEducation { get; set; }

    public string? DesiredJobExperience { get; set; }

    public string? DesiredMajor { get; set; }

    public string? EssentialFunctions { get; set; }

    public string? MinimumPhysicalRequirements { get; set; }

    public string? OtherQualifications { get; set; }

    public string? PrimaryResponsibilities { get; set; }

    public string? TasksPerformed { get; set; }

    public string? BroadbeanJobPostingDescription { get; set; }

    public string? BroadbeanJobPostingSkills { get; set; }

    [ForeignKey("RequisitionCode")]
    [InverseProperty("TRequisitionJobDescriptionHists")]
    public virtual TRequisition RequisitionCodeNavigation { get; set; } = null!;
}
