using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSurvey")]
public partial class TSurvey
{
    [Key]
    [Column("SurveyGUID")]
    public Guid SurveyGuid { get; set; }

    [StringLength(15)]
    public string SurveySourceCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime SurveyDate { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? SurveyDescription { get; set; }

    [ForeignKey("SurveySourceCode")]
    [InverseProperty("TSurveys")]
    public virtual TSurveySource SurveySourceCodeNavigation { get; set; } = null!;

    [InverseProperty("Survey")]
    public virtual ICollection<TSurveyDatum> TSurveyData { get; set; } = new List<TSurveyDatum>();
}
