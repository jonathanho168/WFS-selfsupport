using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonPropertyHist")]
[Index("PropertyCode", "PersonGuid", "PersonPropertyStartDate", Name = "AK_tPersonPropertyHist", IsUnique = true)]
public partial class TPersonPropertyHist
{
    [Key]
    [Column("PersonPropertyGUID")]
    public Guid PersonPropertyGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string PropertyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PersonPropertyStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonPropertyEndDate { get; set; }

    public bool PersonPropertyCurrentFlag { get; set; }

    [StringLength(15)]
    public string IssueReasonCode { get; set; } = null!;

    [StringLength(15)]
    public string ReturnReasonCode { get; set; } = null!;

    public string? Comments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnDueDate { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("IssueReasonCode")]
    [InverseProperty("TPersonPropertyHistIssueReasonCodeNavigations")]
    public virtual TPropertyReason IssueReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonPropertyHists")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PropertyCode")]
    [InverseProperty("TPersonPropertyHists")]
    public virtual TProperty PropertyCodeNavigation { get; set; } = null!;

    [ForeignKey("ReturnReasonCode")]
    [InverseProperty("TPersonPropertyHistReturnReasonCodeNavigations")]
    public virtual TPropertyReason ReturnReasonCodeNavigation { get; set; } = null!;
}
