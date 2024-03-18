using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_834_w_5010_2000_INS")]
public partial class Lnk834W50102000In
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("InsuredIndicator-INS01")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InsuredIndicatorIns01 { get; set; }

    [Column("RelationshipCode-INS02")]
    [StringLength(2)]
    [Unicode(false)]
    public string? RelationshipCodeIns02 { get; set; }

    [Column("MaintenanceTypeCode-INS03")]
    [StringLength(3)]
    [Unicode(false)]
    public string? MaintenanceTypeCodeIns03 { get; set; }

    [Column("MaintenanceReasonCode-INS04")]
    [StringLength(3)]
    [Unicode(false)]
    public string? MaintenanceReasonCodeIns04 { get; set; }

    [Column("BenefitStatusCode-INS05")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BenefitStatusCodeIns05 { get; set; }

    [Column("MedicarePlanCode-INS06")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MedicarePlanCodeIns06 { get; set; }

    [Column("COBRAQualifyingCode-INS07")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CobraqualifyingCodeIns07 { get; set; }

    [Column("EmploymentStatusCode-INS08")]
    [StringLength(15)]
    [Unicode(false)]
    public string? EmploymentStatusCodeIns08 { get; set; }

    [Column("StudentStatus-INS09")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StudentStatusIns09 { get; set; }

    [Column("HandicapIndicator-INS10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? HandicapIndicatorIns10 { get; set; }

    [Column("DateFormatQualifier-INS11")]
    [StringLength(3)]
    [Unicode(false)]
    public string? DateFormatQualifierIns11 { get; set; }

    [Column("DeathDate-INS12")]
    [StringLength(8)]
    [Unicode(false)]
    public string? DeathDateIns12 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Relationship { get; set; }
}
