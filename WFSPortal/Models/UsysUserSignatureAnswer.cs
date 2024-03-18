using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysUserSignatureAnswer")]
public partial class UsysUserSignatureAnswer
{
    [StringLength(15)]
    public string SignatureQuestionCode { get; set; } = null!;

    [Column("UserGUID")]
    public Guid UserGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SignatureAnswerDate { get; set; }

    [StringLength(80)]
    public string SignatureAnswer { get; set; } = null!;

    [Key]
    [Column("UserSignatureAnswerGUID")]
    public Guid UserSignatureAnswerGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("SignatureQuestionCode")]
    [InverseProperty("UsysUserSignatureAnswers")]
    public virtual TSignatureQuestion SignatureQuestionCodeNavigation { get; set; } = null!;

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysUserSignatureAnswers")]
    public virtual UsysUser User { get; set; } = null!;
}
