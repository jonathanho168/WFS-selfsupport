using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VOrgPublisherPerson
{
    [Column("OrgPublisherPersonGUID")]
    public Guid OrgPublisherPersonGuid { get; set; }

    public int RowVersion { get; set; }

    public byte[]? Picture { get; set; }

    [Column("PictureGUID")]
    public Guid? PictureGuid { get; set; }

    [Column("SupervisorPersonGUID")]
    public Guid? SupervisorPersonGuid { get; set; }

    public string? BoxTitle { get; set; }

    [StringLength(15)]
    public string? PositionTypeCode { get; set; }

    [Column("EmployeeID")]
    [StringLength(24)]
    public string? EmployeeId { get; set; }

    [StringLength(30)]
    public string LastName { get; set; } = null!;

    [StringLength(30)]
    public string? FirstName { get; set; }

    [StringLength(30)]
    public string? MiddleName { get; set; }

    [StringLength(15)]
    public string? JobCode { get; set; }

    public string? JobTitle { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SeniorityDate { get; set; }

    [StringLength(255)]
    public string? CompanyEmailAddress { get; set; }

    [StringLength(80)]
    public string? BusinessCardTitle { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AnnualRate { get; set; }
}
