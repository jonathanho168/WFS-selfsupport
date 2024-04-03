using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VOrgPublisherPositionWithIncumbent
{
    [Column("OrgPublisherPositionWithIncumbentsGUID")]
    public Guid? OrgPublisherPositionWithIncumbentsGuid { get; set; }

    public int RowVersion { get; set; }

    public byte[]? Picture { get; set; }

    [Column("PictureGUID")]
    public Guid? PictureGuid { get; set; }

    [StringLength(15)]
    public string Supervisor { get; set; } = null!;

    [Column("ID")]
    [StringLength(15)]
    public string Id { get; set; } = null!;

    [StringLength(90)]
    public string Title { get; set; } = null!;

    [StringLength(15)]
    public string? PositionTypeCode { get; set; }

    [Column("EmployeeID")]
    [StringLength(24)]
    public string EmployeeId { get; set; } = null!;

    [StringLength(30)]
    public string LastName { get; set; } = null!;

    [StringLength(30)]
    public string FirstName { get; set; } = null!;

    [StringLength(30)]
    public string MiddleName { get; set; } = null!;

    public string? PositionStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PositionStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PositionEndDate { get; set; }
}
