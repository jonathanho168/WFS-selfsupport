using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tApplicationAnswer")]
public partial class TApplicationAnswer
{
    public bool InactiveFlag { get; set; }

    [StringLength(15)]
    public string ApplicationAnswerTypeCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [Key]
    public Guid ApplicationAnswerGuid { get; set; }

    public int SortOrder { get; set; }

    public string? Description { get; set; }

    [ForeignKey("ApplicationAnswerTypeCode")]
    [InverseProperty("TApplicationAnswers")]
    public virtual TApplicationAnswerType ApplicationAnswerTypeCodeNavigation { get; set; } = null!;
}
