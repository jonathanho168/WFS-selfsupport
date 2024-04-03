using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSurveyFilterSetGrade")]
public partial class TSurveyFilterSetGrade
{
    [StringLength(30)]
    public string SurveyFilterSetName { get; set; } = null!;

    [StringLength(15)]
    public string GradeCode { get; set; } = null!;

    [Key]
    [Column("SurveyFilterSetGradeGUID")]
    public Guid SurveyFilterSetGradeGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("SurveyFilterSetName")]
    [InverseProperty("TSurveyFilterSetGrades")]
    public virtual TSurveyFilterSet SurveyFilterSetNameNavigation { get; set; } = null!;
}
