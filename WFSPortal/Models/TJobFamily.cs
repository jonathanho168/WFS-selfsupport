using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tJobFamily")]
[Index("JobFamilyGuid", Name = "RG_tJobFamily", IsUnique = true)]
public partial class TJobFamily
{
    [Key]
    [StringLength(15)]
    public string JobFamilyCode { get; set; } = null!;

    [Column("JobFamilyGUID")]
    public Guid? JobFamilyGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? JobFamilyDescription { get; set; }

    [InverseProperty("JobFamilyCodeNavigation")]
    public virtual ICollection<TJob> TJobs { get; set; } = new List<TJob>();

    [InverseProperty("JobFamilyCodeNavigation")]
    public virtual ICollection<TSurveyFilterSetJobFamily> TSurveyFilterSetJobFamilies { get; set; } = new List<TSurveyFilterSetJobFamily>();
}
