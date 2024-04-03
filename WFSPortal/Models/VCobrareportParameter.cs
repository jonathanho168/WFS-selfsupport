using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VCobrareportParameter
{
    [Column("COBRAReportParametersGUID")]
    public Guid CobrareportParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? AdministratorStateProvinceCode { get; set; }

    public string? LatePaymentGracePeriod { get; set; }

    public string? AdministratorCountryCode { get; set; }

    public string? SuspendCoveragePolicy { get; set; }

    public string? PaymentNoticeSent { get; set; }

    [Column("PostMaritalStatusDependentChange_ProcDoc")]
    public string? PostMaritalStatusDependentChangeProcDoc { get; set; }

    public string? AdministratorAddress { get; set; }

    public string? AdministratorCity { get; set; }

    public string? AdministrationFeePercent { get; set; }

    [Column("ElectionNoticeReturn_ProcDoc")]
    public string? ElectionNoticeReturnProcDoc { get; set; }

    public string? SuspendCoverageOnLatePayment { get; set; }

    public string? AdministratorAddress2 { get; set; }

    [Column("DisabilityExtensionClaim_ProcDoc")]
    public string? DisabilityExtensionClaimProcDoc { get; set; }

    public string? AdministratorPostalCode { get; set; }

    [Column("PostMaritalStatusDependentChange_DaysToNotify")]
    public string? PostMaritalStatusDependentChangeDaysToNotify { get; set; }

    public string? AdministratorPhone { get; set; }

    public string? AdministratorName { get; set; }
}
