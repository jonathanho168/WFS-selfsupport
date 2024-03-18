using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPropertyFactTable
{
    [StringLength(15)]
    public string PropertyCode { get; set; } = null!;

    public string? PropertyDescription { get; set; }

    [StringLength(15)]
    public string PropertyTypeCode { get; set; } = null!;

    [StringLength(30)]
    public string? SerialNumber { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string IssuedFlag { get; set; } = null!;

    public bool CopossessionFlag { get; set; }

    public bool EmployeeOwnedFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PropertyIssueDate { get; set; }

    public int? PropertyIssueDateYear { get; set; }

    public int? PropertyIssueDateQuarter { get; set; }

    public int? PropertyIssueDateMonth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PropertyReturnDate { get; set; }

    public int? PropertyReturnDateYear { get; set; }

    public int? PropertyReturnDateQuarter { get; set; }

    public int? PropertyReturnDateMonth { get; set; }

    [StringLength(15)]
    public string? PropertyReturnReason { get; set; }

    [StringLength(15)]
    public string? PropertyIssueReason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnDueDate { get; set; }

    public int? ReturnDueDateYear { get; set; }

    public int? ReturnDueDateQuarter { get; set; }

    public int? ReturnDueDateMonth { get; set; }

    public string? CodeDescription { get; set; }

    public int NumberOfDaysIssued { get; set; }

    public int NumberOfDaysNotIssued { get; set; }
}
