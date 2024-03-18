using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSignatureQuestion")]
[Index("SignatureQuestionGuid", Name = "RG_tSignatureQuestion", IsUnique = true)]
public partial class TSignatureQuestion
{
    [Key]
    [StringLength(15)]
    public string SignatureQuestionCode { get; set; } = null!;

    public bool? InactiveFlag { get; set; }

    [Column("SignatureQuestionGUID")]
    public Guid SignatureQuestionGuid { get; set; }

    public int RowVersion { get; set; }

    public string? SignatureQuestionDescription { get; set; }

    [InverseProperty("SignatureQuestionCodeNavigation")]
    public virtual ICollection<UsysUserSignatureAnswer> UsysUserSignatureAnswers { get; set; } = new List<UsysUserSignatureAnswer>();
}
