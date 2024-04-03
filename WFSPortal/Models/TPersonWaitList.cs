using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonWaitList")]
[Index("PersonGuid", "CourseCode", "ClassGuid", Name = "AK_tPersonWaitList", IsUnique = true)]
public partial class TPersonWaitList
{
    [Key]
    [Column("PersonWaitListGUID")]
    public Guid PersonWaitListGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? RequestDate { get; set; }

    public bool HighPriorityFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public Guid? ClassGuid { get; set; }

    [ForeignKey("ClassGuid")]
    [InverseProperty("TPersonWaitLists")]
    public virtual TClass? Class { get; set; }

    [ForeignKey("CourseCode")]
    [InverseProperty("TPersonWaitLists")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonWaitLists")]
    public virtual TPerson Person { get; set; } = null!;
}
