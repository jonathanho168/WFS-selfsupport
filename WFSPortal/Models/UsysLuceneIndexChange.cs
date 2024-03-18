using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLuceneIndexChange")]
public partial class UsysLuceneIndexChange
{
    [Key]
    [Column("LuceneIndexChangeGUID")]
    public Guid LuceneIndexChangeGuid { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string TriggerType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ObjectType { get; set; } = null!;

    [Column("ObjectGUID")]
    public Guid ObjectGuid { get; set; }

    public int RowVersion { get; set; }
}
