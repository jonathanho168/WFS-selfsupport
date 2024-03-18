using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class V834HmDistinct
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("ResponsiblePersonGUID")]
    public Guid ResponsiblePersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitEndDate { get; set; }

    [Column("EmployeeID")]
    [StringLength(24)]
    public string? EmployeeId { get; set; }

    [StringLength(15)]
    public string? RelationShipCode { get; set; }

    public bool? SpousalEquivalencyFlag { get; set; }

    public bool? FullTimeStudentFlag { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CobraFlag { get; set; }

    [StringLength(255)]
    public string? Address1 { get; set; }

    [StringLength(255)]
    public string? Address2 { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(15)]
    public string? State { get; set; }

    [StringLength(4000)]
    public string? PostalCode { get; set; }

    [StringLength(4000)]
    public string? Phone { get; set; }

    [StringLength(15)]
    public string? StatusCode { get; set; }

    [StringLength(15)]
    public string? StatusCategoryCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OriginalHireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LatestHireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonStatusStartDate { get; set; }

    [StringLength(15)]
    public string? DisabilityCode { get; set; }
}
