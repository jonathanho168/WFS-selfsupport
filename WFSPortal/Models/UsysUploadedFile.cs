using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysUploadedFile")]
[Index("UploadedFileDescription", Name = "AK_USysUploadedFile", IsUnique = true)]
public partial class UsysUploadedFile
{
    [Key]
    [Column("UploadedFileGUID")]
    public Guid UploadedFileGuid { get; set; }

    [StringLength(80)]
    public string? UploadedFileDescription { get; set; }

    public int? RowVersion { get; set; }

    public byte[]? FileContents { get; set; }

    public bool RequiresAuthenticationFlag { get; set; }
}
