using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkTable")]
public partial class UsysLnkTable
{
    [StringLength(60)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    public byte? Sequence { get; set; }

    [Key]
    [Column("LnkTableGUID")]
    public Guid LnkTableGuid { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("LnkTable")]
    public virtual ICollection<UsysLnkTableCriterion> UsysLnkTableCriteria { get; set; } = new List<UsysLnkTableCriterion>();
}
