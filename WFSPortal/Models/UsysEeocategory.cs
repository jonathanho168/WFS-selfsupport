using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysEEOCategory")]
[Index("EeocategoryGuid", Name = "RG_USysEEOCategory", IsUnique = true)]
public partial class UsysEeocategory
{
    [Key]
    [Column("EEOCategoryCode")]
    [StringLength(15)]
    public string EeocategoryCode { get; set; } = null!;

    [Column("EOSurveyFlag")]
    public bool EosurveyFlag { get; set; }

    [Column("EEOCategoryGUID")]
    public Guid EeocategoryGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Column("EEOCategoryDescription")]
    public string? EeocategoryDescription { get; set; }
}
