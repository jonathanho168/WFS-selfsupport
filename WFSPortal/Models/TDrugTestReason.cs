using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDrugTestReason")]
[Index("DrugTestReasonGuid", Name = "RG_tDrugTestReason", IsUnique = true)]
public partial class TDrugTestReason
{
    [Key]
    [StringLength(15)]
    public string DrugTestReasonCode { get; set; } = null!;

    [Column("DrugTestReasonGUID")]
    public Guid DrugTestReasonGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DrugTestReasonDescription { get; set; }

    [InverseProperty("DrugTestReasonCodeNavigation")]
    public virtual ICollection<TPersonDrugTest> TPersonDrugTests { get; set; } = new List<TPersonDrugTest>();
}
