using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDrugTestType")]
[Index("DrugTestTypeGuid", Name = "RG_tDrugTestType", IsUnique = true)]
public partial class TDrugTestType
{
    [Key]
    [StringLength(15)]
    public string DrugTestTypeCode { get; set; } = null!;

    [Column("DrugTestTypeGUID")]
    public Guid DrugTestTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DrugTestTypeDescription { get; set; }

    [InverseProperty("DrugTestTypeCodeNavigation")]
    public virtual ICollection<TPersonDrugTest> TPersonDrugTests { get; set; } = new List<TPersonDrugTest>();
}
