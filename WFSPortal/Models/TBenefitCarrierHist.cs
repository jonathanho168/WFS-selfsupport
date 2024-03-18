using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitCarrierHist")]
[Index("BenefitPlanCode", "BenefitCarrierStartDate", "CarrierCode", Name = "AK_tBenefitCarrierHist", IsUnique = true)]
public partial class TBenefitCarrierHist
{
    [StringLength(15)]
    public string BenefitPlanCode { get; set; } = null!;

    [StringLength(15)]
    public string CarrierCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime BenefitCarrierStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BenefitCarrierEndDate { get; set; }

    [StringLength(30)]
    public string? BillingAccountNumber { get; set; }

    [StringLength(30)]
    public string? ClaimAccountNumber { get; set; }

    [Column("PlanIDNumber")]
    [StringLength(15)]
    public string? PlanIdnumber { get; set; }

    [Column("TransmissionID")]
    [StringLength(30)]
    public string? TransmissionId { get; set; }

    public bool BenefitCarrierCurrentFlag { get; set; }

    [Key]
    [Column("BenefitCarrierGUID")]
    public Guid BenefitCarrierGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("BenefitPlanCode")]
    [InverseProperty("TBenefitCarrierHists")]
    public virtual TBenefitPlan BenefitPlanCodeNavigation { get; set; } = null!;

    [ForeignKey("CarrierCode")]
    [InverseProperty("TBenefitCarrierHists")]
    public virtual TCarrier CarrierCodeNavigation { get; set; } = null!;
}
