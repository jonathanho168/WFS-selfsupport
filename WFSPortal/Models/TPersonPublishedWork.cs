using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonPublishedWork")]
public partial class TPersonPublishedWork
{
    [Key]
    [Column("PersonPublishedWorkGUID")]
    public Guid PersonPublishedWorkGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string PublishedWorkTypeCode { get; set; } = null!;

    [StringLength(80)]
    public string Title { get; set; } = null!;

    [StringLength(80)]
    public string? Publication { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PublishedDate { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonPublishedWorks")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PublishedWorkTypeCode")]
    [InverseProperty("TPersonPublishedWorks")]
    public virtual TPublishedWorkType PublishedWorkTypeCodeNavigation { get; set; } = null!;
}
