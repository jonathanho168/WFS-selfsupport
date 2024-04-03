using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcJobCodes")]
public partial class DcJobCode
{
    [StringLength(50)]
    [Unicode(false)]
    public string? JobCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? JobTitle { get; set; }

    [Column("EEOCategoryCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EeocategoryCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JobCategoryCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JobFamilyCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JobGroupCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OvertimeStatusCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GradeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WorkersCompensationCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JobReportsToJobCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrgPublisherPositionTypeCode { get; set; }
}
