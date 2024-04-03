using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonPropertyFactTable
{
    [Column("PersonPropertyGUID")]
    public Guid PersonPropertyGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string PropertyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssueDate { get; set; }

    public int? IssueDateYear { get; set; }

    public int? IssueDateQuarter { get; set; }

    public int? IssueDateMonth { get; set; }

    [StringLength(15)]
    public string PropertyTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ReturnDueDate { get; set; }

    public int? ReturnDueDateYear { get; set; }

    public int? ReturnDueDateQuarter { get; set; }

    public int? ReturnDueDateMonth { get; set; }

    [StringLength(15)]
    public string IssueReasonCode { get; set; } = null!;

    [StringLength(30)]
    public string? SerialNumber { get; set; }

    public bool EmployeeOwnedFlag { get; set; }

    public bool CopossessionFlag { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    public int NumberOfDaysIssued { get; set; }
}
