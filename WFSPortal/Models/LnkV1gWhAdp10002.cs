using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_V1G_wh_ADP10002")]
public partial class LnkV1gWhAdp10002
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("AssociateID")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AssociateId { get; set; }

    [Column("PositionID")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PositionId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CompanyCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FileNumber { get; set; }

    [Column("IsPaidbyWFN")]
    [StringLength(100)]
    [Unicode(false)]
    public string? IsPaidbyWfn { get; set; }

    [Column("TaxIDType")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TaxIdtype { get; set; }

    [Column("TaxIDNumber")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TaxIdnumber { get; set; }

    [Column("FName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fname { get; set; }

    [Column("LName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Lname { get; set; }

    [Column("SSN")]
    [StringLength(11)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [Column("SSN_enc")]
    [StringLength(255)]
    public string? SsnEnc { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? Zip { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? HomeAreaCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? HomePhone { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BirthDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ActualMaritalStatus { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("EEOEthnic")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Eeoethnic { get; set; }

    [Column("EEOOccupation")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Eeooccupation { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PayFrequency { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrimaryRateDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? RateType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Rate1Amount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? IncreaseType { get; set; }

    [Column("FLSACode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Flsacode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? HomeDepartment { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? JobTitle { get; set; }

    [Column("POCDept")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Pocdept { get; set; }

    [Column("POCDivision")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Pocdivision { get; set; }

    [Column("POCSection")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Pocsection { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Shift { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? HireDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? HireStatus { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SeniorityDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LeaveStartDate { get; set; }

    [Column("LOAReturnDate")]
    [StringLength(10)]
    [Unicode(false)]
    public string? LoareturnDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TerminationDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TerminationReason { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? StandardHours { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RehireDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WorkersCompCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? UnionCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FedFilingStatus { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? FederalExemptions { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FedAdditionalTax { get; set; }

    [Column("SUISDITaxCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? SuisditaxCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WorkedStateTaxCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? LocationCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? EmployeeType { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ScheduleCode { get; set; }

    [Column(TypeName = "numeric(28, 18)")]
    public decimal? PeriodFactor { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? NormalHoursPerWeek { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? PayAmount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ToPayFrequency { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PayrollFrequency { get; set; }
}
