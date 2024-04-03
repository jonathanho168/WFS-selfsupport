using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysSynchronizationPerson")]
public partial class UsysSynchronizationPerson
{
    [Key]
    [Column("SynchronizationPersonGUID")]
    public Guid SynchronizationPersonGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(80)]
    public string DataType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ChangeDateTime { get; set; }

    public int RowVersion { get; set; }
}
