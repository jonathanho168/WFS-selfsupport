using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonPropertyCardHist")]
[Index("CardNumber", "PersonGuid", "PersonPropertyCardStartDate", Name = "AK_tPersonPropertyCardHist", IsUnique = true)]
public partial class TPersonPropertyCardHist
{
    [Key]
    [Column("PersonPropertyCardGUID")]
    public Guid PersonPropertyCardGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(30)]
    public string CardNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PersonPropertyCardStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonPropertyCardEndDate { get; set; }

    public bool PersonPropertyCardCurrentFlag { get; set; }

    [StringLength(15)]
    public string PropertyCardTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    [StringLength(30)]
    public string? NameOnCard { get; set; }

    [StringLength(15)]
    public string IssueReasonCode { get; set; } = null!;

    [StringLength(15)]
    public string ReturnReasonCode { get; set; } = null!;

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("IssueReasonCode")]
    [InverseProperty("TPersonPropertyCardHistIssueReasonCodeNavigations")]
    public virtual TPropertyReason IssueReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonPropertyCardHists")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PropertyCardTypeCode")]
    [InverseProperty("TPersonPropertyCardHists")]
    public virtual TPropertyCardType PropertyCardTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("ReturnReasonCode")]
    [InverseProperty("TPersonPropertyCardHistReturnReasonCodeNavigations")]
    public virtual TPropertyReason ReturnReasonCodeNavigation { get; set; } = null!;
}
