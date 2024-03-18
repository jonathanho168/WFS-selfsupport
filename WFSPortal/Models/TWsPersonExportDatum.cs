using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tWsPersonExportData")]
public partial class TWsPersonExportDatum
{
    [Key]
    public int WsPersonExportDataId { get; set; }

    [StringLength(15)]
    public string WsExportTypeCode { get; set; } = null!;

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDateTime { get; set; }

    [Column("ExportDataXML", TypeName = "xml")]
    public string? ExportDataXml { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExportDateTime { get; set; }

    public byte ExportStatus { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? Result { get; set; }

    [Column("TSCol")]
    public byte[]? Tscol { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? UserName { get; set; }
}
