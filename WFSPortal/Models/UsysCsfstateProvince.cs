using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCSFStateProvince")]
public partial class UsysCsfstateProvince
{
    [Key]
    [Column("CSFStateProvinceGuid")]
    public Guid CsfstateProvinceGuid { get; set; }

    [StringLength(15)]
    public string StateProvinceCode { get; set; } = null!;

    [Column("CSFCode")]
    [StringLength(15)]
    public string Csfcode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("Csfcode")]
    [InverseProperty("UsysCsfstateProvinces")]
    public virtual UsysCsf CsfcodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("UsysCsfstateProvinces")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;
}
