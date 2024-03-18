using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportSourceParameter")]
public partial class UsysLnkImportSourceParameter
{
    [Key]
    public Guid LnkImportSourceParameterGuid { get; set; }

    public Guid LnkImportSourceGuid { get; set; }

    [StringLength(80)]
    public string ParameterName { get; set; } = null!;

    public string? ParameterValue { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LnkImportSourceGuid")]
    [InverseProperty("UsysLnkImportSourceParameters")]
    public virtual UsysLnkImportSource LnkImportSource { get; set; } = null!;
}
