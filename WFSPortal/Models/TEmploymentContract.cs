using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tEmploymentContract")]
[Index("EmploymentContractGuid", Name = "RG_tEmploymentContract", IsUnique = true)]
public partial class TEmploymentContract
{
    [Key]
    [StringLength(15)]
    public string EmploymentContractCode { get; set; } = null!;

    public string? EmploymentContractDescription { get; set; }

    [Column("EmploymentContractGUID")]
    public Guid EmploymentContractGuid { get; set; }

    [StringLength(15)]
    public string CompanyCode { get; set; } = null!;

    public string? WorkplaceAddress { get; set; }

    public string? EmployerAddress { get; set; }

    public string? IncapacityToWorkDetails { get; set; }

    public string? ParticularsOfPensions { get; set; }

    public string? TerminationDetails { get; set; }

    [Column("TermsRelatedToReturningToUK")]
    public string? TermsRelatedToReturningToUk { get; set; }

    public string? DisciplinaryRulesWhichApply { get; set; }

    public string? CollectiveAgreementsForTermsAndConditions { get; set; }

    [StringLength(20)]
    public string? TerminationEmployerNoticeTimePeriod { get; set; }

    [StringLength(20)]
    public string? TerminationEmployeeNoticeTimePeriod { get; set; }

    [StringLength(30)]
    public string? CurrencyEmployeesPaid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CompanyCode")]
    [InverseProperty("TEmploymentContracts")]
    public virtual TCompany CompanyCodeNavigation { get; set; } = null!;
}
