using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonERP")]
[Index("PersonErpguid", Name = "AK_tPersonERP", IsUnique = true)]
public partial class TPersonErp
{
    [Key]
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("PersonERPGUID")]
    public Guid PersonErpguid { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? LaborRate { get; set; }

    public bool PayrollFlag { get; set; }

    [Column("PRSetupReqFlag")]
    public bool PrsetupReqFlag { get; set; }

    public bool ServTechFlag { get; set; }

    [Column("DcdUserID")]
    [StringLength(75)]
    public string? DcdUserId { get; set; }

    public bool ProductionWorkerFlag { get; set; }

    public bool MaterialHandlerFlag { get; set; }

    public bool ShopSupervisorFlag { get; set; }

    public bool CanReportQtyFlag { get; set; }

    public bool CanOverrideJobFlag { get; set; }

    public bool CanRequestMaterialFlag { get; set; }

    public bool CanReportScrapQtyFlag { get; set; }

    [Column("CanReportNCQtyFlag")]
    public bool CanReportNcqtyFlag { get; set; }

    public bool ShipRecvFlag { get; set; }

    [Column("CnvEmpID")]
    [StringLength(8)]
    public string CnvEmpId { get; set; } = null!;

    public bool WarehouseManagerFlag { get; set; }

    public bool CanOverrideAllocationsFlag { get; set; }

    public bool AllowDirLbrFlag { get; set; }

    public bool ContractEmpFlag { get; set; }

    public bool ExpenseEntryAllowedFlag { get; set; }

    public int? ExpenseVendorNum { get; set; }

    public bool SyncNameToPerConFlag { get; set; }

    public bool SyncAddressToPerConFlag { get; set; }

    public bool SyncPhoneToPerConFlag { get; set; }

    public bool SyncEmailToPerConFlag { get; set; }

    public bool CanEnterIndirectTimeFlag { get; set; }

    public bool CanEnterProductionTimeFlag { get; set; }

    public bool CanEnterProjectTimeFlag { get; set; }

    public bool CanEnterServiceTimeFlag { get; set; }

    public bool CanEnterSetupTimeFlag { get; set; }

    public bool TimeAutoApproveFlag { get; set; }

    public bool ExpenseAutoApproveFlag { get; set; }

    public bool AllowIndirectFlag { get; set; }

    public bool AllowProductionFlag { get; set; }

    public bool AllowProjectFlag { get; set; }

    public bool AllowServiceFlag { get; set; }

    public bool AllowSetupFlag { get; set; }

    public bool DefaultTaxIncludedFlag { get; set; }

    public bool ExpenseAdvReqAutoApproveFlag { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? DefaultLaborHrs { get; set; }

    public bool ExpenseAdvReqAllowedFlag { get; set; }

    [Column("ERPEmployeeIDGenerated")]
    public long ErpemployeeIdgenerated { get; set; }

    [Column("ERPEmployeeID")]
    [StringLength(8)]
    public string? ErpemployeeId { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonErp")]
    public virtual TPerson Person { get; set; } = null!;
}
