using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPayStubNote")]
public partial class TPayStubNote
{
    [Key]
    [Column("PayStubNoteGUID")]
    public Guid PayStubNoteGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public int RowVersion { get; set; }

    public string? NoteText { get; set; }
}
