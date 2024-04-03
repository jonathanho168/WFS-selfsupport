using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonPayStubArchive")]
[Index("PersonGuid", "PayStubDate", Name = "AK_tPersonPayStubArchive", IsUnique = true)]
public partial class TPersonPayStubArchive
{
    [Key]
    [Column("PersonPayStubArchiveGUID")]
    public Guid PersonPayStubArchiveGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PayStubDate { get; set; }

    [Column("PersonPayStubXML", TypeName = "xml")]
    public string? PersonPayStubXml { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ArchiveDate { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonPayStubArchives")]
    public virtual TPerson Person { get; set; } = null!;
}
