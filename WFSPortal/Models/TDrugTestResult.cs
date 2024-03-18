using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDrugTestResult")]
[Index("DrugTestResultGuid", Name = "RG_tDrugTestResult", IsUnique = true)]
public partial class TDrugTestResult
{
    [Key]
    [StringLength(15)]
    public string DrugTestResultCode { get; set; } = null!;

    [Column("DrugTestResultGUID")]
    public Guid DrugTestResultGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DrugTestResultDescription { get; set; }

    [InverseProperty("DrugTestResultCodeNavigation")]
    public virtual ICollection<TPersonDrugTest> TPersonDrugTests { get; set; } = new List<TPersonDrugTest>();
}
