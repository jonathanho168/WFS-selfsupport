using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tApplicationAnswerType")]
[Index("ApplicationAnswerTypeGuid", Name = "RG_tApplicationAnswerType", IsUnique = true)]
public partial class TApplicationAnswerType
{
    [Key]
    [StringLength(15)]
    public string ApplicationAnswerTypeCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public bool UserAddedFlag { get; set; }

    public int RowVersion { get; set; }

    public Guid ApplicationAnswerTypeGuid { get; set; }

    public string? ApplicationAnswerTypeDescription { get; set; }

    [InverseProperty("ApplicationAnswerTypeCodeNavigation")]
    public virtual ICollection<TApplicationAnswer> TApplicationAnswers { get; set; } = new List<TApplicationAnswer>();

    [InverseProperty("ApplicationAnswerTypeCodeNavigation")]
    public virtual ICollection<TApplicationQuestion> TApplicationQuestions { get; set; } = new List<TApplicationQuestion>();
}
