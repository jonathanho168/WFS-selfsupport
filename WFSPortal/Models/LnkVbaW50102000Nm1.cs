using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_VBA_w_5010_2000_NM1")]
public partial class LnkVbaW50102000Nm1
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("EntityIdentifierCode-NM101")]
    [StringLength(2)]
    [Unicode(false)]
    public string? EntityIdentifierCodeNm101 { get; set; }

    [Column("EntityTypeCode-NM102")]
    [StringLength(1)]
    [Unicode(false)]
    public string? EntityTypeCodeNm102 { get; set; }

    [Column("LastName-NM103")]
    [StringLength(35)]
    [Unicode(false)]
    public string? LastNameNm103 { get; set; }

    [Column("FirstName-NM104")]
    [StringLength(25)]
    [Unicode(false)]
    public string? FirstNameNm104 { get; set; }

    [Column("MiddleName-NM105")]
    [StringLength(25)]
    [Unicode(false)]
    public string? MiddleNameNm105 { get; set; }

    [Column("NamePrefix-NM106")]
    [StringLength(10)]
    [Unicode(false)]
    public string? NamePrefixNm106 { get; set; }

    [Column("NameSuffix-NM107")]
    [StringLength(10)]
    [Unicode(false)]
    public string? NameSuffixNm107 { get; set; }

    [Column("IDCodeQualifier-NM108")]
    [StringLength(2)]
    [Unicode(false)]
    public string? IdcodeQualifierNm108 { get; set; }

    [Column("IDCode-NM109")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdcodeNm109 { get; set; }

    [Column("IDCode-NM109_enc")]
    [StringLength(255)]
    public string? IdcodeNm109Enc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Relationship { get; set; }
}
