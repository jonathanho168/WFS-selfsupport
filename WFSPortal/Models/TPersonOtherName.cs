using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonOtherName")]
public partial class TPersonOtherName
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    public int PersonNameSequence { get; set; }

    [StringLength(15)]
    public string NameTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string CountryCode { get; set; } = null!;

    [StringLength(5)]
    public string? Salutation { get; set; }

    [StringLength(30)]
    public string? LastName { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }

    [StringLength(30)]
    public string? MiddleName { get; set; }

    [StringLength(30)]
    public string? Suffix { get; set; }

    [StringLength(30)]
    public string? Nickname { get; set; }

    [StringLength(30)]
    public string? FormerLastName { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string? LanguageCode { get; set; }

    [StringLength(30)]
    public string? Pronunciation { get; set; }

    [Key]
    [Column("PersonOtherNameGUID")]
    public Guid PersonOtherNameGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("TPersonOtherNames")]
    public virtual TCountry CountryCodeNavigation { get; set; } = null!;

    [ForeignKey("LanguageCode")]
    [InverseProperty("TPersonOtherNames")]
    public virtual TLanguage? LanguageCodeNavigation { get; set; }

    [ForeignKey("NameTypeCode")]
    [InverseProperty("TPersonOtherNames")]
    public virtual TNameType NameTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonOtherNames")]
    public virtual TPerson Person { get; set; } = null!;
}
