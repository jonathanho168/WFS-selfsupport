using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkTableCriteria")]
public partial class UsysLnkTableCriterion
{
    public byte Sequence { get; set; }

    [StringLength(2000)]
    public string? Criteria { get; set; }

    [Key]
    [Column("LnkTableCriteriaGUID")]
    public Guid LnkTableCriteriaGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("LnkTableGUID")]
    public Guid LnkTableGuid { get; set; }

    [ForeignKey("LnkTableGuid")]
    [InverseProperty("UsysLnkTableCriteria")]
    public virtual UsysLnkTable LnkTable { get; set; } = null!;
}
