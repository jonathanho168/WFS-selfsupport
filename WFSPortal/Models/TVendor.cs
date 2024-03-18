using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tVendor")]
public partial class TVendor
{
    [Key]
    [StringLength(15)]
    public string VendorCode { get; set; } = null!;

    public string? VendorDescription { get; set; }

    [StringLength(15)]
    public string VendorTypeCode { get; set; } = null!;

    [Column("VendorGUID")]
    public Guid VendorGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(255)]
    public string? Address { get; set; }

    [StringLength(255)]
    public string? Address2 { get; set; }

    [StringLength(255)]
    public string? Address3 { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(15)]
    public string StateProvinceCode { get; set; } = null!;

    [StringLength(12)]
    public string? PostalCode { get; set; }

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [StringLength(255)]
    public string? RepresentativeName { get; set; }

    [StringLength(20)]
    public string? RepresentativePhoneNumber { get; set; }

    public bool PayrollAccumulatorImportFlag { get; set; }

    public bool PayrollExportFlag { get; set; }

    [StringLength(15)]
    public string VendorEmployeeIdentifierCode { get; set; } = null!;

    [ForeignKey("CountryCode")]
    [InverseProperty("TVendors")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TVendors")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;

    [InverseProperty("VendorCodeNavigation")]
    public virtual ICollection<TPayrollVendorCompany> TPayrollVendorCompanies { get; set; } = new List<TPayrollVendorCompany>();

    [InverseProperty("VendorCodeNavigation")]
    public virtual ICollection<TVendorUserField> TVendorUserFields { get; set; } = new List<TVendorUserField>();

    [InverseProperty("VendorCodeNavigation")]
    public virtual ICollection<UsysLnkImportMaster> UsysLnkImportMasters { get; set; } = new List<UsysLnkImportMaster>();

    [ForeignKey("VendorEmployeeIdentifierCode")]
    [InverseProperty("TVendors")]
    public virtual UsysVendorEmployeeIdentifier VendorEmployeeIdentifierCodeNavigation { get; set; } = null!;

    [ForeignKey("VendorTypeCode")]
    [InverseProperty("TVendors")]
    public virtual UsysVendorType VendorTypeCodeNavigation { get; set; } = null!;
}
