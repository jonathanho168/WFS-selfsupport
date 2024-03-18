using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("Lnk_834_InsData_834HM")]
public partial class Lnk834InsData834hm
{
    [Column("PersonGUID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PersonGuid { get; set; }

    [Column("ResponsiblePersonGUID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitEndDate { get; set; }

    [Column("EmployeeID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmployeeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RelationShipCode { get; set; }

    public bool? SpousalEquivalencyFlag { get; set; }

    public bool? FullTimeStudentFlag { get; set; }

    public bool? CobraFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CobraEvent { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PostalCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatusCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatusCategoryCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OriginalHireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LatestHireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonStatusStartDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DisabilityCode { get; set; }
}
