using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonI9")]
[Index("PersonGuid", "EffectiveDate", Name = "AK_tPersonI9", IsUnique = true)]
public partial class TPersonI9
{
    [Key]
    [Column("PersonI9GUID")]
    public Guid PersonI9guid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveDate { get; set; }

    [StringLength(30)]
    public string? LastName { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }

    [StringLength(30)]
    public string? MiddleName { get; set; }

    [StringLength(30)]
    public string? FormerLastName { get; set; }

    [StringLength(255)]
    public string? Address { get; set; }

    [StringLength(255)]
    public string? ApartmentNumber { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(15)]
    public string? StateProvinceCode { get; set; }

    [StringLength(12)]
    public string? PostalCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("SSN")]
    [StringLength(50)]
    public string? Ssn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EmployeeSignedByDate { get; set; }

    [Column("EmployerSignedByPersonGUID")]
    public Guid? EmployerSignedByPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EmployerSignedByDate { get; set; }

    public bool CitizenFlag { get; set; }

    public bool NonCitizenNationalFlag { get; set; }

    public bool PermanentResidentAlienFlag { get; set; }

    public bool AuthorizedAlienFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AuthorizedAlienExpirationDate { get; set; }

    [StringLength(50)]
    public string? AlienOrAdmissionNumber { get; set; }

    public int RowVersion { get; set; }

    [StringLength(255)]
    public string? EmailAddress { get; set; }

    [StringLength(20)]
    public string? PhoneNumber { get; set; }

    public bool UsingAdmissionNumberFlag { get; set; }

    [StringLength(50)]
    public string? AdmissionNumberDocumentNumber { get; set; }

    [StringLength(80)]
    public string? AdmissionNumberIssuingAuthority { get; set; }

    public string? AdditionalInformation { get; set; }

    public bool UsedTranslatorFlag { get; set; }

    [StringLength(30)]
    public string? PreparerFirstName { get; set; }

    [StringLength(30)]
    public string? PreparerLastName { get; set; }

    [StringLength(255)]
    public string? PreparerAddress { get; set; }

    [StringLength(30)]
    public string? PreparerCity { get; set; }

    [StringLength(15)]
    public string? PreparerStateProvinceCode { get; set; }

    [StringLength(12)]
    public string? PreparerPostalCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RehireDate { get; set; }

    [StringLength(30)]
    public string? RehireOrReverificationNewLastName { get; set; }

    [StringLength(30)]
    public string? RehireOrReverificationNewFirstName { get; set; }

    [StringLength(30)]
    public string? RehireOrReverificationNewMiddleInitial { get; set; }

    [Column("RehireOrReverificationEmployerSignedByPersonGUID")]
    public Guid? RehireOrReverificationEmployerSignedByPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RehireOrReverificationEmployerSignedByDate { get; set; }

    [Column("RehireOrReverificationFileGUID")]
    public Guid? RehireOrReverificationFileGuid { get; set; }

    public bool UsedAlternativeProcedureToExamineDocumentsFlag { get; set; }

    public bool RehireOrReverificationUsedAlternativeProcedureToExamineDocumentsFlag { get; set; }

    public string? RehireOrReverificationAdditionalInformation { get; set; }

    [StringLength(30)]
    public string? PreparerMiddleInitial { get; set; }

    [ForeignKey("EmployerSignedByPersonGuid")]
    [InverseProperty("TPersonI9EmployerSignedByPeople")]
    public virtual TPerson? EmployerSignedByPerson { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonI9People")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PreparerStateProvinceCode")]
    [InverseProperty("TPersonI9PreparerStateProvinceCodeNavigations")]
    public virtual TStateProvince? PreparerStateProvinceCodeNavigation { get; set; }

    [ForeignKey("RehireOrReverificationEmployerSignedByPersonGuid")]
    [InverseProperty("TPersonI9RehireOrReverificationEmployerSignedByPeople")]
    public virtual TPerson? RehireOrReverificationEmployerSignedByPerson { get; set; }

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TPersonI9StateProvinceCodeNavigations")]
    public virtual TStateProvince? StateProvinceCodeNavigation { get; set; }

    [InverseProperty("PersonI9")]
    public virtual ICollection<TPersonI9file> TPersonI9files { get; set; } = new List<TPersonI9file>();
}
