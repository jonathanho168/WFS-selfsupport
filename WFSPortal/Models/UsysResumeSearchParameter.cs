using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysResumeSearchParameter")]
public partial class UsysResumeSearchParameter
{
    [Key]
    [Column("SysResumeSearchParameterGUID")]
    public Guid SysResumeSearchParameterGuid { get; set; }

    [Column("SysResumeSearchGUID")]
    public Guid SysResumeSearchGuid { get; set; }

    [StringLength(255)]
    public string ParameterName { get; set; } = null!;

    public string? ParameterValue1 { get; set; }

    public string? ParameterValue2 { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("SysResumeSearchGuid")]
    [InverseProperty("UsysResumeSearchParameters")]
    public virtual UsysResumeSearch SysResumeSearch { get; set; } = null!;
}
