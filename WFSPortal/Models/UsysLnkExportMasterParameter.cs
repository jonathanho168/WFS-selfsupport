using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportMasterParameter")]
public partial class UsysLnkExportMasterParameter
{
    [Key]
    public Guid LnkExportMasterParameterGuid { get; set; }

    [StringLength(15)]
    public string ExportId { get; set; } = null!;

    [StringLength(80)]
    public string ParameterName { get; set; } = null!;

    public string? ParameterValue { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ExportId")]
    [InverseProperty("UsysLnkExportMasterParameters")]
    public virtual UsysLnkExportMaster Export { get; set; } = null!;
}
