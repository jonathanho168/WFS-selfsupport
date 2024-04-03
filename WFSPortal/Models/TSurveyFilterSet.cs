using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSurveyFilterSet")]
[Index("SurveyFilterSetGuid", Name = "RG_tSurveyFilterSet", IsUnique = true)]
public partial class TSurveyFilterSet
{
    [Key]
    [StringLength(30)]
    public string SurveyFilterSetName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime BeginSurveyDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndSurveyDate { get; set; }

    public bool ShowTotalCashFlag { get; set; }

    public bool? BonusEligibleFlag { get; set; }

    [StringLength(15)]
    public string TargetFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string? TargetGeographicAreaCode { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal DataAgingFactor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAgingFactorTargetDate { get; set; }

    [Column("SurveyFilterSetGUID")]
    public Guid SurveyFilterSetGuid { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("SurveyFilterSetNameNavigation")]
    public virtual ICollection<TSurveyFilterSetCompanySize> TSurveyFilterSetCompanySizes { get; set; } = new List<TSurveyFilterSetCompanySize>();

    [InverseProperty("SurveyFilterSetNameNavigation")]
    public virtual ICollection<TSurveyFilterSetGeographicArea> TSurveyFilterSetGeographicAreas { get; set; } = new List<TSurveyFilterSetGeographicArea>();

    [InverseProperty("SurveyFilterSetNameNavigation")]
    public virtual ICollection<TSurveyFilterSetGrade> TSurveyFilterSetGrades { get; set; } = new List<TSurveyFilterSetGrade>();

    [InverseProperty("SurveyFilterSetNameNavigation")]
    public virtual ICollection<TSurveyFilterSetIndustrySector> TSurveyFilterSetIndustrySectors { get; set; } = new List<TSurveyFilterSetIndustrySector>();

    [InverseProperty("SurveyFilterSetNameNavigation")]
    public virtual ICollection<TSurveyFilterSetJobFamily> TSurveyFilterSetJobFamilies { get; set; } = new List<TSurveyFilterSetJobFamily>();

    [InverseProperty("SurveyFilterSetNameNavigation")]
    public virtual ICollection<TSurveyFilterSetJob> TSurveyFilterSetJobs { get; set; } = new List<TSurveyFilterSetJob>();

    [InverseProperty("SurveyFilterSetNameNavigation")]
    public virtual ICollection<TSurveyFilterSetSurveySource> TSurveyFilterSetSurveySources { get; set; } = new List<TSurveyFilterSetSurveySource>();

    [ForeignKey("TargetFrequencyCode")]
    [InverseProperty("TSurveyFilterSets")]
    public virtual TFrequency TargetFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("TargetGeographicAreaCode")]
    [InverseProperty("TSurveyFilterSets")]
    public virtual TGeographicArea? TargetGeographicAreaCodeNavigation { get; set; }
}
