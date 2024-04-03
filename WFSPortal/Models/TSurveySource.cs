using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSurveySource")]
[Index("SurveySourceGuid", Name = "RG_tSurveySource", IsUnique = true)]
public partial class TSurveySource
{
    [Key]
    [StringLength(15)]
    public string SurveySourceCode { get; set; } = null!;

    [Column("SurveySourceGUID")]
    public Guid SurveySourceGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? SurveySourceDescription { get; set; }

    [InverseProperty("SurveySourceCodeNavigation")]
    public virtual ICollection<TSurveyFilterSetSurveySource> TSurveyFilterSetSurveySources { get; set; } = new List<TSurveyFilterSetSurveySource>();

    [InverseProperty("SurveySourceCodeNavigation")]
    public virtual ICollection<TSurvey> TSurveys { get; set; } = new List<TSurvey>();
}
