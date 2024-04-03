using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tJobDescription")]
[Index("JobCode", "DescriptionDate", "PositionCode", Name = "AK_tJobDescription", IsUnique = true)]
public partial class TJobDescription
{
    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DescriptionDate { get; set; }

    [Key]
    [Column("JobDescriptionGUID")]
    public Guid JobDescriptionGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

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

    [ForeignKey("JobCode")]
    [InverseProperty("TJobDescriptions")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TJobDescriptions")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;
}
