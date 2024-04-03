using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSurveyCompanySize")]
[Index("SurveyCompanySizeGuid", Name = "RG_tSurveyCompanySize", IsUnique = true)]
public partial class TSurveyCompanySize
{
    [Key]
    [StringLength(15)]
    public string SurveyCompanySizeCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? RevenueMinimumAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? RevenueMaximumAmount { get; set; }

    public int? EmployeeMinimumCount { get; set; }

    public int? EmployeeMaximumCount { get; set; }

    [Column("SurveyCompanySizeGUID")]
    public Guid SurveyCompanySizeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? SurveyCompanySizeDescription { get; set; }

    [InverseProperty("SurveyCompanySizeCodeNavigation")]
    public virtual ICollection<TSurveyDatum> TSurveyData { get; set; } = new List<TSurveyDatum>();

    [InverseProperty("SurveyCompanySizeCodeNavigation")]
    public virtual ICollection<TSurveyFilterSetCompanySize> TSurveyFilterSetCompanySizes { get; set; } = new List<TSurveyFilterSetCompanySize>();
}
