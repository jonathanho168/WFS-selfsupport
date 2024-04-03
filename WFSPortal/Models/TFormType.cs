using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tFormType")]
[Index("FormTypeGuid", Name = "RG_tFormType", IsUnique = true)]
public partial class TFormType
{
    [Key]
    [StringLength(15)]
    public string FormTypeCode { get; set; } = null!;

    [Column("FormTypeGUID")]
    public Guid FormTypeGuid { get; set; }

    public string? FormTypeDescription { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("FormTypeCodeNavigation")]
    public virtual ICollection<TGovFormAdditionalFile> TGovFormAdditionalFiles { get; set; } = new List<TGovFormAdditionalFile>();

    [InverseProperty("FormTypeCodeNavigation")]
    public virtual ICollection<TPersonGovFormHist> TPersonGovFormHists { get; set; } = new List<TPersonGovFormHist>();
}
