using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkCompanyTango
{
    [StringLength(15)]
    public string CompanyCode { get; set; } = null!;

    [StringLength(20)]
    public string? AreaCode { get; set; }

    [StringLength(20)]
    public string? Phone { get; set; }

    [StringLength(20)]
    public string? FaxAreaCode { get; set; }

    [StringLength(20)]
    public string? FaxPhone { get; set; }

    [StringLength(255)]
    public string? Address { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [StringLength(12)]
    public string? PostalCode { get; set; }

    [StringLength(15)]
    public string StateProvinceCode { get; set; } = null!;

    [Column("FederalTaxID")]
    [StringLength(10)]
    public string? FederalTaxId { get; set; }

    [Column("StateTaxID")]
    [StringLength(10)]
    public string? StateTaxId { get; set; }

    [Column("SICCode")]
    [StringLength(4)]
    public string? Siccode { get; set; }

    [Column("NAICSCode")]
    [StringLength(6)]
    public string? Naicscode { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("CompanyGUID")]
    public Guid CompanyGuid { get; set; }

    [StringLength(20)]
    public string? InternationalPrefix { get; set; }

    [StringLength(20)]
    public string? NationalPrefix { get; set; }

    [StringLength(20)]
    public string? FaxInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? FaxNationalPrefix { get; set; }

    public byte[]? Logo { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string? Vets100CompanyNumber { get; set; }

    [StringLength(30)]
    public string? Vets100CompanyContactName { get; set; }

    [StringLength(20)]
    public string? Vets100CompanyContactAreaCode { get; set; }

    [StringLength(20)]
    public string? Vets100CompanyContactPhone { get; set; }

    [StringLength(255)]
    public string? Vets100CompanyContactEmailAddress { get; set; }

    public string? CompanyDescription { get; set; }

    public string? IndustryDescription { get; set; }

    [StringLength(20)]
    public string? CanadianBusinessNumber { get; set; }

    [StringLength(20)]
    public string? QuebecEnterpriseNumber { get; set; }

    [StringLength(255)]
    public string? MailAddress { get; set; }

    [StringLength(30)]
    public string? MailCity { get; set; }

    [StringLength(15)]
    public string MailCountryCode { get; set; } = null!;

    [StringLength(12)]
    public string? MailPostalCode { get; set; }

    [StringLength(15)]
    public string MailStateProvinceCode { get; set; } = null!;

    [StringLength(20)]
    public string? MobileAreaCode { get; set; }

    [StringLength(20)]
    public string? MobilePhone { get; set; }

    [StringLength(20)]
    public string? MobileInternationalPrefix { get; set; }

    [StringLength(20)]
    public string? MobileNationalPrefix { get; set; }

    [StringLength(255)]
    public string? EmailAddress { get; set; }

    [StringLength(30)]
    public string? County { get; set; }

    [Column("ACAContactFirstName")]
    [StringLength(30)]
    public string? AcacontactFirstName { get; set; }

    [Column("ACAContactLastName")]
    [StringLength(30)]
    public string? AcacontactLastName { get; set; }

    [Column("ACAContactAreaCode")]
    [StringLength(20)]
    public string? AcacontactAreaCode { get; set; }

    [Column("ACAContactPhone")]
    [StringLength(20)]
    public string? AcacontactPhone { get; set; }

    [Column("ACADGEName")]
    [StringLength(255)]
    public string? Acadgename { get; set; }

    [Column("ACADGEEIN")]
    [StringLength(10)]
    public string? Acadgeein { get; set; }

    [Column("ACADGECountryCode")]
    [StringLength(15)]
    public string AcadgecountryCode { get; set; } = null!;

    [Column("ACADGEAddress")]
    [StringLength(255)]
    public string? Acadgeaddress { get; set; }

    [Column("ACADGECity")]
    [StringLength(30)]
    public string? Acadgecity { get; set; }

    [Column("ACADGEStateProvinceCode")]
    [StringLength(15)]
    public string AcadgestateProvinceCode { get; set; } = null!;

    [Column("ACADGEPostalCode")]
    [StringLength(12)]
    public string? AcadgepostalCode { get; set; }

    [Column("ACADGEContactFirstName")]
    [StringLength(30)]
    public string? AcadgecontactFirstName { get; set; }

    [Column("ACADGEContactLastName")]
    [StringLength(30)]
    public string? AcadgecontactLastName { get; set; }

    [Column("ACADGEContactAreaCode")]
    [StringLength(20)]
    public string? AcadgecontactAreaCode { get; set; }

    [Column("ACADGEContactPhone")]
    [StringLength(20)]
    public string? AcadgecontactPhone { get; set; }

    [Column("ACAContactMiddleName")]
    [StringLength(30)]
    public string? AcacontactMiddleName { get; set; }

    [Column("ACADGEContactMiddleName")]
    [StringLength(30)]
    public string? AcadgecontactMiddleName { get; set; }

    [Column("ACA1095ContactAreaCode")]
    [StringLength(20)]
    public string? Aca1095contactAreaCode { get; set; }

    [Column("ACA1095ContactPhone")]
    [StringLength(20)]
    public string? Aca1095contactPhone { get; set; }
}
