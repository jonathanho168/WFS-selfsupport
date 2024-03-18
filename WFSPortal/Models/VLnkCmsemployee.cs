using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkCmsemployee
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(43)]
    public string? HomePhoneNumber { get; set; }

    [StringLength(43)]
    public string? HomeFaxNumber { get; set; }

    [StringLength(43)]
    public string? WorkPhoneNumber { get; set; }

    [StringLength(5)]
    public string? WorkPhoneExtension { get; set; }

    [StringLength(80)]
    public string? BusinessCardTitle { get; set; }

    [Column(TypeName = "money")]
    public decimal? BaseLabourRate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateHired { get; set; }

    [StringLength(15)]
    public string? EmploymentType { get; set; }

    [StringLength(15)]
    public string? EmployeeStatus { get; set; }

    [StringLength(15)]
    public string? InactiveReason { get; set; }

    [StringLength(15)]
    public string? EmployeeClassCode { get; set; }

    [StringLength(15)]
    public string? EmployeeGroupCode { get; set; }

    [StringLength(15)]
    public string? ReferBusinessDepartment { get; set; }

    [StringLength(15)]
    public string? ReferPlantCode { get; set; }
}
