using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcGradeCodes")]
public partial class DcGradeCode
{
    [StringLength(50)]
    [Unicode(false)]
    public string? GradeCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GradeStartDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GradeCurrencyCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GradeFrequencyCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? RangeMaximumAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? RangeMidAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? RangeMinimumAmount { get; set; }
}
