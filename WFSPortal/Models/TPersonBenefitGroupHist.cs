using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonBenefitGroupHist")]
public partial class TPersonBenefitGroupHist
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonBenefitGroupStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitGroupEndDate { get; set; }

    public bool PersonBenefitGroupCurrentFlag { get; set; }

    [StringLength(15)]
    public string BenefitGroupCode { get; set; } = null!;

    [Key]
    [Column("PersonBenefitGroupGUID")]
    public Guid PersonBenefitGroupGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("BenefitGroupCode")]
    [InverseProperty("TPersonBenefitGroupHists")]
    public virtual TBenefitGroup BenefitGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonBenefitGroupHists")]
    public virtual TPerson Person { get; set; } = null!;
}
