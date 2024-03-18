using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysACAReportParameter")]
public partial class UsysAcareportParameter
{
    [StringLength(128)]
    public string UserName { get; set; } = null!;

    [Column("ALEGroupMemberName")]
    [StringLength(255)]
    public string? AlegroupMemberName { get; set; }

    [Column("ALEGroupMemberEIN")]
    [StringLength(10)]
    public string? AlegroupMemberEin { get; set; }

    [Key]
    [Column("USysACAReportParameterGUID")]
    public Guid UsysAcareportParameterGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EnteredDateTime { get; set; }

    public int RowVersion { get; set; }
}
