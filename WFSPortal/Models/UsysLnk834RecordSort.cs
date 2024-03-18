using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[PrimaryKey("SortId", "ResponsiblePerson", "RelationshipSeq", "Person", "BenefitPlanCode", "RecordSequence")]
[Table("USysLnk834RecordSort")]
public partial class UsysLnk834RecordSort
{
    [Key]
    [Column("SortID")]
    public int SortId { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ResponsiblePerson { get; set; } = null!;

    [Key]
    public int RelationshipSeq { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Person { get; set; } = null!;

    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string BenefitPlanCode { get; set; } = null!;

    [Key]
    public int RecordSequence { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Data { get; set; }

    [Column("Lnk834RecordSortGUID")]
    public Guid Lnk834RecordSortGuid { get; set; }

    public int RowVersion { get; set; }
}
