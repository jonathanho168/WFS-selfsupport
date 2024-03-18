using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonPropertyCardFactTable
{
    [Column("PersonPropertyCardGUID")]
    public Guid PersonPropertyCardGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CardIssueDate { get; set; }

    public int? CardIssueYear { get; set; }

    public int? CardIssueQuarter { get; set; }

    public int? CardIssueMonth { get; set; }

    [StringLength(15)]
    public string CardIssueReasonCode { get; set; } = null!;

    [StringLength(30)]
    public string CardNumber { get; set; } = null!;

    [StringLength(15)]
    public string PropertyCardTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    public int? ExpirationDateYear { get; set; }

    public int? ExpirationDateQuarter { get; set; }

    public int? ExpirationDateMonth { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    public int NumberOfDaysIssued { get; set; }
}
