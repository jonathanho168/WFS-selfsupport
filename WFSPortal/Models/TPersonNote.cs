using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonNotes")]
public partial class TPersonNote
{
    [Key]
    [Column("PersonNotesGUID")]
    public Guid PersonNotesGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string NoteTypeCode { get; set; } = null!;

    [StringLength(80)]
    public string Source { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime NoteDate { get; set; }

    public string? NoteDetails { get; set; }

    public string? Resolution { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResolutionDate { get; set; }

    public byte[]? NoteFile { get; set; }

    [StringLength(10)]
    public string? NoteFileExtension { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("NoteTypeCode")]
    [InverseProperty("TPersonNotes")]
    public virtual TNoteType NoteTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonNotes")]
    public virtual TPerson Person { get; set; } = null!;
}
